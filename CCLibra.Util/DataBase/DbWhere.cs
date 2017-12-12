using System.Collections.Generic;

namespace CCLibra.Util
{
    /// <summary>
    /// 版 本 CCLibra 框架
    /// Copyright (c) chuchao
    /// 创建人：褚超
    /// 日 期：2017.03.07
    /// 描 述：数据库查询拼接数据模型
    /// </summary>
    public class DbWhere
    {
        /// <summary>
        /// sql语句
        /// </summary>
        public string sql { get; set; }
        /// <summary>
        /// 查询参数
        /// </summary>
        public List<FieldValueParam> dbParameters { get; set; }
    }
}
