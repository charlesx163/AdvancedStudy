using System;
using DecoratorPattern.Decorator;

namespace DecoratorPattern
{
    /// <summary>
    /// 不修改类又要增加新的功能
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                {
                    //StudentVipCombine c = new StudentVipCombine();
                    //c.SetStudentVipCombine(new StudentVip());
                }
                {
                    //AbstractStudent vip = new StudentVip
                    //{
                    //    Id = 1,
                    //    Name = "Honda"
                    //};
                    //BaseStudentDecorator baseStudentDecorator = new BaseStudentDecorator(vip);
                    //AbstractStudent abstractStudent = new BaseStudentDecorator(vip);
                    //vip=new BaseStudentDecorator(vip);
                    //vip.Study();
                }
                {
                    AbstractStudent vip = new StudentVip
                    {
                        Id = 1,
                        Name = "Honda"
                    };
                    vip=new StudentCommentDecorator(vip);
                    vip = new StudentHomeWorkdecorator(vip);
                    vip.Study();
                }
                
                

                Console.WriteLine("Hello World!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            
        }
    }
}
