using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Common
{
    public class LoggerHelper
    {
        private static ILog log = null;

        private LoggerHelper()
        {

        }

        public static ILog Logger
        {
            get
            {
                if (log == null)
                {
                    log = LogManager.GetLogger("CRM_4S");
                }
                return log;
            }
        }
    }
}
