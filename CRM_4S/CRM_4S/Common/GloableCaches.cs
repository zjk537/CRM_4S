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
        /// <summary>
        /// 角色列表
        /// </summary>
        public List<RoleInfo> RoleInfos
        {
            get
            {
                if (roleInfos == null)
                {
                    roleInfos = new List<RoleInfo>();
                    roleInfos.AddRange(RoleBusiness.Instance.GetRoles());
                }

                return roleInfos;
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
