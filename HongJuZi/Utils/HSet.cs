/// <summary>
/// FileName: HHSet.cs 集合工具类
/// CLRVersion: 2.0.50727.3643
/// Author: xjiujiu <xjiujiu@foxmail.com>
/// Corporation: 怀化学院软件创新工作室
/// Description: CSharp 开发框架
/// DateTime: 2012-11-16 21:44:06
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// NameSpace: HongJuZi.Utils
/// Author: xjiujiu <xjiujiu@foxmail.com>
/// Description: CSharp 开发框架
/// </summary>
namespace HongJuZi.Utils
{
    /// <summary>
    /// ClassName: HHSet
    /// Author: xjiujiu <xjiujiu@foxmail.com>
    /// Description: None
    /// Version: 1.0
    /// </summary>
    public class HSet
    {
        /// <summary>
        /// 转换Hash表为请求的查询字串
        /// </summary>
        /// <param name="hTable">需要处理的Hash表</param>
        /// <returns></returns>
        public static String trunHashToQueryString(System.Collections.Hashtable hTable)
        {
            StringBuilder strBuilder    = new StringBuilder();
            foreach(System.Collections.DictionaryEntry item in hTable) {
                strBuilder.Append(item.Key.ToString() + "=" + item.Value);
            }

            return strBuilder.Length > 0 ? "?" + strBuilder.ToString() : "";
        }
    }
}
