using System;
using ObserverPattern.Observer;
using ObserverPattern.Subject;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Cat c = new Cat();
                c.Miao();
            }
            {
                Cat c = new Cat();
                c.AddObserver(new Baby());
                c.AddObserver(new Mouse());
                c.MiaoObserver();

            }
            Console.WriteLine("Hello World!");
        }
    }
}
