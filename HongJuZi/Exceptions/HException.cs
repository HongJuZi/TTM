/// <summary>
/// FileName: HHException.cs
/// CLRVersion: 2.0.50727.3643
/// Author: xjiujiu <xjiujiu@foxmail.com>
/// Corporation: 怀化学院软件创新工作室
/// Description: CSharp 开发框架
/// DateTime: 2012-11-15 20:46:54
/// </summary>
using System;
using System.Text;

/// <summary>
/// NameSpace: HongJuZi.Exception
/// Author: xjiujiu <xjiujiu@foxmail.com>
/// Description: CSharp 开发框架
/// </summary>
namespace HongJuZi.Exceptions
{
    /// <summary>
    /// ClassName: HHException
    /// Author: xjiujiu <xjiujiu@foxmail.com>
    /// Description: None
    /// Version: 1.0
    /// </summary>
    public class HException: Exception
    {
        /// <summary>
        /// 内部异常消息
        /// </summary>
        protected String _innerMsg;

        /// <summary>
        /// 继承构造函数
        /// </summary>
        /// <param name="message">抛出的异常信息</param>
        public HException(String message):base(message)
        {
            //some code
        }

        /// <summary>
        /// 构造函数重载
        /// </summary>
        /// <param name="message">抛出的异常信息</param>
        /// <param name="ex">内套的异常信息对象</param>
        public HException(String message, Exception ex): base(message, ex)
        {
            //some code
        }
        
        /// <summary>
        /// 自定义异常信息
        /// </summary>
        /// <param name="message">对外的异常消息</param>
        /// <param name="innerMsg">系统内部使用的异常消息</param>
        public HException(String message, String innerMsg):base(message)
        {
            this._innerMsg    = innerMsg;
        }
        
        /// <summary>
        /// 内部异常消息设置器 
        /// </summary>
        public String InnerMsg 
        {
            get { return this._innerMsg; }
            set { this._innerMsg  = value; }
        }
    }
}
