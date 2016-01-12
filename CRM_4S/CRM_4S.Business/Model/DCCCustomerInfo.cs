using CRM_4S.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Business.Model
{
    public class DCCCustomerInfo
    {
        CustomerInfo customer = null;

        public CustomerInfo Customer
        {
            get { return customer; }
            set
            {
                customer = value;
            }
        }

        DCCRecordInfo dccRecord = null;
        public DCCRecordInfo DCCRecord
        {
            get { return dccRecord; }
            set { dccRecord = value; }
        }

        UserInfo consultantUser = null;
        public UserInfo ConsultantUser
        {
            get { return consultantUser; }
            set { consultantUser = value; }
        }

       
    }
}
