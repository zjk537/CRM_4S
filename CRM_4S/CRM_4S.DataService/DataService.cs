using CRM_4S.DataService.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace CRM_4S.DataService
{
    public class DataService : IDataService
    {
        public DataService()
        {
            CacheManager.UserTimeOutValidator();
        }

        private object lockSignle = new object();
        private object lockBatch = new object();

        static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CRM_4SMySql"].ConnectionString;

        /// <summary>
        /// 验证用户是否存在 
        /// </summary>
        /// <param name="userName">用户名称</param>
        /// <param name="pwd">登录密码</param>
        /// <returns>返回验证结果信息(通常为SessionId，可扩展)</returns>
        public ResultValue UserValidator(string userName, string pwd)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 保存数据入数据库
        /// </summary>
        /// <param name="functionParms">方法的参数</param>
        /// <returns>保存数据入库</returns>
        public ResultValue FuncSaveData(FunctionParms functionParms)
        {
            lock (lockSignle)
            {
                try
                {
                    if (functionParms.FunctionName.StartsWith("ufc"))
                    {
                        var mothed = this.GetType().GetMethod(functionParms.FunctionName.Remove(0, 3));
                        if (mothed == null)
                            throw new NotImplementedException(functionParms.FunctionName);

                        mothed.Invoke(this, (functionParms.Pams.Values ?? new List<object>()).ToArray());
                    }
                    else
                    {
                        //SQLHelper.ExecuteNonQuery(connectionString, functionParms.FunctionName, functionParms.Pams);
                        MySqlHelper.ExecuteNonQuery(connectionString, functionParms.FunctionName, functionParms.Pams);
                    }

                    return new ResultValue();
                }
                catch (Exception e)
                {
                    return new ResultValue(e);
                }
            }
        }

        /// <summary>
        /// 批量保存数据入数据库
        /// </summary>
        /// <param name="functionParms">方法的参数</param>
        /// <returns>保存数据入库</returns>
        public ResultValue[] FuncBatchSaveData(FunctionParms[] funcParms)
        {
            lock (lockBatch)
            {
                List<ResultValue> results = new List<ResultValue>();

                foreach (FunctionParms funcParm in funcParms)
                {
                    ResultTable resultTable = new ResultTable();
                    try
                    {
                        using (var reader = SQLHelper.ExecuteReader(connectionString, funcParm.FunctionName, funcParm.Pams))
                        {
                            List<string> columns = new List<string>();
                            List<object[]> rows = new List<object[]>();
                            while (reader.Read())
                            {
                                if (columns.Count == 0)
                                {
                                    columns = new List<string>();
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        columns.Add(reader.GetName(i));
                                    }
                                }
                                List<object> cellValues = new List<object>();
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    object cellValue = reader.GetValue(i);
                                    cellValues.Add(cellValue == DBNull.Value ? null : cellValue);
                                }
                                rows.Add(cellValues.ToArray());
                            }
                            resultTable.Columns = columns.ToArray();
                            resultTable.Rows = rows.ToArray();
                        }
                        ResultValue resultValue = new ResultValue();
                        resultValue.ResultTable = resultTable;
                        results.Add(resultValue);

                        //SQLHelper.ExecuteNonQuery(connectionString, funcParm.FunctionName, funcParm.Pams);
                        //results.Add(new ResultValue());
                    }
                    catch (Exception e)
                    {
                        results.Add(new ResultValue(e));
                    }
                }

                return results.ToArray();
            }
        }

        /// <summary>
        /// 获取查询结果集合
        /// </summary>
        /// <param name="functionParms">查询条件</param>
        /// <returns>返回结果集合</returns>
        public ResultValue FuncGetResults(FunctionParms functionParms)
        {
            try
            {
                ResultTable resultTable = new ResultTable();
                //using (var reader = SQLHelper.ExecuteReader(connectionString, functionParms.FunctionName, functionParms.Pams))
                using (var reader = MySqlHelper.ExecuteDataReader(connectionString, functionParms.FunctionName, functionParms.Pams))
                {
                    List<string> columns = new List<string>();
                    List<object[]> rows = new List<object[]>();
                    while (reader.Read())
                    {
                        if (columns.Count == 0)
                        {
                            columns = new List<string>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                columns.Add(reader.GetName(i));
                            }
                        }
                        List<object> cellValues = new List<object>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            object cellValue = reader.GetValue(i);
                            cellValues.Add(cellValue == DBNull.Value ? null : cellValue);
                        }
                        rows.Add(cellValues.ToArray());
                    }
                    resultTable.Columns = columns.ToArray();
                    resultTable.Rows = rows.ToArray();
                }
                ResultValue resultValue = new ResultValue();
                resultValue.ResultTable = resultTable;
                return resultValue;
            }
            catch (Exception e)
            {
                return new ResultValue(e);
            }
        }

        /// <summary>
        /// 批量入库
        /// </summary>
        /// <param name="typeName">类型名称，对应AppSetting中的配置</param>
        /// <param name="resource">结果集</param>
        public void BulkInsert(string typeName, DataTable resource)
        {
            FuncSaveData(new FunctionParms()
            {
                FunctionName = string.Format("uspClear{0}Temp", typeName)//uspClearFrontTemp
            });

            string tempFileDir = AppDomain.CurrentDomain.BaseDirectory + "TempFolder\\";
            string strFile = tempFileDir + "Temp" + DateTime.Now.Ticks.ToString() + ".csv";//Create directory if not exist... Make sure directory has required rights..    
            if (!Directory.Exists(tempFileDir))
                Directory.CreateDirectory(tempFileDir);//If file does not exist then create it and right data into it..     
            if (!File.Exists(strFile))
            {
                FileStream fs = new FileStream(strFile, FileMode.Create, FileAccess.Write);
                fs.Close();
                fs.Dispose();
            }
            CreateCSVfile(resource, strFile);
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();// mysql.data.dll 5.6以上版本 目前用6.9.8
                MySqlBulkLoader bulkLoader = new MySqlBulkLoader(conn);
                bulkLoader.TableName = string.Format("import_{0}_temp", typeName);
                bulkLoader.FieldTerminator = ",";
                bulkLoader.LineTerminator = "\r\n";
                bulkLoader.FileName = strFile;
                bulkLoader.NumberOfLinesToSkip = 0;
                bulkLoader.Load();
                File.Delete(strFile);
            }


            //using (SqlBulkCopy bulkCopy = new SqlBulkCopy("Server=localhost;Database=crm_4s;Uid=root;Pwd=;"))
            //{
            //    bulkCopy.BatchSize = 5000;
            //    bulkCopy.DestinationTableName = "import_front_temp";
            //    bulkCopy.WriteToServer(resource);
            //}

            //FuncSaveData(new FunctionParms()
            //{
            //    FunctionName = ""
            //});

        }

        public static void CreateCSVfile(DataTable dtable, string strFilePath)
        {
            StreamWriter sw = new StreamWriter(strFilePath, false);
            int icolcount = dtable.Columns.Count;
            foreach (DataRow drow in dtable.Rows)
            {
                for (int i = 0; i < icolcount; i++)
                {
                    if (!Convert.IsDBNull(drow[i]))
                    {
                        sw.Write(drow[i].ToString());
                    }
                    if (i < icolcount - 1)
                    {
                        sw.Write(",");
                    }
                }
                sw.Write(sw.NewLine);
            }
            sw.Close();
            sw.Dispose();
        }
    }
}
