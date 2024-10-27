using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern.Observer
{
    public class Baby: IObserver
    {
        public void Cry()
        {
            Console.WriteLine("Baby Cry");
        }

        public void Action()
        {
            this.Cry();
        }
    }
}
