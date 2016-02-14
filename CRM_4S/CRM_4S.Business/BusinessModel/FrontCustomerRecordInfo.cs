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
                    shop = GlobalCaches.Instance.ShopInfos.FirstOrDefault(e => e.Id == frontRecord.ShopId);
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

        UserInfo consultantUser = null;
        public UserInfo ConsultantUser
        {
            get
            {
                if (consultantUser == null && frontRecord != null)
                {
                    consultantUser = GlobalCaches.Instance.ConsultantInfos.FirstOrDefault(e => e.Id == frontRecord.ConsultantId);
                }
                return consultantUser;
            }
            set
            {
                consultantUser = value;
                frontRecord.ConsultantId = consultantUser.Id;
            }
        }

        public String CNatureName
        {
            get
            {
                if (this.Customer.Nature.HasValue)
                {
                    return GlobalCaches.Instance.ConstantInfos.FirstOrDefault(info => info.Id == (int)this.Customer.Nature.Value).Name;
                }
                return "";
            }
        }

        public String CarLicence
        {
            get
            {
                if (this.FrontRecord.CarLicence.HasValue)
                {
                    return GlobalCaches.Instance.ConstantInfos.FirstOrDefault(info => info.Id == (int)this.FrontRecord.CarLicence.Value).Name;
                }
                return "";
            }
        }

        public String PurposeCarName
        {
            get
            {
                if (this.FrontRecord.PurposeCar.HasValue)
                {
                    return GlobalCaches.Instance.CarTypes.FirstOrDefault(info => info.Id == (int)FrontRecord.PurposeCar.Value).ToString();
                }
                return "";
            }
        }

        public String DriveStatus
        {
            get
            {
                if (this.FrontRecord.DriveStatus.HasValue)
                    return GlobalConstants.BooleanDesc[this.FrontRecord.DriveStatus.Value - 1];
                return "";
            }
        }
        
        public String Installment
        {
            get
            {
                if (this.FrontRecord.Installment.HasValue)
                    return GlobalConstants.BooleanDesc[this.FrontRecord.Installment.Value - 1];
                return "";
            }
        }

        public String Replace
        {
            get
            {
                if (this.FrontRecord.Replace.HasValue)
                    return GlobalConstants.BooleanDesc[this.FrontRecord.Replace.Value - 1];
                return "";
            }
        }

        public string RegionAddress
        {
            get
            {
                RegionInfo region = GlobalCaches.Instance.RegionInfos.FirstOrDefault(info => info.Id == this.Customer.RegionId);
                return string.Format("{0} {1}", region, this.Customer.Address);
            }
        }
    
        public String CSource
        {
            get
            {
                if(this.FrontRecord.Source.HasValue)
                    return GlobalCaches.Instance.ConstantInfos.FirstOrDefault(info => info.Id == this.FrontRecord.Source.Value).Name;
                return "";
            }
        }
        
    }
}
