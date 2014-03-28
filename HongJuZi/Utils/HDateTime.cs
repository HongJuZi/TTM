using System;
using System.Collections.Generic;
using System.Text;
using HongJuZi.Core;

namespace HongJuZi.Utils
{
    /// <summary>
    /// 日期时间工具类
    /// </summary>
    class HDateTime: HObject
    {

        /// <summary>
        /// 得到当前时间
        /// </summary>
        /// <returns>当前的时间字符串</returns>
        public static String getNow()
        {
            return DateTime.Now.ToString();
        }
    
        /// <summary>
        /// 得到当前日期，默认格式：Y-M-D
        /// </summary>
        /// <returns>当前的日期时间</returns>
        public static String getDate()
        {
            return DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
        }

        /// <summary>
        /// 得到当前时间，默认格式：H:M:S
        /// </summary>
        /// <returns>当前的时间</returns>
        public static String getTime()
        {
            return getTime(":");
        }

        /// <summary>
        /// 得到当前时间，默认格式：H:M:S
        /// </summary>
        /// <param name="ch">当前连接的字符串</param>
        /// <returns>当前的时间</returns>
        public static String getTime(String ch)
        {
            return DateTime.Now.Hour.ToString() + ch + DateTime.Now.Minute + ch + DateTime.Now.Second;
        }

        /// <summary>
        /// 得到时间截
        /// </summary>
        /// <returns>时间截</returns>
        public static String getTimeStamp()
        {
            return DateTime.Now.ToFileTimeUtc().ToString();
        }

    }
}
