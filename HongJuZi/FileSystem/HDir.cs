using System;
using HongJuZi.Core;
using System.IO;
using System.Collections;
using HongJuZi.Exceptions;
using HongJuZi.Utils;
using HongJuZi.Log;

namespace HongJuZi.FileSystem
{
    /// <summary>
    /// 文件目录操作工具类
    /// </summary>
    class HDir: HObject
    {
        /// <summary>
        /// 创建指定目录 
        /// </summary>
        /// <param name="path">需要创建的目录</param>
        public static void create(String path)
        {
            try {
                Directory.CreateDirectory(path);
            } catch(PathTooLongException ex) {
                throw new HIOException(ex.Message);
            } catch(DirectoryNotFoundException ex){
                throw new HIOException(ex.Message);
            } catch (IOException ex) {
                throw new HIOException(ex.Message);
            } catch(Exception ex) {
                Console.WriteLine(ex.StackTrace);
                throw new HIOException("文件夹创建失败，请查看日志信息！");    
            }
        }

        /// <summary>
        /// 得到当前目录下所有的文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Array getFiles(String path)
        {
            return HDir.getFiles(path, false);
        }
    
        /// <summary>
        /// 重载得到当前目录下所有文件方法
        /// </summary>
        /// <param name="path">当前的目录路径</param>
        /// <param name="isIterator">是否需要递归子目录</param>
        /// <returns></returns>
        public static String [] getFiles(String path, bool isIterator)
        {
            try {
                if(false == isIterator) {
                    return Directory.GetFiles(path);
                }
                String [] dirs  = Directory.GetDirectories(path);
                if(0 < dirs.Length) {
                    return Directory.GetFiles(path);
                }
                String [] files = Directory.GetFiles(path);
                foreach(String subDir in dirs) {
                    files       = HArray.merge(files, getFiles(subDir, true));
                }
                
                return files;
            } catch(HNotFoundException ex) {
                HLog.write(ex.StackTrace);
                return null;
            }
        }
       
        /// <summary>
        /// 检测当前的路径是否存在
        /// </summary>
        /// <param name="path"></param>
        public static void isExists(String path)
        {
            if(false == Directory.Exists(path)) {
                throw new HNotFoundException("目录已经不存在，请确认！" + path);
            }
        }
    }
}
