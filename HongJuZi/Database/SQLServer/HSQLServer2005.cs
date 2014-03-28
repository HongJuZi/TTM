using System;
using System.Collections.Generic;
using System.Text;
using HongJuZi.Core;
using System.Data.SqlClient;
using System.Collections;
using HongJuZi.Log;
using System.Data;
using HongJuZi.Security;
using System.Data.Common;
using HongJuZi.Database.SQLServer.Helper;

namespace HongJuZi.Database.SQLServer
{
    /// <summary>
    /// SQLServer2005的操作工具类
    /// </summary>
    public class HSQLServer2005: HObject, HIDatabase
    {
        /// <summary>
        /// 数据库连接对象
        /// </summary>
        protected static Hashtable _instance   = new Hashtable();
     
        /// <summary>
        /// 锁帮助对象
        /// </summary>
        private static readonly object _lockHelper  = new object();
        
        /// <summary>
        /// 数据库连接对象
        /// </summary>
        protected DbConnection _conn;

        /// <summary>
        /// 数据库助手对象
        /// </summary>
        protected HISQLServerHelper _helper;
        
        /// <summary>
        /// 数据库初始化对象
        /// </summary>
        public HSQLServer2005(String dbCfg): base()
        {
            this._helper    = HSQLServerHelperFactory.getInstance(dbCfg);
            this._conn      = this._helper.createConnection();
        }
            
        /// <summary>
        /// 当前连接对象是否存在
        /// </summary>
        /// <param name="hashKey">数据库配置信息</param>
        /// <returns>是|否</returns>
        protected static Boolean _hasConnection(String hashKey)
        {
            return null == _instance ? false : _instance.ContainsKey(hashKey);
        }
        
        /// <summary>
        /// 得到数据库的操作操作对象
        /// </summary>
        /// <param name="dbCfg">数据库配置信息</param>
        /// <returns>SQLServer2005操作对象</returns>
        public static HIDatabase getInstance(String dbCfg)
        {
            String hashKey  = HMd5.encode(dbCfg);
            if(false == _hasConnection(hashKey)) {
                lock(_lockHelper) {
                    if(false == _hasConnection(hashKey)) {
                        _instance.Add(hashKey, new HSQLServer2005(dbCfg));
                    }
                }
            }

            return (HIDatabase)_instance[hashKey];
        }

        /// <summary>
        /// 查找数据
        /// </summary>
        /// <param name="sql">需要执行的SQL语句</param>
        /// <returns>数据结果集</returns>
        public DataSet find(String sql)
        {
            DbDataAdapter adapter       = this._helper.createDataAdapter();
            DbCommand command           = this._helper.createCommand();
            command.CommandText         = sql;
            command.Connection          = this._conn;
            adapter.SelectCommand       = command;
            this._openConnection();
            DataSet ds                  = new DataSet();
            try {
                adapter.Fill(ds, "data");
                HLog.write(sql, HLog.L_SUCCEED);
            } catch(Exception ex) {
                HLog.write(ex.StackTrace);
                HLog.write(sql, HLog.L_ERROR);
            } finally {
                this._conn.Close();
            }

            return ds;
        }
       
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="sql">需要执行的SQL语句</param>
        /// <returns>数据影响的行数</returns>
        public int update(String sql)
        {
            DbCommand command       = this._helper.createCommand();
            command.CommandText     = sql;
            command.Connection      = this._conn;
            this._openConnection();
            int rows                = -1;
            try {
                rows                = command.ExecuteNonQuery();
                HLog.write(sql, HLog.L_SUCCEED);
            } catch(Exception ex) {
                HLog.write(ex.StackTrace);
                HLog.write(sql, HLog.L_ERROR);
            } finally {
                this._conn.Close();
            }

            return rows;
        } 
        
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="sql">需要执行的SQL语句</param>
        /// <returns>当前插入记录的ID</returns>
        public int add(String sql)
        {
            DbCommand command       = this._helper.createCommand();
            command.CommandText     = sql;
            command.Connection      = this._conn;
            this._openConnection();
            int id                  = 0;
            try {
                id                  = Int32.Parse(command.ExecuteScalar().ToString());
                HLog.write(sql, HLog.L_SUCCEED);
            } catch(SqlException ex) {
                HLog.write(ex.StackTrace);
                HLog.write(sql, HLog.L_ERROR);
            } finally {
                this._conn.Close();
            }

            return id;
        }
        
        /// <summary>
        /// 打开数据库连接
        /// </summary>
        protected void _openConnection()
        {
            if(ConnectionState.Open != this._conn.State) {
               try {
                   this._conn.Open(); 
                    HLog.write("数据库连接打开成功！", HLog.L_SUCCEED);
               } catch(Exception ex) {
                    HLog.write("数据库连接打开失败！" + ex.StackTrace, HLog.L_ERROR);
               }
            }
        }

    }
}
