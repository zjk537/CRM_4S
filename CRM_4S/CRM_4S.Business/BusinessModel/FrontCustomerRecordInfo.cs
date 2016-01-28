using CRM_4S.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Business.BusinessModel
{
    public class FrontCustomerRecordInfo
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

         ShopInfo shop = null;
         public ShopInfo Shop
         {
             get
             {
                 if (shop == null && frontRecord != null)
                 {
                     shop = GloablCaches.Instance.ShopInfos.FirstOrDefault(e => e.Id == frontRecord.ShopId);
                 }
                 return shop;
             }
         }

        FrontRecordInfo frontRecord = null;
        public FrontRecordInfo FrontRecord
        {
            get { return frontRecord; }
            set { frontRecord = value; }
        }

        public int RecordCnt { get; set; }

        UserInfo consultantUser = null;
        public UserInfo ConsultantUser
        {
            get
            {
                if (consultantUser == null && frontRecord != null)
                {
                    consultantUser = GloablCaches.Instance.ConsultantInfos.FirstOrDefault(e => e.Id == frontRecord.ConsultantId);
                }
                return consultantUser;
            }
            set
            {
                consultantUser = value;
                frontRecord.ConsultantId = consultantUser.Id;
            }
        }


    }
}
