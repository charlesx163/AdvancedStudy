using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MyAttribute
{
    public static class ValidateExtension
    {
        public static bool Validate<T>(this T t)
        {
            Type type = t.GetType();
            foreach (var prop in type.GetProperties())
            {
                #region 没有抽象
                //if (prop.IsDefined(typeof(LongAttribute), true))
                //{
                //    LongAttribute attribute = (LongAttribute)prop.GetCustomAttribute(typeof(LongAttribute));
                //    if (!attribute.Validate(prop.GetValue(t)))
                //    {
                //        Console.WriteLine($"{prop.Name} is not suit the case");
                //        return false;
                //    }
                //    else
                //    {
                //        Console.WriteLine($"{prop.Name} is suit the case");
                //        return true;
                //    }
                //}
                //if (prop.IsDefined(typeof(LengthAttribute), true))
                //{
                //    LengthAttribute attribute = (LengthAttribute)prop.GetCustomAttribute(typeof(LengthAttribute));
                //    if (!attribute.Validate(prop.GetValue(t)))
                //    {
                //        Console.WriteLine($"{prop.Name} is not suit the case");
                //        return false;
                //    }
                //    else
                //    {
                //        Console.WriteLine($"{prop.Name} is suit the case");
                //        return true;
                //    }
                //}

                #endregion

                #region 加抽象

                if (prop.IsDefined(typeof(AbstractValidationAttribute), true))
                {
                    object[] attributeArray = prop.GetCustomAttributes(typeof(AbstractValidationAttribute), true);//一个属性上可能有多个自定义attribute
                    foreach (AbstractValidationAttribute attribute in attributeArray)
                    {
                        if (!attribute.Validate(prop.GetValue(t)))
                        {
                            return false;
                        }
                    }
                    
                }

                #endregion
            }
            return true;
        }
    }

    public abstract class AbstractValidationAttribute : Attribute
    {
        public abstract bool Validate(object value);
    }

    public class LongAttribute : AbstractValidationAttribute
    {
        private long _Min = 0;
        private long _Max = 0;

        public LongAttribute(long min, long max)
        {
            this._Min = min;
            this._Max = max;
        }

        public override bool Validate(object value)
        {
            if (value != null && !string.IsNullOrWhiteSpace(value.ToString()))
            {
                if (long.TryParse(value.ToString(), out long lResult))
                {
                    if (lResult > this._Min && lResult < this._Max)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

    }

    public class LengthAttribute : AbstractValidationAttribute
    {
        private int _Min = 0;
        private int _Max = 0;

        public LengthAttribute(int min, int max)
        {
            this._Min = min;
            this._Max = max;
        }

        public override bool Validate(object value)
        {
            if (value != null && !string.IsNullOrWhiteSpace(value.ToString()))
            {
                int length = value.ToString().Length;
                if (length > this._Min && length < this._Max)
                {
                    return true;
                }
            }
            return false;
        }

    }

}
