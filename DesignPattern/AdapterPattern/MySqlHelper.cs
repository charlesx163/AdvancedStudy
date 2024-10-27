using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class MySqlHelper:IHelper
    {
        public void Add<T>()
        {
            Console.WriteLine("This Add");
        }

        public void Delete<T>()
        {
            Console.WriteLine("This Delete");
        }
    }
}
