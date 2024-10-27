using System;
using MyDelegateEvent.DelegateExtend;
using MyDelegateEvent.Event;

namespace MyDelegateEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********Event**************");
            {
                ListExtend listExtend = new ListExtend();
                listExtend.Show();
            }
            {
                Cat cat = new Cat();
                cat.Miao();
            }
            //delegate
            {
                Cat cat = new Cat();
                cat.MiaoDelegateHandler += new MiaoDelegate(new Mouse().Run);
                cat.MiaoDelegateHandler += new MiaoDelegate(new Baby().Cry);
                cat.MiaoNew();
            }

            //event:限制变量被外部调用或直接赋值
            /*
             * 事件只有在申明的类的内部可以被调用和赋值，其他的都不行
             * 委托:是个类型
             * 事件：是委托的一个实例
             */
            {
                Cat cat = new Cat();
                cat.MiaoDelegateHandlerEvent += new MiaoDelegate(new Mouse().Run);
                cat.MiaoDelegateHandler += new MiaoDelegate(new Baby().Cry);
                cat.MiaoNew();

            }

            //观察者模式:对event和delegate的应用
        }
    }
}
