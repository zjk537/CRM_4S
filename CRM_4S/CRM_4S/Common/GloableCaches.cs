using CRM_4S.Business;
using CRM_4S.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_4S
{
    public class GloableCaches
    {
        private static GloableCaches instance = null;
        public static GloableCaches Instance
        {
            get
            {
                if (instance == null)
                    instance = new GloableCaches();
                return instance;
            }
        }
        private GloableCaches()
        {

        }

        List<CarTypeInfo> carTypes = null;
        public List<CarTypeInfo> CarTypes
        {
            get
            {
                if (carTypes == null)
                {
                    carTypes = new List<CarTypeInfo>();
                    carTypes.AddRange(CarTypeBusiness.Instance.GetCarTypes());
                }
                
                return carTypes;
            }
        }
    }
}
