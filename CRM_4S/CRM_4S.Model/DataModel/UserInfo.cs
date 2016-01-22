/* ==============================================================================
 * 功能描述：
 * 创 建 者：zjk
 * 创建日期：2016-01-21 14:03
 * 修改日期：
 * 修改详情：
 * ==============================================================================*/
using System;

namespace CRM_4S.Model.DataModel
{
    public class UserInfo : DBModelBase
    {

        private int id = 0;
        public bool IdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 用户Id 
        /// </summary>
        [DBFieldAttribute("UserId")]
        public int Id { get { return id; } set { id = value; IdSpecify = true; } }


        private int shopId = 0;
        public bool ShopIdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 店面Id 
        /// </summary>
        [DBFieldAttribute("UserShopId")]
        public int ShopId { get { return shopId; } set { shopId = value; ShopIdSpecify = true; } }


        private int roleId = 0;
        public bool RoleIdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 用户角色Id 
        /// </summary>
        [DBFieldAttribute("UserRoleId")]
        public int RoleId { get { return roleId; } set { roleId = value; RoleIdSpecify = true; } }


        private int groupId = 0;
        public bool GroupIdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 销顾用户分组 
        /// </summary>
        [DBFieldAttribute("UserGroupId")]
        public int GroupId { get { return groupId; } set { groupId = value; GroupIdSpecify = true; } }


        private string userName = string.Empty;
        public bool UserNameSpecify { get; set; }
        /// <summary>
        /// 获取或设置 登录用户名 
        /// </summary>
        [DBFieldAttribute("UserUserName")]
        public string UserName { get { return userName; } set { userName = value; UserNameSpecify = true; } }


        private string pwd = string.Empty;
        public bool PwdSpecify { get; set; }
        /// <summary>
        /// 获取或设置 用户密码 
        /// </summary>
        [DBFieldAttribute("UserPwd")]
        public string Pwd { get { return pwd; } set { pwd = value; PwdSpecify = true; } }


        private string realName = string.Empty;
        public bool RealNameSpecify { get; set; }
        /// <summary>
        /// 获取或设置 用户真实姓名 
        /// </summary>
        [DBFieldAttribute("UserRealName")]
        public string RealName { get { return realName; } set { realName = value; RealNameSpecify = true; } }


        private int? sex = null;
        public bool SexSpecify { get; set; }
        /// <summary>
        /// 获取或设置 用户性别  1:男   2:女 
        /// </summary>
        [DBFieldAttribute("UserSex")]
        public int? Sex { get { return sex; } set { sex = value; SexSpecify = true; } }


        private int? status = null;
        public bool StatusSpecify { get; set; }
        /// <summary>
        /// 获取或设置 用户状态：1：正常；2：离职；3：删除 
        /// </summary>
        [DBFieldAttribute("UserStatus")]
        public int? Status { get { return status; } set { status = value; StatusSpecify = true; } }


        private string phone = string.Empty;
        public bool PhoneSpecify { get; set; }
        /// <summary>
        /// 获取或设置 用户手机号码 
        /// </summary>
        [DBFieldAttribute("UserPhone")]
        public string Phone { get { return phone; } set { phone = value; PhoneSpecify = true; } }


        private string telephone = string.Empty;
        public bool TelephoneSpecify { get; set; }
        /// <summary>
        /// 获取或设置 用户座机号码 
        /// </summary>
        [DBFieldAttribute("UserTelephone")]
        public string Telephone { get { return telephone; } set { telephone = value; TelephoneSpecify = true; } }


        private DateTime? updateDate = null;
        public bool UpdateDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置  
        /// </summary>
        [DBFieldAttribute("UserUpdateDate")]
        public DateTime? UpdateDate { get { return updateDate; } set { updateDate = value; UpdateDateSpecify = true; } }


        private DateTime? createdDate = null;
        public bool CreatedDateSpecify { get; set; }
        /// <summary>
        /// 获取或设置 创建时间 
        /// </summary>
        [DBFieldAttribute("UserCreatedDate")]
        public DateTime? CreatedDate { get { return createdDate; } set { createdDate = value; CreatedDateSpecify = true; } }


        public override string ToString()
        {
            return this.realName;
        }

    }
}