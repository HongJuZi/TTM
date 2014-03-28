/// <summary>
/// FileName: HHUtilsException.cs 工具类异常处理
/// CLRVersion: 2.0.50727.3643
/// Author: xjiujiu <xjiujiu@foxmail.com>
/// Corporation: 怀化学院软件创新工作室
/// Description: CSharp 开发框架
/// DateTime: 2012-11-22 21:49:21
/// </summary>
using System;
using System.Text;

/// <summary>
/// NameSpace: HongJuZi.Exceptions
/// Author: xjiujiu <xjiujiu@foxmail.com>
/// Description: CSharp 开发框架
/// </summary>
namespace HongJuZi.Exceptions
{
    /// <summary>
    /// ClassName: HHUtilsException
    /// Author: xjiujiu <xjiujiu@foxmail.com>
    /// Description: None
    /// Version: 1.0
    /// </summary>
    public class HUtilsException: HException
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="message">需要抛出的异常信息</param>
        public HUtilsException(String message): base(message)
        {

        }

        /// <summary>
        /// 对有内部信息异常信息的重载
        /// </summary>
        /// <param name="message">当前的异常信息</param>
        /// <param name="innerMsg">内部使用异常信息</param>
        public HUtilsException(String message, String innerMsg): base(message)
        {
            this._innerMsg  = innerMsg;
        }
    }
}
