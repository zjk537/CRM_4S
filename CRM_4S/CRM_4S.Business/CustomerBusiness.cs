using CRM_4S.Business.Model;
using CRM_4S.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Business
{
    public class CustomerBusiness : BusinessBase<CustomerBusiness>
    {

        public IList<FrontCustomerInfo> GetFrontCustomerRecords()
        {
            List<FrontCustomerInfo> frontRecords = new List<FrontCustomerInfo>();
            for (int i = 0; i < 10; i++)
            {
                FrontCustomerInfo info = new FrontCustomerInfo
                {
                    ConsultantUser = new UserInfo { Id = i, RealName = "销售顾问" + i },
                    Customer = new CustomerInfo
                    {
                        Id = i,
                        Name = "顾客" + i,
                        Address = "北京 北京",
                        Industry = "汽车销售",
                        Level = "C",
                        Nature = 2,
                        Phone = "123456" + i,

                    },
                    VisitRecord = new VisitRecordInfo
                    {
                        Id = i,
                        CarLicence = 1,
                        ConsultantId = 1,
                        ArrivalTime = DateTime.Now,
                        LeaveTime = DateTime.Now.AddMinutes(10),
                        CustomerId = 1,
                        CustomerNum = 3,
                        DriveStatus = 1,
                        DurationTime = "10:00",
                        PurposeCar = 2,
                        Remark = "测试数据_" + i,
                    }
                };

                frontRecords.Add(info);
            }
            return frontRecords;
        }
    }
}
