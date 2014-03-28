using System;
using System.Collections.Generic;
using System.Text;
using HongJuZi.Core;
using System.IO;
using HongJuZi.Log;
using HongJuZi.Exceptions;

namespace HongJuZi.FileSystem
{
    /// <summary>
    /// 文件操作工具类
    /// </summary>
    class HFile: HObject
    {
        
        /// <summary>
        /// 创建文件
        /// </summary>
        public static void create(String path)
        {
            if(File.Exists(path)) {
                return;
            }
            FileStream fs = File.Create(path);
            Byte[] info = { 0, 0, 0, 0, 0, 0 };
            fs.Write(info, 0, info.Length);
            fs.Close();
        }
        
        /// <summary>
        /// 读取所有的文件内容
        /// </summary>
        /// <returns>读取的文件内容</returns>
        public String read()
        {
            return ""; 
        }

        /// <summary>
        /// 读取文件内容
        /// </summary>
        /// <param name="length">需要读取的长度</param>
        /// <returns>读取的文件内容</returns>
        public String read(int length)
        {
            return ""; 
        }
        
        /// <summary>
        /// 写入文件
        /// </summary>
        /// <param name="content">需要写入的内容</param>
        /// <param name="path">需要写入的文件夹路径</param>
        public static void write(String content, String path)
        {
            StreamWriter sw = File.CreateText(path);
            sw.WriteLine(content);
            sw.Close();
        }

        /// <summary>
        /// 追加文件内容
        /// </summary>
        /// <param name="content">需要追加的内容</param>
        /// <param name="path">需要处理的文件路径 </param>
        public static void append(String content, String path)
        {
            try {
                StreamWriter sw = File.AppendText(path);
                sw.WriteLine(content);
                sw.Close();
            } catch(IOException ex) {
                throw new HIOException("追加文件出现异常！操作文件路径：" + path); 
            }
        }
        
        /// <summary>
        /// 删除文件
        /// </summary>
        public void delete()
        {
            
        }
            
        /// <summary>
        /// 文件是否存在
        /// </summary>
        public void isExists()
        {

        }
        
        /// <summary>
        /// 移动文件
        /// </summary>
        /// <param name="src">源文件</param>
        /// <param name="desc">目标位置</param>
        public static void move(String src, String desc)
        {
            try {
                File.Move(src, desc);
            } catch(Exception ex) {
                HLog.write(ex.StackTrace, HLog.L_ERROR);
            }
        }

    }
}
