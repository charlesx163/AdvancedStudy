using System;
using System.Collections.Generic;
using System.Text;

namespace MyDelegateEvent
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int ClassId { get; set; }

        public void Study()
        {
            Console.WriteLine("Study");
        }
    }
}
