/// <summary>
/// FileName: HHVerifyException.cs
/// CLRVersion: 2.0.50727.3643
/// Author: xjiujiu <xjiujiu@foxmail.com>
/// Corporation: 怀化学院软件创新工作室
/// Description: CSharp 开发框架
/// DateTime: 2012-11-15 20:59:00
/// </summary>
using System;
using System.Text;
using System.Windows.Forms;

/// <summary>
/// NameSpace: HongJuZi.Exception
/// Author: xjiujiu <xjiujiu@foxmail.com>
/// Description: CSharp 开发框架
/// </summary>
namespace HongJuZi.Exceptions
{
    /// <summary>
    /// ClassName: HHVerifyException
    /// Author: xjiujiu <xjiujiu@foxmail.com>
    /// Description: None
    /// Version: 1.0
    /// </summary>
    public class HVerifyException: HException
    {
        /// <summary>
        /// 当前的控件对象
        /// </summary>
        private Control _ctl;

        /// <summary>
        /// 一个参数的构造函数
        /// </summary>
        /// <param name="message"></param>
        public HVerifyException(String message):base(message)
        {
            this._ctl   = null;
        }

        /// <summary>
        /// 对有内部信息异常信息的重载
        /// </summary>
        /// <param name="message">当前的异常信息</param>
        /// <param name="innerMsg">内部使用异常信息</param>
        public HVerifyException(String message, String innerMsg): base(message)
        {
            this._innerMsg  = innerMsg;
        }

        /// <summary>
        /// 有传入控件对象的构造函数重载
        /// </summary>
        /// <param name="message">当前的异常消息</param>
        /// <param name="ctl">当前的控件对象</param>
        public HVerifyException(String message, Control ctl):base(message)
        {
            this._ctl   = ctl;
        }
        
        /// <summary>
        /// Control 对象的Settor/Gettor
        /// </summary>
        public Control CTL
        {
            get { return this._ctl; }
            set { this._ctl = value; }
        }
    }
}
