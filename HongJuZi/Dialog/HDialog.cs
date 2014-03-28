/// <summary>
/// FileName: HDialog.cs
/// CLRVersion: 2.0.50727.3643
/// Author: xjiujiu <xjiujiu@foxmail.com>
/// Corporation: 怀化学院软件创新工作室
/// Description: CSharp 开发框架
/// DateTime: 2013-5-19 21:16:21
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// NameSpace: HongJuZi.Dialog
/// Author: xjiujiu <xjiujiu@foxmail.com>
/// Description: CSharp 开发框架
/// </summary>
namespace HongJuZi.Dialog
{
    /// <summary>
    /// ClassName: HDialog 弹框类
    /// Author: xjiujiu <xjiujiu@foxmail.com>
    /// Description: None
    /// Version: 1.0
    /// </summary>
    class HDialog
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public HDialog()
        {
            //some code
        }

        public static void info(String msg)
        {
            HDialog._dialog(msg);
        }

        protected static void _dialog(String msg)
        {
        }

    }
}
