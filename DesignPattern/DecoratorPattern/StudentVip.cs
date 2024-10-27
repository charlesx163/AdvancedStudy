using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace DecoratorPattern
{
    public class StudentVip:AbstractStudent
    {
        public override void Study()
        {
            Console.WriteLine($"{base.Name} is a VIP");
        }
    }

    public class StudentVipInherit : StudentVip
    {
        public override void Study()
        {
            base.Study();
            Console.WriteLine("get code");
        }
    }
    public class StudentVipCombine
    {
        private AbstractStudent _abstractStudent;

        //public StudentVipCombine(AbstractStudent abstractStudent)
        //{
        //    this._abstractStudent = abstractStudent;
        //}
        public void SetStudentVipCombine(AbstractStudent abstractStudent)
        {
            this._abstractStudent = abstractStudent;
        }
        public  void Study()
        {
            _abstractStudent.Study();
            Console.WriteLine("get code");
        }
    }

}
