using System;

namespace TemplatePattern
{
    public abstract class AbstractClient
    {
        /// <summary>
        /// 这里就完成了对通用封装，
        /// 当遇到不同的操作时，例如calculateInterest时由于传进的子类不同就去调用子类的方法
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="password"></param>
        public void Query(int id,string name,string password)
        {
            if (this.CheckUser(id, password))
            {
                var balance = this.QueryBalance();
                var interset = this.CalculateInterest(balance);
                this.Show(name,balance,interset);
            }
            
        }

        public bool CheckUser(int id, string password)
        {
            return DateTime.Now < DateTime.Now.AddDays(1);
        }

        public double QueryBalance()
        {
            return new Random().Next(100, 1000);
        }

        /// <summary>
        /// 不同的方式利率不同
        /// </summary>
        /// <param name="balance"></param>
        /// <returns></returns>
        public abstract double CalculateInterest(double balance);

        public virtual void Show(string name, double balance, double interest)
        {
            Console.WriteLine($"Dear {name},your account balance is {balance}, interest is {interest}");
        }
    }
}