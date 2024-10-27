using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyAOP
{
    /// <summary>
    /// 用.net Remoting/RealProxy实现动态代理
    /// </summary>
    public class RealProxyAOP
    {
        public static void Show()
        {
            User user = new User
            {
                Name = "Honda",
                Password = "123456"
            };

            UserProcessor userProcessor = new UserProcessor();
            userProcessor.RegUser(user);

        }
    }

    public class MyRealProxy<T> : DispatchProxy
    {
        private T tTarget;
        T instance = Activator.CreateInstance<T>();

        public MyRealProxy(T target)
        {
            tTarget = DispatchProxy.Create<T>(instance);
        }
        protected override object Invoke(MethodInfo targetMethod, object[] args)
        {
            throw new NotImplementedException();
        }
    }

    public interface IUserProcessor
    {
        void RegUser(User user);
    }

    public class UserProcessor : MarshalByRefObject,IUserProcessor
    {
        public void RegUser(User user)
        {
            Console.WriteLine($"{user.Name} has been registered");
        }
    }

}
