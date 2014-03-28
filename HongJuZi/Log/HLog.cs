using System;
using System.Collections.Generic;
using System.Text;
using HongJuZi.Core;
using HongJuZi.Utils;
using HongJuZi.FileSystem;
using HongJuZi.Exceptions;
using System.IO;

namespace HongJuZi.Log
{
    /// <summary>
    /// 框架日志工具类
    /// </summary>
    public class HLog: HObject
    {
        /// <summary>
        /// 提示信息
        /// </summary>
        public static readonly String L_INFO     = "INFO";

        /// <summary>
        /// 注意信息
        /// </summary>
        public static readonly String L_NOTICE   = "NOTICE";
        
        /// <summary>
        /// 警告信息
        /// </summary>
        public static readonly String L_WARN     = "WARNNING";

        /// <summary>
        /// 错误级别
        /// </summary>
        public static readonly String L_ERROR    = "ERROR";

        /// <summary>
        /// 成功级别
        /// </summary>
        public static readonly String L_SUCCEED  = "SUCCEED";

        /// <summary>
        /// 日志打开标识，默认为开启
        /// </summary>
        public static Boolean Enable             = true;
        
        /// <summary>
        /// 日志写入目录
        /// </summary>
        public static String LOG_DIR             = ".";

        /// <summary>
        /// 日志输出目标
        /// </summary>
        public static String OUTPUT_TARGE        = "file";

        /// <summary>
        /// 日志文件最大大小单位MB。
        /// </summary>
        public static float MAX_SIZE             = 10.0f;

        /// <summary>
        /// 锁对象
        /// </summary>
        protected static Object obj               = new Object();

        /// <summary>
        /// 对外日志写入入口
        /// </summary>
        /// <param name="msg"></param>
        public static void write(String msg)
        {
            HLog.write(msg, L_INFO);
        }
        
        /// <summary>
        /// 带有日志级别的信息日志
        /// </summary>
        /// <param name="msg">日志信息</param>
        /// <param name="level">日志级别</param>
        public static void write(String msg, String level)
        {
            lock(obj) {
                if(true == HLog.Enable) {
                    try {
                        String logMsg   = HLog._formatLogMessage(msg, level);
                        switch(OUTPUT_TARGE.ToLowerInvariant()) {
                            case "file": HLog.writeFileLog(logMsg); break;
                            case "email":
                            case "console":
                            default: Console.Write(logMsg); break;
                        }
                    } catch (HIOException ex) {
                        Console.WriteLine(ex.Message);	
                    }
                }
            }
        }

        /// <summary>
        /// 写入文件日志
        /// </summary>
        /// <param name="msg">需要写入的日志信息</param>
        public static void writeFileLog(String msg)
        {
            HFile.append(msg, HLog._getLogFilePath(""));
            FileInfo fileInfo  = new FileInfo(HLog._getLogFilePath(""));
            if((1000 * 1000 * HLog.MAX_SIZE) < fileInfo.Length) {
                HFile.move(HLog._getLogFilePath(""), HLog._getLogFilePath(" " + HDateTime.getTimeStamp()));
            }
        }

        /// <summary>
        /// 格式化日志信息
        /// </summary>
        /// <param name="msg">信息</param>
        /// <param name="level">级别</param>
        /// <returns>格式化后的日志信息</returns>
        protected static String _formatLogMessage(String msg, String level)
        {
            return String.Format("[{0,8}]\t[{1}]\t{2}", level, HDateTime.getNow(), msg);
        }

        /// <summary>
        /// 得到日志写入的文件路径
        /// </summary>
        /// <returns></returns>
        protected static String _getLogFilePath(String time)
        {
            return HLog.LOG_DIR + "\\" + HDateTime.getDate() + time + ".log";
        }

    }
}
