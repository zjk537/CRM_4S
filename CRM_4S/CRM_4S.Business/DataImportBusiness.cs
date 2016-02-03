using CRM_4S.DataService.Model;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace CRM_4S.Business
{
    public class DataImportBusiness : BusinessBase<DataImportBusiness>
    {
        /// <summary>
        /// exact excel data into DataTable
        /// </summary>
        /// <param name="excel">excel file name</param>
        /// <returns>DataTable</returns>
        public DataTable ToDataTable(string excel)
        {
            DataTable dt = new DataTable(Path.GetFileNameWithoutExtension(excel));
            IWorkbook workbook;
            using (FileStream file = new FileStream(excel, FileMode.Open, FileAccess.Read))
            {
                workbook = WorkbookFactory.Create(file);
            }
            ISheet sheet = workbook.GetSheetAt(0);

            IRow headerRow = sheet.GetRow(sheet.FirstRowNum);
            for (var i = 0; i < headerRow.LastCellNum; i++)
            {
                ICell cell = headerRow.GetCell(i);
                dt.Columns.Add(cell == null ? i.ToString() : cell.ToString());
            }

            for (var i = headerRow.RowNum + 1; i <= sheet.LastRowNum; i++)
            {
                IRow row = sheet.GetRow(i);
                if (row == null)
                    continue;

                DataRow dataRow = dt.NewRow();
                for (var j = row.FirstCellNum; j < row.LastCellNum; j++)
                {
                    ICell cell = row.GetCell(j);
                    if (cell == null)
                    {
                        dataRow[j] = null;
                    }
                    else
                    {
                        //读取Excel格式，根据格式读取数据类型
                        switch (cell.CellType)
                        {
                            case CellType.Blank: //空数据类型处理
                                dataRow[j] = "";
                                break;
                            case CellType.String: //字符串类型
                                dataRow[j] = cell.StringCellValue;
                                break;
                            case CellType.Numeric: //数字类型                                   
                                if (DateUtil.IsCellInternalDateFormatted(cell))
                                {
                                    dataRow[j] = cell.DateCellValue.ToString("yyyy-MM-dd hh:mm:ss");
                                }
                                else
                                {
                                    dataRow[j] = cell.NumericCellValue;
                                }
                                break;
                            case CellType.Formula://DateUtil
                                IFormulaEvaluator fe = WorkbookFactory.CreateFormulaEvaluator(workbook);
                                dataRow[j] = fe.Evaluate(cell).StringValue;
                                break;
                            default:
                                dataRow[j] = "";
                                break;
                        }
                    }
                }
                dt.Rows.Add(dataRow);
            }

            return dt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="typeName"></param>
        /// <param name="source"></param>
        public void BulkInsertData(string typeName, DataTable source)
        {
            // clear temp table
            DoUpdateFunctionWithLog<ResultValue>(() =>
            {
                var functionParms = new FunctionParms();
                functionParms.FunctionName = "ufcBulkInsert";
                functionParms.Pams = new Dictionary<string, object>();
                functionParms.Pams.Add("typeName", typeName);
                functionParms.Pams.Add("resource", source);

                return Service.ServiceManager.Instance.ServiceClient.FuncSaveData(functionParms);
            }, "BulkInsertData.ufcBulkInsert", true);


        }
    }
}
