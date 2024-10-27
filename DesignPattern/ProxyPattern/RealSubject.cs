using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class RealSubject:ISubject
    {
        public bool GetSomething()
        {
            Console.WriteLine("this is GetSomething");
            return true;
        }
    }
}
