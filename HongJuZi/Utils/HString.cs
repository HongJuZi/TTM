/// <summary>
/// FileName: HHString.cs
/// CLRVersion: 2.0.50727.3643
/// Author: xjiujiu <xjiujiu@foxmail.com>
/// Corporation: 怀化学院软件创新工作室
/// Description: CSharp 开发框架
/// DateTime: 2012-11-17 22:06:39
/// </summary>
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using HongJuZi.Exceptions;

/// <summary>
/// NameSpace: HongJuZi.Utils
/// Author: xjiujiu <xjiujiu@foxmail.com>
/// Description: CSharp 开发框架
/// </summary>
namespace HongJuZi.Utils
{
    /// <summary>
    /// ClassName: HHString
    /// Author: xjiujiu <xjiujiu@foxmail.com>
    /// Description: None
    /// Version: 1.0
    /// </summary>
    public class HString
    {
        /// <summary>
        /// 流换成字符串
        /// </summary>
        /// <param name="stream">需要转换的流数据</param>
        /// <param name="encode">当前的编码类型</param>
        /// <returns>结果数据串</returns>
        public static String streamToString(System.IO.Stream stream, Encoding encode)
        {
            try {
                StreamReader readStream = new StreamReader(stream, encode);
                String str              = readStream.ReadToEnd(); 
                readStream.Close();
                return str;
            } catch(Exception ex) {
                throw new HUtilsException("流数据生成到字符串异常！", "streamToString: " + ex.Message);
            }
        }
    }
}
