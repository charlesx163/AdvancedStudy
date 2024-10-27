using System;
using System.Collections.Generic;

namespace Common
{
    public class CustomCache
    {
        private static Dictionary<string, object> _customDictionary;

        static CustomCache()
        {
            _customDictionary = new Dictionary<string, object>();
            Console.WriteLine($"{DateTime.Now:MM-dd HH:mm:ss} cache start");
        }

        public static void Add(string key, object value)
        {
            _customDictionary.Add(key,value);
        }
        public static void SaveOrAdd(string key, object value)
        {
            _customDictionary[key]=value;
        }
        public static T Get<T>(string key)
        {
            return  (T)_customDictionary[key];
        }

        public static bool Exist(string key)
        {
            return _customDictionary.ContainsKey(key);
        }

        public static T Find<T>(string key,Func<T> func)
        {
            T t = default(T);
            if (!Exist(key))
            {
                t = func.Invoke();
                _customDictionary.Add(key,t);
            }
            else
            {
                t = Get<T>(key);
            }

            return t;
        }
    }
}
