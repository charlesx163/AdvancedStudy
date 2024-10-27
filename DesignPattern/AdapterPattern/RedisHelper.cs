using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class RedisHelper
    {
        public void RedisAdd<T>()
        {
            Console.WriteLine("This is redis add");
        }
        public void RedisDelete<T>()
        {
            Console.WriteLine("This is redis delete");
        }
    }
}
