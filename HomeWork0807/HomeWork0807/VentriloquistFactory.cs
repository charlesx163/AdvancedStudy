using System;
using System.Collections.Generic;
using System.Text;
using HomeWork0807.Interface;

namespace HomeWork0807
{
    public class VentriloquistFactory
    {
        public static T CreateVentriloquist<T>() where T: AbstractVentriloquist,IFee
        {
            Type t = typeof(T);
            var o = (T) Activator.CreateInstance(t);
            foreach (var prop in t.GetProperties())
            {
                Console.WriteLine($"PropName:{prop.Name}");
            }
            foreach (var field in t.GetFields())
            {
                Console.WriteLine($"FieldName:{field.Name}");
            }
            return o;
        }
    }
}
