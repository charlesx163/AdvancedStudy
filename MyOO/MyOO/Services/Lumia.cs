using System;
using System.Collections.Generic;
using System.Text;
using MyOO.Interface;

namespace MyOO.Services
{
    public class Lumia : BasePhone,IExtend
    {
        public override void System()
        {
            Console.WriteLine($"{this.GetType().Name} system is WinPhone");
        }
        public void Video()
        {

        }
    }
}
