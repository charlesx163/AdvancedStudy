using System;
using System.Collections.Generic;
using System.Text;

namespace MyAttribute
{
    [Customer(123,Description = "1234",Remark = "1234")]
    public class Student
    {
        [Customer(Description = "Property")]
        public int Id { get; set; }

        [Length(3,10)]
        public string Name { get; set; }

        [Long(10001,999999999999)]
        public int QQ { get; set; }
        public void Study()
        {
            Console.WriteLine($"This is {this.Name} following your study");
        }
        [Customer(Description = "Answer",Remark = "123")]
        public string Answer([Customer]string name)
        {
            return $"This is {name}";
        }
    }
}
