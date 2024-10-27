using System;
using System.Collections.Generic;
using System.Text;

namespace MyReflection
{
    public class GenericMethod
    {
        public static TDestination Map<TDestination,TSource>(TSource source,TDestination destination)
        {
            Type typeSource = source.GetType();
            Type typeDestination = destination.GetType();
            var destinationDto = Activator.CreateInstance(typeDestination);
            foreach (var prop in typeDestination.GetProperties())
            {
                object value = typeSource.GetProperty(prop.Name).GetValue(source);
                prop.SetValue(destinationDto,value);
            }
            return (TDestination)destinationDto;
        }
    }
}
