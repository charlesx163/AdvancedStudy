using System;
using System.Threading.Channels;
using HomeWork0807.Service;

namespace HomeWork0807
{
    class Program
    {
        static void Main(string[] args)
        {
            var west = VentriloquistFactory.CreateVentriloquist<WestVentriloquist>();
            //west.ShowUniSkill();
            west.FireOn += () => Console.Write("test event");
            west.SetTempreature(500);
            Console.WriteLine("Hello World!");
        }
    }
}
