using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data.Common;
using HongJuZi.Core;
using HongJuZi.Log;

namespace HongJuZi.Database.SQLServer.Helper
{
    /// <summary>
    /// SQL Natice连接帮助类
    /// </summary>
    class HSqlNativeDbHelper:HObject, HISQLServerHelper
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        protected String _connString;

        /// <summary>
        /// 构造函数
        /// </summary>
        public HSqlNativeDbHelper(String connString): base() 
        {
            this._connString    = connString;
        }

        /// <summary>
        /// 创建数据库连接
        /// </summary>
        /// <returns>数据库连接对象</returns>
        public DbConnection createConnection()
        {
            try {
                DbConnection conn   = new SqlConnection(this._connString);
                HLog.write("SQL NATIVE 数据库连接成功！");
                return conn;
            } catch(Exception ex) {
                HLog.write("SQL NATIVE 数据库连接失败！" + this._connString);
                HLog.write(ex.StackTrace);
                return null;
            }
        }

        /// <summary>
        /// 创建数据库执行对象
        /// </summary>
        /// <returns>数据库执行对象</returns>
        public DbCommand createCommand()
        {
            try {
                DbCommand command   = new SqlCommand();
                HLog.write("SQL NATIVE 数据库执行对象创建成功！");
                return command;
            } catch(Exception ex) {
                HLog.write("SQL NATIVE 数据库执行对象创建失败！");
                HLog.write(ex.StackTrace);
                return null;
            }
        }

        /// <summary>
        /// 创建数据库适配对象
        /// </summary>
        /// <returns>数据库适配对象</returns>
        public DbDataAdapter createDataAdapter()
        {
            return new SqlDataAdapter();
        }

    }
}
