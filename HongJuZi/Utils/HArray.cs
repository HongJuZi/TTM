using System;
using System.Collections.Generic;
using System.Text;
using HongJuZi.Core;
using System.Collections;

namespace HongJuZi.Utils
{
    /// <summary>
    /// ���鼯�Ϲ�����
    /// </summary>
    class HArray : HObject
    {
        /// <summary>
        /// �ϲ������ַ�������
        /// </summary>
        /// <param name="first">��һ������</param>
        /// <param name="second">�ڶ�����</param>
        /// <returns></returns>
        public static String [] merge(String [] first, String [] second)
        {
            if(null == first && null == second) {
                return null;
            }
            if(null == first) {
                return second;
            }
            if(null == second) {
                return first;
            }
            int loc             = 0;
            int totalLength     = first.Length + second.Length;
            String[] newArray   = new String[totalLength];
            foreach(String str in first) {
                newArray.SetValue(str, loc);
                loc ++;
            }
            foreach(String str in second) {
                newArray.SetValue(str, loc);
                loc ++;
            }

            return newArray;
        }
    }
}
