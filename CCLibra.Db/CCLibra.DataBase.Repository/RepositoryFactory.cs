﻿
namespace CCLibra.DataBase.Repository
{
    /// <summary>
    /// 版 本 CCLibra 框架
    /// Copyright (c) chuchao
    /// 创建人：力软-框架开发组
    /// 日 期：2017.12.12
    /// 描 述：定义仓储模型工厂
    /// </summary>
    public class RepositoryFactory
    {
        /// <summary>
        /// 定义仓储
        /// </summary>
        /// <param name="connString">连接字符串</param>
        /// <param name="type">数据库类型</param>
        /// <returns></returns>
        public IRepository BaseRepository(string connString, DatabaseType type)
        {
            return new Repository(DbFactory.GetIDatabase(connString, type));
        }
        /// <summary>
        /// 定义仓储
        /// </summary>
        /// <param name="connString">连接字符串</param>
        /// <param name="type">数据库类型</param>
        /// <returns></returns>
        public IRepository BaseRepository(string connString, string type)
        {
            return new Repository(DbFactory.GetIDatabase(connString, type));
        }
        /// <summary>
        /// 定义仓储
        /// </summary>
        /// <param name="name">连接配置名称</param>
        /// <returns></returns>
        public IRepository BaseRepository(string name)
        {
            return new Repository(DbFactory.GetIDatabase(name));
        }
        /// <summary>
        /// 定义仓储（基础库）
        /// </summary>
        /// <returns></returns>
        public IRepository BaseRepository()
        {
            return new Repository(DbFactory.GetIDatabase());
        }

    }
}
