using CRM_4S.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Business
{
    public class CarTypeBusiness : BusinessBase<CarTypeBusiness>
    {

        public IList<CarTypeInfo> GetCarTypes()
        {
            List<CarTypeInfo> carTypes = new List<CarTypeInfo>();
            for (int i = 0; i < 10; i++)
            {
                CarTypeInfo carType = new CarTypeInfo
                {
                     Id = i,
                      Name = "CRV_" + i
                };
                carTypes.Add(carType);
            }

            return carTypes;
        }
    }
}
