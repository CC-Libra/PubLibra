using CCLibra.Cache.Base;
using CCLibra.Cache.Redis;

namespace CCLibra.Cache.Factory
{
    /// <summary>
    /// 版 本 CCLibra 框架 
    /// Copyright (c) chuchao
    /// 创建人：力软-框架开发组
    /// 日 期：2017.03.06
    /// 描 述：定义缓存工厂类
    /// </summary>
    public class CacheFactory
    {
        public static ICache CaChe()
        {
            return new CacheByRedis();
        }
    }
}
