using System;
using System.Collections.Generic;
using System.Text;
using HongJuZi.Core;
using System.Configuration;
using System.Xml;
using System.Collections.Specialized;
using System.Collections;

namespace HongJuZi.FileSystem
{
    /// <summary>
    /// 配置文件工具类
    /// </summary>
    public class HConfig: HObject
    {
        /// <summary>
        /// 需要处理的配置文件路径
        /// </summary>
        private String _path;
        public String Path {
            set { this._path = value; }
            get { return this._path; }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="path">需要处理的配置文件路径</param>
        public HConfig(): base()
        {
            //some code
        }
        
        /// <summary>
        /// 得到配置键值
        /// </summary>
        /// <param name="key">查找的配置键</param>
        /// <returns>配置值</returns>
        public static String getCfg(String key)
        {
            return ConfigurationSettings.AppSettings["" + key + ""];
        } 

        /// <summary>
        /// 得到键值配置对象
        /// </summary>
        /// <param name="path">需要查找的xml的path</param>
        /// <returns>查找到的结果数据</returns>
        public static NameValueCollection getNameValue(String path)
        {
            return ConfigurationManager.GetSection(path) as NameValueCollection;
        }

        /// <summary>
        /// 得到哈希表对象
        /// </summary>
        /// <param name="path">需要查找的xml的路径</param>
        /// <returns>查找到的hashtable对象</returns>
        public static Hashtable getHashSet(String path)
        {
            return ConfigurationManager.GetSection(path) as Hashtable;
        }

        /// <summary>
        /// 得到字典对象
        /// </summary>
        /// <param name="path">查找的路径</param>
        /// <returns>查找的字典对象</returns>
        public static IDictionary getDictionary(String path)
        {
            return ConfigurationManager.GetSection(path) as IDictionary;
        }
        
        /// <summary>
        /// 设置配置内容
        /// </summary>
        /// <param name="key">需要查找的键</param>
        /// <param name="value">更新后的值</param>
        public static void setCfg(String key, String value)
        {
            XmlDocument xml     = new XmlDocument();
            xml.Load(System.Windows.Forms.Application.ExecutablePath + ".config");
            XmlNode node        = xml.SelectSingleNode("//appSettings");
            XmlElement element  = (XmlElement)node.SelectSingleNode("//add[@key='" + key + "']");
            if(null != element) {
                element.SetAttribute("value", value);
                return;
            }
            XmlElement newElement = xml.CreateElement("add");
            newElement.SetAttribute("key", key);
            newElement.SetAttribute("value", value);
            node.AppendChild(newElement);
        }
    }
}
