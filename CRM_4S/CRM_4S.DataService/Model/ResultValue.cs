using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CRM_4S.DataService.Model
{
    [DataContract]
    [Serializable]
    public class ResultValue
    {

        [DataMember]
        public ResultTable ResultTable { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string StackTrace { get; set; }

        private bool faild = false;
        [DataMember]
        public bool Faild
        {
            get { return !string.IsNullOrEmpty(Message); }
            set { faild = value; }
        }

        public ResultValue()
        { }

        public ResultValue(Exception ex)
        {
            Message = ex.Message;
            StackTrace = ex.StackTrace;
        }
    }

    [DataContract]
    [Serializable]
    public class ResultTable
    {
        [DataMember]
        public string[] Columns { get; set; }

        [DataMember]
        public object[][] Rows { get; set; }
    }
}
