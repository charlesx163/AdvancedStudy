using System;
using MyOO.Interface;
using MyOO.Poly;
using MyOO.Services;

namespace MyOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Player player = new Player();
            //iPhone phone = new iPhone();
            //player.PalyIphoe(phone);
            //封装：数据安全，内部保持稳定，提供重用性，分工合作，方便大型系统的构建
            //继承：去掉重复的代码：可以实行多态.侵入性很强的类关系
            //{
            //    BasePhone iPhone = new iPhone();
            //    iPhone.Call();
            //    BasePhone lPhone = new Lumia();
            //    lPhone.Call();
            //}
            //多态：相同的变量(BasePhone),想同的操作(System())，但是不同的实现(System里的实现不一样)
            //实现多态的方法：方法的重载,接口&实现,抽象类 继承
            /*
             * 抽象
             *什么情况需要抽象：每个子类都有这个方法,但是每个方法在子类的实现的方式又不同
             * 就像打印的操作系统,iphone和Android是两个不同的系统,不能用简单的子类继父类的方式,
             * 所以需要在父类中有一个抽象的方法,然后各自去重写这个方法去实现自己的逻辑
             */
            {
                BasePhone basePhone = new iPhone();
                basePhone.Call();
                basePhone.System();//运行时多态
                dynamic dIphone = basePhone;
                dIphone.Video();//避开编译器的检查，因为在运行是时这个方法是存在，之所不能用basePhone调用时因为编译器的原因，因为在编译阶段这个类里没这个方法

            }
            //{
            //    BasePhone basePhone = new Lumia();
            //    basePhone.Call();
            //    basePhone.System();//运行时多态
            //}
            //接口多态
            //{
            //    IExtend extendPhone = new iPhone();
            //    extendPhone.Video();
            //    dynamic dp = extendPhone;
            //    dp.Call();
            //}
            //{
            //    IExtend basePhone = new Lumia();
            //    basePhone.Video();
            //}
            //接口:约束 多实现多灵活 can do
            //抽象:父类+约束 可以完成通用实现 只能单继承 is a

            {
                //Parent parent = new Child();
                //parent.Print();
                Child parentGrand = new Grand();
                parentGrand.Print();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
