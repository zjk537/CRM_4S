using CRM_4S.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Business.BusinessModel
{
    public class DCCCustomerRecordInfo
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
                if (shop == null && dccRecord != null)
                {
                    shop = GloablCaches.Instance.ShopInfos.FirstOrDefault(e => e.Id == dccRecord.ShopId);
                }
                return shop;
            }
        }

        DCCRecordInfo dccRecord = null;
        public DCCRecordInfo DCCRecord
        {
            get { return dccRecord; }
            set { dccRecord = value; }
        }

        public int RecordCnt { get; set; }

        UserInfo dccUser = null;
        public UserInfo DCCUser
        {
            get
            {
                if (dccUser == null && dccRecord != null)
                {
                    dccUser = GloablCaches.Instance.ConsultantInfos.FirstOrDefault(e => e.Id == dccRecord.DCCRecallerId);
                }
                return dccUser;
            }
            set
            {
                dccUser = value;
                dccRecord.DCCRecallerId = dccUser.Id;
            }
        }

       
    }
}