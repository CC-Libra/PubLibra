using System.Web;

namespace CCLibra.Util
{
    /// <summary>
    /// 版 本 CCLibra 框架
    /// Copyright (c) chuchao
    /// 创建人：褚超
    /// 日 期：2017.03.08
    /// 描 述：当前上下文执行用户信息获取
    /// </summary>
    public static class LoginUserInfo
    {
        /// <summary>
        /// 获取当前上下文执行用户信息
        /// </summary>
        /// <returns></returns>
        public static UserInfo Get()
        {
            return (UserInfo)HttpContext.Current.Items["LoginUserInfo"];
        }
    }
}
