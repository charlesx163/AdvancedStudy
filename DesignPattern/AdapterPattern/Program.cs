using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                IHelper mysql = new MySqlHelper();
                mysql.Add<Program>();
                mysql.Delete<Program>();

                IHelper redis = new RedisHelperInherit();
                redis.Add<Program>();
                redis.Delete<Program>();

                IHelper redisNoInherit = new RedisHelperCombination();
                redisNoInherit.Delete<Program>();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
