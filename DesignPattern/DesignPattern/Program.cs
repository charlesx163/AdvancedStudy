using System;

namespace DesignPattern
{
    /// <summary>
    /// 1 创建型模式：关注对象的创建
    /// 单例模式  原型模式:MemberwiseClone()
    /// (想去掉什么就就封装什么)
    /// 简单工厂(把所有的类的创建都放在工厂里)
    /// 工厂方法(为每个类都创建一个工厂，然后在定义一个IFactory，让所有的类的创建工厂都继承自这接口，方便扩展)
    /// 抽象工厂：工厂+约束 负责创建一组对象，前面两个都是对单一的类
    /// 创建者模式
    /// 2 结构型模式:关注类与类之间的关系
    /// 3 行为型模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
