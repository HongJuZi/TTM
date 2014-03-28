using System;
using System.Collections.Generic;
using System.Text;

namespace HongJuZi.Exceptions
{
    /// <summary>
    /// 框架没有找到对象异常
    /// </summary>
    public class HNotFoundException: Exception
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="msg">异常消息</param>
        public HNotFoundException(String msg): base(msg)
        {
            //some other code
        }
    }
}
