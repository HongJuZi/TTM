/// <summary>
/// FileName: HHRequestException.cs
/// CLRVersion: 2.0.50727.3643
/// Author: xjiujiu <xjiujiu@foxmail.com>
/// Corporation: 怀化学院软件创新工作室
/// Description: CSharp 开发框架
/// DateTime: 2012-11-18 21:45:21
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// NameSpace: HongJuZi.Exceptions
/// Author: xjiujiu <xjiujiu@foxmail.com>
/// Description: CSharp 开发框架
/// </summary>
namespace HongJuZi.Exceptions
{
    /// <summary>
    /// ClassName: HHRequestException
    /// Author: xjiujiu <xjiujiu@foxmail.com>
    /// Description: None
    /// Version: 1.0
    /// </summary>
    public class HRequestException: HException
    {
        /// <summary>
        /// 构造函数 
        /// </summary>
        /// <param name="message">当前的异常信息</param>
        public HRequestException(String message): base(message)
        {

        }
        
        /// <summary>
        /// 有内部异常消息的异常构造函数
        /// </summary>
        /// <param name="message">客户端异常</param>
        /// <param name="innerMsg">内部异常</param>
        public HRequestException(String message, String innerMsg): base(message)
        {
            this._innerMsg  = innerMsg;
        }
    }
}
