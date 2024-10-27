using System;
using System.Collections.Generic;
using System.Text;

namespace MyDelegateEvent
{
    public delegate void NoReturnNoPara<T>(T t);

    public delegate void NoReturnNoPara();

    public delegate void NoReturnWithPara(int x, int y);

    public delegate int WithReturnNoPara();

    public delegate int WithReturnWithPara(out int x, out int y);

    public class MyDelegate
    {
        public void Show()
        {
            Student student = new Student
            {
                Age = 12,
                ClassId = 1,
                Id = 1,
                Name = "xu"
            };
            student.Study();

            {
                NoReturnNoPara method = new NoReturnNoPara(this.DoNothing);
                method.Invoke();
            }
        }

        public void DoNothing()
        {
            Console.WriteLine("This is DoNothing");
        }
        public static void DoNothingStatic()
        {
            Console.WriteLine("This is DoNothingStatic");
        }
    }
}
