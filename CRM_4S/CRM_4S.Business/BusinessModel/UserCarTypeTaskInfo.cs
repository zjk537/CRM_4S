using CRM_4S.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CRM_4S.Business.BusinessModel
{
    public class UserCarTypeTaskInfo
    {
        private UserTaskInfo userTask = new UserTaskInfo();
        public UserTaskInfo UserTask
        {
            get { return userTask; }
            set
            {
                userTask = value;

            }
        }

        private CarTypeInfo carType = null;
        public CarTypeInfo CarType
        {
            get
            {
                if (carType == null && userTask != null)
                {
                    carType = GlobalCaches.Instance.CarTypes.FirstOrDefault(obj => { return obj.Id == userTask.CarTypeId; });
                }
                return carType;
            }
            set
            {
                carType = value;
                if (userTask != null && carType != null)
                {
                    userTask.CarTypeId = carType.Id;
                }
            }
        }
    }
}
