using CRM_4S.Business;
using CRM_4S.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_4S.Business
{
    public class GloableCaches
    {
        /// <summary>
        /// 数据仓储超时时间
        /// </summary>
        const int mSourceCacheTimeOutMin = 5;
        /// <summary>
        /// 数据仓储最后一次刷新时间列表
        /// </summary>
        Dictionary<string, DateTime> CacheLastUpdatedTimes = new Dictionary<string, DateTime>();

        static object lockObj = new object();

        #region Single Instance

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

        #endregion

        UserInfo curUser = null;
        public UserInfo CurUser
        {
            get
            {
                lock (lockObj)
                {
                    curUser = curUser ?? new UserInfo() { ShopId = 6, Id = 2 };
                }
                return curUser;
            }
            set { curUser = value; }
        }


        List<CarTypeInfo> carTypes = null;
        const String cacheKeyCarType = "CarTypes";
        public List<CarTypeInfo> CarTypes
        {
            get
            {
                lock (lockObj)
                {
                    if (NeedRefrenceCache(cacheKeyCarType))
                    {
                        if (carTypes != null) carTypes.Clear();
                        else carTypes = new List<CarTypeInfo>();

                        carTypes.AddRange(CarTypeBusiness.Instance.GetCarTypes());
                        if (carTypes.Count == 0)
                        {
                            this.CacheLastUpdatedTimes.Remove(cacheKeyCarType);
                        }
                    }
                }


                return carTypes;
            }
        }

        List<ShopInfo> shopInfos = null;
        const String cacheKeyShop = "ShopInfos";
        /// <summary>
        /// 店铺列表
        /// </summary>
        public List<ShopInfo> ShopInfos
        {
            get
            {
                lock (lockObj)
                {
                    if (NeedRefrenceCache(cacheKeyShop))
                    {
                        if (shopInfos != null) shopInfos.Clear();
                        else shopInfos = new List<ShopInfo>();

                        shopInfos.AddRange(ShopBusiness.Instance.GetShops());

                        if (shopInfos.Count == 0)
                        {
                            this.CacheLastUpdatedTimes.Remove(cacheKeyShop);
                        }
                    }

                    return shopInfos;
                }
            }
        }



        List<RoleInfo> roleInfos = null;
        const String cacheKeyRole = "RoleInfos";
        /// <summary>
        /// 角色列表
        /// </summary>
        public List<RoleInfo> RoleInfos
        {
            get
            {
                lock (lockObj)
                {
                    if (NeedRefrenceCache(cacheKeyRole))
                    {
                        if (roleInfos != null) roleInfos.Clear();
                        else roleInfos = new List<RoleInfo>();

                        roleInfos.AddRange(RoleBusiness.Instance.GetRoles());
                        if (roleInfos.Count == 0)
                        {
                            this.CacheLastUpdatedTimes.Remove(cacheKeyRole);
                        }
                    }
                }


                return roleInfos;
            }
        }


        List<UserInfo> consultantInfos = null;
        const String cacheKeyConsultant = "ConsultantInfos";
        /// <summary>
        /// 销售顾问列表
        /// </summary>
        public List<UserInfo> ConsultantInfos
        {
            get
            {
                lock (lockObj)
                {
                    if (NeedRefrenceCache(cacheKeyConsultant))
                    {
                        if (consultantInfos != null) consultantInfos.Clear();
                        else consultantInfos = new List<UserInfo>();

                        consultantInfos.AddRange(UserBusiness.Instance.GetUsers(new UserInfo()
                        {
                            ShopId = GloableCaches.Instance.CurUser.ShopId,
                            RoleId = GloableConstants.RoleIdConsultant
                        }));
                        if (roleInfos.Count == 0)
                        {
                            this.CacheLastUpdatedTimes.Remove(cacheKeyConsultant);
                        }
                    }
                }


                return consultantInfos;
            }
        }





        #region Private Method

        /// <summary>
        /// 是否需要刷新缓存
        /// </summary>
        /// <param name="cacheKey">缓存ID</param>
        /// <returns>true | false</returns>
        private bool NeedRefrenceCache(string cacheKey)
        {
            if (!CacheLastUpdatedTimes.ContainsKey(cacheKey)
                || (DateTime.Now - CacheLastUpdatedTimes[cacheKey]).Minutes >= mSourceCacheTimeOutMin)
            {
                CacheLastUpdatedTimes[cacheKey] = DateTime.Now;
                return true;
            }

            return false;
        }

        #endregion
    }
}
