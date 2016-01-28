using CRM_4S.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_4S.Business.BusinessModel
{
    public class UserShopRoleInfo
    {
        private UserInfo user = new UserInfo();
        public UserInfo User
        {
            get { return user; }
            set
            {
                user = value;
                Shop = null;
                Role = null;
                UserGroup = null;
            }
        }

        private ShopInfo shop = null;
        public ShopInfo Shop
        {
            get
            {
                if (shop == null && user != null)
                {
                    shop = GloablCaches.Instance.ShopInfos.FirstOrDefault(obj => { return obj.Id == user.ShopId; });
                }
                return shop;
            }
            set
            {
                shop = value;
                if (user != null && shop != null)
                {
                    user.ShopId = shop.Id;
                }
            }
        }

        private RoleInfo role = null;

        public RoleInfo Role
        {
            get
            {
                if (role == null && user != null)
                {
                    role = GloablCaches.Instance.RoleInfos.FirstOrDefault(obj => { return obj.Id == user.RoleId; });
                }
                return role;
            }
            set
            {
                role = value;
                if (user != null && role != null)
                {
                    user.RoleId = role.Id;
                }
            }
        }

        private UserGroupInfo userGroup = null;
        public UserGroupInfo UserGroup
        {
            get {
                if (userGroup == null && user != null)
                {
                    userGroup = new UserGroupInfo();
                }
                return userGroup; 
            }
            set
            {
                userGroup = value;
                if (user != null && userGroup != null)
                {
                    user.GroupId = userGroup.Id;
                }
            }
        }

    }
}
