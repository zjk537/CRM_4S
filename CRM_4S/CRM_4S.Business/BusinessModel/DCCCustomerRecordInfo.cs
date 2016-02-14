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
            get
            {
                if (customer == null)
                    customer = new CustomerInfo();
                return customer;
            }
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
                    shop = GlobalCaches.Instance.ShopInfos.FirstOrDefault(e => e.Id == dccRecord.ShopId);
                }
                return shop;
            }
        }

        DCCRecordInfo dccRecord = null;
        public DCCRecordInfo DCCRecord
        {
            get
            {
                if (dccRecord == null)
                    dccRecord = new DCCRecordInfo();
                return dccRecord;
            }
            set { dccRecord = value; }
        }


        UserInfo dccUser = null;
        public UserInfo DCCUser
        {
            get
            {
                if (dccUser == null && dccRecord != null)
                {
                    dccUser = GlobalCaches.Instance.ConsultantInfos.FirstOrDefault(e => e.Id == dccRecord.DCCRecallerId);
                }
                return dccUser;
            }
            set
            {
                dccUser = value;
                dccRecord.DCCRecallerId = dccUser.Id;
            }
        }
    
        public String Sex
        {
            get
            {
                if(this.Customer.Sex.HasValue)
                    return GlobalConstants.SexList[this.Customer.Sex.Value - 1];
                return "";
            }
        }

        public String DCCSource
        {
            get
            {
                if(this.DCCRecord.Source.HasValue)
                    return GlobalCaches.Instance.ConstantInfos.FirstOrDefault(info => info.Id == this.DCCRecord.Source.Value).Name;
                return "";
            }
        }

        public String PurposeCar
        {
            get
            {
                if(this.DCCRecord.PurposeCar.HasValue)
                    return GlobalCaches.Instance.CarTypes.FirstOrDefault(t => t.Id == this.DCCRecord.PurposeCar).ToString();
                return "";
            }
        }

        public String DCCStatus
        {
            get
            {
                if(this.DCCRecord.Status.HasValue)
                    return GlobalConstants.DCCStatus[this.DCCRecord.Status.Value - 1];
                return "";
            }
        }

        public String RegionAddress
        {
            get
            {
                RegionInfo region = GlobalCaches.Instance.RegionInfos.FirstOrDefault(info => info.Id == this.Customer.RegionId);
                return string.Format("{0} {1}", region, this.Customer.Address);
            }
        }

        public String Installment
        {
            get
            {
                if (this.DCCRecord.Installment.HasValue)
                    return GlobalConstants.BooleanDesc[this.DCCRecord.Installment.Value - 1];
                return "";
            }
        }

    }
}
