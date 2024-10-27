using System;

namespace TemplatePattern
{
    /// <summary>
    /// 这里面的利率计算和显示的东西会因为客户的种类不同而不同
    /// 所以可以抽象出来，做一个模板
    /// </summary>
    public class Client
    {
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
        public double CalculateInterest(double balance)
        {
            return balance * 7;
        }

        public void Show(string name,double balance,double interest)
        {
            Console.WriteLine($"Dear {name},your account balance is {balance}, interest is {interest}");
        }
        
    }
}