using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyAttribute
{
    public class Manager
    {
        public static void Show(Student s)
        {
            Type typeStudent = typeof(Student);//get the attribute in class

            #region  获取类,属性,方法,出参,入参上是否有attribute

            //if (typeStudent.IsDefined(typeof(CustomerAttribute), false))
            //{
            //    CustomerAttribute attribute = (CustomerAttribute)typeStudent.GetCustomAttribute(typeof(CustomerAttribute), true);
            //    Console.WriteLine($"{attribute.Description}_{attribute.Remark}");
            //    attribute.Show();
            //}

            //PropertyInfo property = typeStudent.GetProperty("Id");//get the attribute in property
            //if (property.IsDefined(typeof(CustomerAttribute), true))
            //{
            //    CustomerAttribute attribute = (CustomerAttribute)property.GetCustomAttribute(typeof(CustomerAttribute), true);
            //    Console.WriteLine($"{attribute.Description}_{attribute.Remark}");
            //    attribute.Show();
            //}

            //MethodInfo methodInfo = typeStudent.GetMethod("Answer");//get the attribute in method
            //if (methodInfo.IsDefined(typeof(CustomerAttribute), true))
            //{
            //    CustomerAttribute attribute =
            //        (CustomerAttribute) methodInfo.GetCustomAttribute(typeof(CustomerAttribute));
            //    Console.WriteLine($"{attribute.Description}_{attribute.Remark}");
            //    attribute.Show();
            //}

            //ParameterInfo parameter = methodInfo.GetParameters()[0];//get the attribute in input parameter
            //if (parameter.IsDefined(typeof(CustomerAttribute), true))
            //{
            //    CustomerAttribute attribute =
            //        (CustomerAttribute)parameter.GetCustomAttribute(typeof(CustomerAttribute));
            //    Console.WriteLine($"This is input Parameter");
            //    attribute.Show();
            //}
            //ParameterInfo returnParameter = methodInfo.ReturnParameter; //get the attribute in out parameter
            //if (returnParameter.IsDefined(typeof(CustomerAttribute), true))
            //{
            //    CustomerAttribute attribute =
            //        (CustomerAttribute)returnParameter.GetCustomAttribute(typeof(CustomerAttribute));
            //    Console.WriteLine($"This is Return Parameter");
            //    attribute.Show();
            //}

            #endregion

            //用customer attribute实现下自定的验证比如说长度大小
            s.Validate();
        }
    }
}
