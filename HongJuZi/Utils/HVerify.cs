/// <summary>
/// FileName: HHVerify.cs
/// CLRVersion: 2.0.50727.3643
/// Author: xjiujiu <xjiujiu@foxmail.com>
/// Corporation: 怀化学院软件创新工作室
/// Description: CSharp 开发框架
/// DateTime: 2012-11-15 20:34:15
/// </summary>
using System;
using System.Text;
using HongJuZi.Core;
using HongJuZi.Exceptions;
using System.Text.RegularExpressions;

/// <summary>
/// NameSpace: HongJuZi.Utils
/// Author: xjiujiu <xjiujiu@foxmail.com>
/// Description: CSharp 开发框架
/// </summary>
namespace HongJuZi.Utils
{
    /// <summary>
    /// ClassName: HHVerify
    /// Author: xjiujiu <xjiujiu@foxmail.com>
    /// Description: None
    /// Version: 1.0
    /// </summary>
    public class HVerify: HObject
    {
        /// <summary>
        /// 检测字符串长度是否在规定的范围之内
        /// </summary>
        /// <param name="str">需要检测的字符串</param>
        /// <param name="name">当前的检测项目名称</param>
        /// <param name="min">最小长度</param>
        /// <param name="max">最大长度</param>
        /// <exception cref="HVerifyException">验证异常</exception>
        public static void stringInLength(String str, String name, int min, int max)
        {
            if(null == str) {
                throw new HVerifyException(name + "不能为空！");
            }
            if(min > str.Length) {
                throw new HVerifyException(name + "长度不能小于" + min + "！");
            }
            if(max != 0 && max < str.Length) {
                throw new HVerifyException(name + "长度不能大于" + max + "！");
            }
        }
        
        /// <summary>
        /// 对没有传最大值的字符串长度检测重载
        /// </summary>
        /// <param name="str">当前的字符串长度</param>
        /// <param name="name">当前的检测内容名称</param>
        /// <param name="min">最小长度</param>
        public static void stringInLength(String str, String name, int min)
        {
            try {
                HVerify.stringInLength(str, name, min, 0);
            } catch(HVerifyException ex) {
                throw new HVerifyException(ex.Message);
            }
        }

        /// <summary>
        /// 重载字符串长度检测方法
        /// </summary>
        /// <param name="ctl">当前的控件对象</param>
        /// <param name="name">内容名称</param>
        /// <param name="min">最小长度</param>
        /// <param name="max">最大长度</param>
        public static void stringInLength(System.Windows.Forms.Control ctl, String name, int min, int max)
        {
            try {
                HVerify.stringInLength(ctl.Text, name, min, max);
            } catch(HVerifyException ex) {
                throw new HVerifyException(ex.Message, ctl);
            }
        }
         
        /// <summary>
        /// 是否为合法的资源链接
        /// </summary>
        /// <param name="uri">需要检测的资源链接</param>
        public static void isUri(String uri)
        {
            String uriReg = "(http[s]{0,1}|ftp)://[a-zA-Z0-9\\.\\-]+\\.([a-zA-Z]{2,4})(:\\d+)?(/[a-zA-Z0-9\\.\\-~!@#$%^&*+?:_/=<>]*)?";
            Regex reg       = new Regex(uriReg);
            Match match     = reg.Match(uri); 
            if(!match.Success) {
                throw new HVerifyException("网址链接不正确!正确格式如：http://HongJuZi.hhtc.edu.cn");
            }
        }
        
        /// <summary>
        /// 重载当前的传入控件的链接检测
        /// </summary>
        /// <param name="ctl">当前的控件对象</param>
        public static void isUri(System.Windows.Forms.Control ctl)
        {
            try {
                HVerify.isUri(ctl.Text);
            } catch(HVerifyException ex) {
                throw new HVerifyException(ex.Message, ctl);
            }
        }
    }
}
