using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    /// <summary>
    /// 把RealSubject 包在代理类，外层通过代理类来访问RealSubject的方法
    /// </summary>
    public class ProxySubject:ISubject
    {
        private static RealSubject _realSubject = new RealSubject();//代理模式下的单例
        private static Dictionary<string, bool> proxyDictionary = new Dictionary<string, bool>();
        public bool GetSomething()
        {
            //可以再这里做一些其他事情，比如说记日志，做缓存
            bool flag = false;
            string key = "GetSomething";
            if (proxyDictionary.ContainsKey(key))
            {
                flag = proxyDictionary[key];
            }
            else
            {
                flag = _realSubject.GetSomething();
                proxyDictionary[key] = flag;
            }
            return _realSubject.GetSomething();
        }
    }
}
