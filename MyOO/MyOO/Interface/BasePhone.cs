using System;
using System.Collections.Generic;
using System.Text;

namespace MyOO.Interface
{
    /// <summary>
    /// 抽象类：父类+约束
    /// </summary>
    public abstract class BasePhone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }

        public void Call()
        {
            Console.WriteLine($"Use {this.GetType().Name} Call");
        }
        public void Text()
        {
            Console.WriteLine($"Use {this.GetType().Name} Text");
        }

        public abstract void System();
    }
}
