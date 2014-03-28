using System;
using System.Collections.Generic;
using System.Text;
using HongJuZi.Core;
using System.Collections;

namespace HongJuZi.Utils
{
    /// <summary>
    /// 数组集合工具类
    /// </summary>
    class HArray : HObject
    {
        /// <summary>
        /// 合并两个字符串数组
        /// </summary>
        /// <param name="first">第一个数组</param>
        /// <param name="second">第二数组</param>
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
