using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;

namespace HongJuZi.Database.SQLServer.Helper
{
    /// <summary>
    /// SQLServer 帮助接口
    /// </summary>
    public interface HISQLServerHelper
    {
        /// <summary>
        /// 创建数据链接
        /// </summary>
        /// <returns>数据库连接对象</returns>
        DbConnection createConnection();

        /// <summary>
        /// 创建数据执行对象
        /// </summary>
        /// <returns>执行对象</returns>
        DbCommand createCommand();

        /// <summary>
        /// 创建数据适配器
        /// </summary>
        /// <returns>数据适配对象</returns>
        DbDataAdapter createDataAdapter();
    }
}
