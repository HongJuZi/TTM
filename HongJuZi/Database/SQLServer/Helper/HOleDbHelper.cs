using System;
using System.Collections.Generic;
using System.Text;
using HongJuZi.Core;
using System.Data.Common;
using HongJuZi.Log;

namespace HongJuZi.Database.SQLServer.Helper
{
    /// <summary>
    /// OLE连接方式助手工具类
    /// </summary>
    class HOleDbHelper: HObject, HISQLServerHelper
    {

        /// <summary>
        /// 连接字符串
        /// </summary>
        protected String _connString;
       
        /// <summary>
        /// 构造函数
        /// </summary>
        public HOleDbHelper(String connString): base() 
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
                DbConnection conn   = new System.Data.OleDb.OleDbConnection(this._connString);
                HLog.write("OLE 数据库连接对象创建成功！");
                return conn;
            } catch(Exception ex) {
                HLog.write("OLE 数据库连接失败！");
                HLog.write(ex.StackTrace);
                return null;
            }
        }

        /// <summary>
        /// 创建数据库执行对象
        /// </summary>
        /// <param name="sql">需要执行的SQL语句</param>
        /// <param name="conn">当前的数据库连接</param>
        /// <returns>数据库执行对象</returns>
        public DbCommand createCommand()
        {
            try {
                DbCommand command   =  new System.Data.OleDb.OleDbCommand();
                HLog.write("OLE 数据库执行对象创建成功！");
                return command;
            } catch(Exception ex) {
                HLog.write("OLE 数据库执行对象创建失败！");
                HLog.write(ex.StackTrace);
                return null;
            }
        }

        /// <summary>
        /// 创建数据库适配器
        /// </summary>
        /// <returns>数据库适配器对象</returns>
        public DbDataAdapter createDataAdapter()
        {
            return new System.Data.OleDb.OleDbDataAdapter();
        }

    }
}
