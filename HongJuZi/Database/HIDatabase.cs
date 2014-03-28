using System;
using System.Collections;

namespace HongJuZi.Database
{
    /// <summary>
    /// 数据库操作接口
    /// </summary>
    public interface HIDatabase
    {
        /// <summary>
        /// 查找数据
        /// </summary>
        /// <param name="sql">需要执行的SQL语句</param>
        /// <returns>查找到的数据集合</returns>
        System.Data.DataSet find(String sql);
        
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="sql">需要执行的SQL语句</param>
        /// <returns>影响的数据条数</returns>
        int update(String sql);
        
        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="sql">执行的SQL语句</param>
        /// <returns>当前记录的ID</returns>
        int add(String sql);
    }
}
