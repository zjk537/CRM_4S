using CRM_4S.Business;
using CRM_4S.Model.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_4S.Business
{
    public class GlobalCaches
    {
        /// <summary>
        /// 数据仓储超时时间 分钟
        /// </summary>
        const int mSourceCacheTimeOutMin = 5;
        /// <summary>
        /// 数据仓储最后一次刷新时间列表
        /// </summary>
        Dictionary<string, DateTime> CacheLastUpdatedTimes = new Dictionary<string, DateTime>();

        static object lockObj = new object();

        #region Single Instance

        private static GlobalCaches instance = null;
        public static GlobalCaches Instance
        {
            get
            {
                if (instance == null)
                    instance = new GlobalCaches();
                return instance;
            }
        }
        private GlobalCaches()
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
                    curUser = curUser ?? new UserInfo();
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
                }
                return shopInfos;
            }
        }



        List<RoleInfo> roleInfos = null;
        //const String cacheKeyRole = "RoleInfos";
        /// <summary>
        /// 角色列表
        /// </summary>
        public List<RoleInfo> RoleInfos
        {
            get
            {
                //lock (lockObj)
                //{
                //    if (NeedRefrenceCache(cacheKeyRole))
                //    {
                //        if (roleInfos != null) roleInfos.Clear();
                //        else roleInfos = new List<RoleInfo>();

                //        roleInfos.AddRange(RoleBusiness.Instance.GetRoles());
                //        if (roleInfos.Count == 0)
                //        {
                //            this.CacheLastUpdatedTimes.Remove(cacheKeyRole);
                //        }
                //    }
                //}
                if (roleInfos == null || roleInfos.Count == 0)
                {
                    roleInfos = RoleBusiness.Instance.GetRoles().ToList();
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

                        consultantInfos.AddRange(UserBusiness.Instance.GetConsultants(new UserInfo()
                        {
                            ShopId = GlobalCaches.Instance.CurUser.ShopId
                        }));
                        if (consultantInfos.Count == 0)
                        {
                            this.CacheLastUpdatedTimes.Remove(cacheKeyConsultant);
                        }
                    }
                }


                return consultantInfos;
            }
        }


        List<BasicConstantInfo> constantInfos = null;
        /// <summary>
        /// 系统基础常量
        /// </summary>
        public List<BasicConstantInfo> ConstantInfos
        {
            get
            {
                if (constantInfos == null || constantInfos.Count == 0)
                {
                    constantInfos = BasicsConstantBusiness.Instance.GetBasicConstants(this.CurUser.ShopId).ToList();
                }
                return constantInfos;
            }
        }

        List<RegionInfo> regionInfos = null;
        /// <summary>
        /// 系统基础常量
        /// </summary>
        public List<RegionInfo> RegionInfos
        {
            get
            {
                if (regionInfos == null)
                {
                    regionInfos = BasicsConstantBusiness.Instance.GetRegions(this.CurUser.ShopId).ToList();
                }
                return regionInfos;
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
