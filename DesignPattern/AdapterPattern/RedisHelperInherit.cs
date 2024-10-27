using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    /// <summary>
    /// 类适配器：一个继承的适配器
    /// </summary>
    public class RedisHelperInherit:RedisHelper,IHelper
    {
        public void Add<T>()
        {
            base.RedisAdd<T>();
        }

        public void Delete<T>()
        {
            base.RedisDelete<T>();
        }
    }
}
