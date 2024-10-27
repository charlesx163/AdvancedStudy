 using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace DesignPattern
{
    /// <summary>
    /// 单例模式和原型模式
    /// </summary>
    public class SingletonClass
    {
        private static object _singletonLock=new object();
        private static SingletonClass _singletonClass;
        private SingletonClass(){}


        public static SingletonClass CreateInstance()
        {
            if (_singletonClass == null)
            {
                lock (_singletonLock)
                {
                    if (_singletonClass == null)
                    {
                        _singletonClass = new SingletonClass();
                    }
                }
            }
            return _singletonClass;
        }

        /// <summary>
        /// 原型模式的创建
        /// </summary>
        /// <returns></returns>
        public static SingletonClass CreateInstancePrototype()
        {
            SingletonClass singleton = (SingletonClass) _singletonClass.MemberwiseClone();
            return singleton;
        }
    }
}
