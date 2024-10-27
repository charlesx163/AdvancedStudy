using System;

namespace MyAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                {
                    Student student = new Student();
                    student.Id = 123;
                    student.Name="time";
                    student.QQ = 123456;
                    student.Study();
                    Manager.Show(student);
                    student.QQ = 9999;
                    student.Name = "mm";
                    Manager.Show(student);
                }
                {
                    UserState userState = UserState.Normal;
                    UserState userState1 = UserState.Deleted;
                    //if (userState == UserState.Normal)
                    //{
                    //    Console.WriteLine("正常");
                    //}
                    //else if (userState == UserState.Frozen)
                    //{

                    //}
                    //else if (userState == UserState.Deleted)
                    //{

                    //}
                    Console.WriteLine(userState.GetRemark());
                    Console.WriteLine(userState1.GetRemark());
                }
                Console.WriteLine("Hello World!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
