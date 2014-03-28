using System;
using System.Collections.Generic;
using System.Text;
using HongJuZi.Core;

namespace HongJuZi.Database.SQLServer.Helper
{
    /// <summary>
    /// SQLServer 助手工厂类
    /// </summary>
    class HSQLServerHelperFactory:HObject
    {

        /// <summary>
        /// 得到SQLServer助手实例
        /// </summary>
        /// <param name="connString"></param>
        /// <returns></returns>
        public static HISQLServerHelper getInstance(String connString)
        {
            return _getOleDbHelper(connString);
        }

        /// <summary>
        /// 得到OLEDb的助手工具类
        /// </summary>
        /// <param name="connString"></param>
        /// <returns></returns>
        protected static HISQLServerHelper _getOleDbHelper(String connString)
        {
            if (0 <= connString.ToLowerInvariant().IndexOf("provider=sqloledb")) {
                return new HOleDbHelper(connString);
            }

            return _getSqlNativeHelper(connString);
        }

        /// <summary>
        /// 得到Sql Native连接方式的数据库助手类
        /// </summary>
        /// <param name="connString">数据库连接字符串</param>
        /// <returns>数据库助手对象</returns>
        protected static HISQLServerHelper _getSqlNativeHelper(String connString)
        {
            if (0 <= connString.ToLowerInvariant().IndexOf("provider=sqlncli")
                || 0 > connString.ToLowerInvariant().IndexOf("provider")) {
                return new HSqlNativeDbHelper(connString);
            }

            return _getOtherDbHelper(connString);
        }

        /// <summary>
        /// 得到其它情况的数据库连接对象
        /// </summary>
        /// <param name="connString">数据库连接对象</param>
        protected static HISQLServerHelper _getOtherDbHelper(String connString)
        {
            return null;
        }
    }
}
