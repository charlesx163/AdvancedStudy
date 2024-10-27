using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    /// <summary>
    /// 如何让在程序入口也一IHelper的方式调用RedisHelper的方法
    /// 对象适配器：组合适配器
    /// 这个例子只是有一个对象
    /// 还可以写多个和RedisHelper一样的对象
    /// </summary>
    public class RedisHelperCombination:IHelper
    {
        private RedisHelper _redisHelper = new RedisHelper();
        public void Add<T>()
        {
            this._redisHelper.RedisAdd<T>();
        }

        public void Delete<T>()
        {
            this._redisHelper.RedisDelete<T>();
        }
    }
}
