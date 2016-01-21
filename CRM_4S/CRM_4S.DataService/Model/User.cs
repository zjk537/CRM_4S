using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.DataService.Model
{
    public class User : IDisposable
    {
        public string SessionID { get; set; }

        public DateTime LastRequestTime { get; set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
