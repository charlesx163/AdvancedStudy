using System;
using System.Collections.Generic;
using System.Text;

namespace MyAttribute
{
    [AttributeUsage(AttributeTargets.All,AllowMultiple = false)]
    public class CustomerAttribute:Attribute
    {
        public CustomerAttribute(){}
        public CustomerAttribute(int id){}
        public string Description { get; set; }
        //public int Id { get; set; }
        public string Remark = null;

        public void Show()
        {
            Console.WriteLine("This is CustomerAttribute");
        }
    }
}
