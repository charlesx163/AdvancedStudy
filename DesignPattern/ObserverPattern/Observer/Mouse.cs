using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Observer
{
    public class Mouse : IObserver
    {
        public void Run()
        {
            Console.WriteLine("Mouse run");
        }

        public void Action()
        {
            this.Run();
        }
    }
}
