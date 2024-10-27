using System;

namespace DecoratorPattern.Decorator
{
    public class BaseStudentDecorator:AbstractStudent
    {
        private AbstractStudent _student = null;

        public BaseStudentDecorator(AbstractStudent student)
        {
            this._student = student;
        }
        
        public override void Study()
        {
            this._student.Study();
            Console.WriteLine("******************");
        }
    }
}