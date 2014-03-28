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
    /// �ļ�����������
    /// </summary>
    class HFile: HObject
    {
        
        /// <summary>
        /// �����ļ�
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
        /// ��ȡ���е��ļ�����
        /// </summary>
        /// <returns>��ȡ���ļ�����</returns>
        public String read()
        {
            return ""; 
        }

        /// <summary>
        /// ��ȡ�ļ�����
        /// </summary>
        /// <param name="length">��Ҫ��ȡ�ĳ���</param>
        /// <returns>��ȡ���ļ�����</returns>
        public String read(int length)
        {
            return ""; 
        }
        
        /// <summary>
        /// д���ļ�
        /// </summary>
        /// <param name="content">��Ҫд�������</param>
        /// <param name="path">��Ҫд����ļ���·��</param>
        public static void write(String content, String path)
        {
            StreamWriter sw = File.CreateText(path);
            sw.WriteLine(content);
            sw.Close();
        }

        /// <summary>
        /// ׷���ļ�����
        /// </summary>
        /// <param name="content">��Ҫ׷�ӵ�����</param>
        /// <param name="path">��Ҫ������ļ�·�� </param>
        public static void append(String content, String path)
        {
            try {
                StreamWriter sw = File.AppendText(path);
                sw.WriteLine(content);
                sw.Close();
            } catch(IOException ex) {
                throw new HIOException("׷���ļ������쳣�������ļ�·����" + path); 
            }
        }
        
        /// <summary>
        /// ɾ���ļ�
        /// </summary>
        public void delete()
        {
            
        }
            
        /// <summary>
        /// �ļ��Ƿ����
        /// </summary>
        public void isExists()
        {

        }
        
        /// <summary>
        /// �ƶ��ļ�
        /// </summary>
        /// <param name="src">Դ�ļ�</param>
        /// <param name="desc">Ŀ��λ��</param>
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
