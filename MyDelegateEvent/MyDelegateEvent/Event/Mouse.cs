using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace MyDelegateEvent.Event
{
    public class Mouse
    {
        public void Run()
        {
            Console.WriteLine($"{this.GetType().Name} Run");
        }
    }
}
