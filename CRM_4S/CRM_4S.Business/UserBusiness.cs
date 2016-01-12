using CRM_4S.Business.Model;
using CRM_4S.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRM_4S.Business
{
    public class UserBusiness : BusinessBase<UserBusiness>
    {

        public IList<UserShopRoleInfo> GetUserShopRoleInfos()
        {
            List<UserShopRoleInfo> infos = new List<UserShopRoleInfo>();
            for (int i = 1; i < 10; i++)
            {
                UserShopRoleInfo info = new UserShopRoleInfo()
                {
                    Shop = new ShopInfo
                    {
                        Id = i,
                        Name = "测试商店名" + i
                    },
                    Role = new RoleInfo
                    {
                        Id = i,
                        RoleName = "总经理" + i
                    },
                    User = new UserInfo
                    {
                        Id = i,
                        UserName = "测试用户名" + i,
                        Phone = "123123123",
                        CreatedDate = DateTime.Now
                    }
                };
                infos.Add(info);
            }
            return infos;
        }
    }
}
