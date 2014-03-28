/// <summary>
/// FileName: HHRequest.cs
/// CLRVersion: 2.0.50727.3643
/// Author: xjiujiu <xjiujiu@foxmail.com>
/// Corporation: 怀化学院软件创新工作室
/// Description: CSharp 开发框架
/// DateTime: 2012-11-16 21:11:22
/// </summary>
using System;
using System.Text;
using HongJuZi.Core;
using System.Net;
using System.IO;
using HongJuZi.Exceptions;
using HongJuZi.Utils;

/// <summary>
/// NameSpace: HongJuZi.Net
/// Author: xjiujiu <xjiujiu@foxmail.com>
/// Description: CSharp 开发框架
/// </summary>
namespace HongJuZi.Net
{
    /// <summary>
    /// ClassName: HHRequest
    /// Author: xjiujiu <xjiujiu@foxmail.com>
    /// Description: None
    /// Version: 1.0
    /// </summary>
    public class HRequest: HObject
    {
        /// <summary>
        /// 超时时间设置为20s
        /// </summary>
        private static int _timeOut     = 20000;

        /// <summary>
        /// 构造函数
        /// </summary>
        public HRequest(): base()
        {
        }
        
        /// <summary>
        /// 发起GET方式的WEB请求
        /// </summary>
        /// <param name="url">当前请求的链接</param>
        /// <param name="query">当前请求的变量</param>
        /// <returns>请求的流数据</returns>
        /// <exception cref="HRequestException">请求异常</exception>
        public static String get(String url)
        {
            return HString.streamToString(HRequest.getStream(url), Encoding.UTF8);
        }
        
        /// <summary>
        /// GET方式得到请求的内容
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static Stream getStream(String url)
        {
            try {
                HttpWebRequest request      = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout             = HRequest._timeOut;
                request.Method              = "GET";
                HttpWebResponse response    = (HttpWebResponse)request.GetResponse();
                return response.GetResponseStream();
            } catch(Exception ex) {
                throw new HRequestException("请求出错！", url + ": " + ex.Message);
            }
        }
        
        /// <summary>
        /// 对有参数的请求GET模式重载 
        /// </summary>
        /// <param name="url">当前需要请求的链接</param>
        /// <param name="queryString">当前的变量</param>
        /// <returns>请求的流数据</returns>
        /// <exception cref="HRequestException">请求异常</exception>
        public static String get(String url, String queryString)
        {
            try {
                return HRequest.get(url + queryString);
            } catch(HRequestException ex) {
                throw new HRequestException("请求出错！", url + queryString + ": " + ex.Message);
            }
        }
        
        /// <summary>
        /// 发起POST方式的WEB请求
        /// </summary>
        /// <param name="url">当前请求的链接</param>
        /// <param name="parameters">当前请求的参数</param>
        /// <param name="encode">当前的返回值编码类型</param>
        /// <returns>得到的结果</returns>
        public static String post(String url, String parameters, String encode)
        {
            try {
                byte [] bParameters         = Encoding.ASCII.GetBytes(parameters);
                HttpWebRequest request      = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout             = HRequest._timeOut;
                request.Method              = "post";
                request.Accept              = "text/html, application/xhtml+xml, */*";
                request.ContentType         = "application/x-www-form-urlencoded";
                request.ContentLength       = bParameters.Length;
                request.GetRequestStream().Write(bParameters, 0, bParameters.Length);
                HttpWebResponse response    = (HttpWebResponse)request.GetResponse();
                using (StreamReader reader = new StreamReader(
                    response.GetResponseStream(),
                    System.Text.Encoding.GetEncoding(encode)
                )) {
                    return reader.ReadToEnd();
                }
            } catch(Exception ex) {
                throw new HRequestException("请求出错！", url + ": " + ex.Message);
            }
        }
    }
}
