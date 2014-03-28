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
    /// �ļ�Ŀ¼����������
    /// </summary>
    class HDir: HObject
    {
        /// <summary>
        /// ����ָ��Ŀ¼ 
        /// </summary>
        /// <param name="path">��Ҫ������Ŀ¼</param>
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
                throw new HIOException("�ļ��д���ʧ�ܣ���鿴��־��Ϣ��");    
            }
        }

        /// <summary>
        /// �õ���ǰĿ¼�����е��ļ�
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Array getFiles(String path)
        {
            return HDir.getFiles(path, false);
        }
    
        /// <summary>
        /// ���صõ���ǰĿ¼�������ļ�����
        /// </summary>
        /// <param name="path">��ǰ��Ŀ¼·��</param>
        /// <param name="isIterator">�Ƿ���Ҫ�ݹ���Ŀ¼</param>
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
        /// ��⵱ǰ��·���Ƿ����
        /// </summary>
        /// <param name="path"></param>
        public static void isExists(String path)
        {
            if(false == Directory.Exists(path)) {
                throw new HNotFoundException("Ŀ¼�Ѿ������ڣ���ȷ�ϣ�" + path);
            }
        }
    }
}
