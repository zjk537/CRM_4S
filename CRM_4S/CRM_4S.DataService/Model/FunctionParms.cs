using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CRM_4S.DataService.Model
{
    [DataContract]
    [Serializable]
    public class FunctionParms
    {
        [DataMember]
        public string FunctionName { get; set; }

        [DataMember]
        public IDictionary<string, object> Pams { get; set; }
    }
}
