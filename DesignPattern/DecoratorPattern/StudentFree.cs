using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class StudentFree:AbstractStudent
    {
        public override void Study()
        {
            Console.WriteLine($"{base.Name} is not a VIP");
        }
    }
}
