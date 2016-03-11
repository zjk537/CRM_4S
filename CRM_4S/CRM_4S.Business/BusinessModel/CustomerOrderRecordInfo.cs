using CRM_4S.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Business.BusinessModel
{
    public class CustomerOrderRecordInfo
    {
        OrderRecordInfo orderRecord = null;

        public OrderRecordInfo OrderRecord
        {
            get { return orderRecord; }
            set { orderRecord = value; }
        }

        UserInfo consultantUser = null;
        public UserInfo ConsultantUser
        {
            get
            {
                if (consultantUser == null && orderRecord != null)
                {
                    consultantUser = GlobalCaches.Instance.ConsultantInfos.FirstOrDefault(e => e.Id == orderRecord.ConsultantId);
                }
                return consultantUser;
            }
            set
            {
                consultantUser = value;
                orderRecord.ConsultantId = consultantUser.Id;
            }
        }
        private CarTypeInfo carType = null;
        public CarTypeInfo CarType
        {
            get
            {
                if (carType == null && orderRecord != null)
                {
                    carType = GlobalCaches.Instance.CarTypes.FirstOrDefault(obj => { return obj.Id == orderRecord.CarType; });
                }
                return carType;
            }
            set
            {
                carType = value;
                if (orderRecord != null && carType != null)
                {
                    orderRecord.CarType = carType.Id;
                }
            }
        }

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
    }
}
