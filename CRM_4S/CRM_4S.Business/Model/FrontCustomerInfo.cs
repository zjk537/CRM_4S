using CRM_4S.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Business.Model
{
    public class FrontCustomerInfo
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

        VisitRecordInfo visitRecord = null;
        public VisitRecordInfo VisitRecord
        {
            get { return visitRecord; }
            set { visitRecord = value; }
        }

        UserInfo consultantUser = null;
        public UserInfo ConsultantUser
        {
            get { return consultantUser; }
            set { consultantUser = value; }
        }

        
    }
}
