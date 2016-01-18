using CRM_4S.Business.TestService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Business
{
    public class PHPWebServiceTest
    {
        public String TestSay()
        {
            test_personPortClient client = new test_personPortClient();
            return client.say();
        }
    }
}
