using System;
using System.Collections.Generic;
using System.Text;

namespace MyDelegateEvent.Event
{
    public class Cat
    {
        public void Miao()
        {
            Console.WriteLine($"{0} Miao",this.GetType().Name);
            new Mouse().Run();
            new Baby().Cry();
        }

        //猫叫触发后续动作
        public MiaoDelegate MiaoDelegateHandler;
        public void MiaoNew()
        {
            Console.WriteLine($"{0} MiaoNew", this.GetType().Name);
            if (this.MiaoDelegateHandler != null)
            {
                MiaoDelegateHandler.Invoke();
            }
        }


        //event  带event关键字的委托实例，限制变量被外部调用或直接赋值，只有在申明的类的内部可以操作，其他的都不行
        public event MiaoDelegate MiaoDelegateHandlerEvent;
        public void MiaoNewEvent()
        {
            Console.WriteLine($"{0} MiaoNew", this.GetType().Name);
            if (this.MiaoDelegateHandlerEvent != null)
            {
                MiaoDelegateHandlerEvent.Invoke();
            }
        }
    }

    public delegate void MiaoDelegate();
}
