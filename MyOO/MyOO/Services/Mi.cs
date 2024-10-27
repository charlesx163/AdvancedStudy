using System;
using System.Collections.Generic;
using System.Text;
using MyOO.Interface;

namespace MyOO.Services
{
    public class Mi : BasePhone,IExtend
    {
        public override void System()
        {
            Console.WriteLine($"{this.GetType().Name} system is Android");
        }
        public void Video()
        {
            Console.WriteLine($"{this.GetType().Name} Video");
        }
    }
}
