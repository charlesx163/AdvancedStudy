using System;
using System.Collections.Generic;
using System.Text;

namespace MyDelegateEvent.Event
{
    public class Baby
    {
        public void Cry()
        {
            Console.WriteLine($"{this.GetType().Name} Cry");
        }
    }
}
