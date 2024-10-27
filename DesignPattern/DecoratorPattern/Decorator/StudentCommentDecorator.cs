using System;

namespace DecoratorPattern.Decorator
{
    public class StudentCommentDecorator:BaseStudentDecorator
    {
        public StudentCommentDecorator(AbstractStudent student) : base(student)
        {
        }

        public override void Study()
        {
            base.Study();
            Console.WriteLine("comment");
        }
    }
}