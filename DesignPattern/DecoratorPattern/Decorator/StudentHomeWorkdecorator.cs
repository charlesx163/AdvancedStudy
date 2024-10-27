using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern.Decorator
{
    public class StudentHomeWorkdecorator : BaseStudentDecorator
    {
        public StudentHomeWorkdecorator(AbstractStudent student) : base(student)
        {
        }

        public override void Study()
        {
            base.Study();
            Console.WriteLine("巩固练习");
        }
    }
}
