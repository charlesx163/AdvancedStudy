using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MyAttribute
{
    /// <summary>
    /// user state
    /// </summary>
    public enum UserState
    {
        [Remark("Normal")]
        Normal=0,
        Frozen=1,
        Deleted= 2
    }

    public class RemarkAttribute:Attribute
    {
        public RemarkAttribute(string remark)
        {
            this._Remark = remark;
        }

        public string GetRemark()
        {
            return this._Remark;
        }
        private string _Remark;
    }

    public static class RemarkExtension
    {
        public static string GetRemark(this Enum value)
        {
            Type type = value.GetType();
            FieldInfo filed=type.GetField(value.ToString());
            if(filed.IsDefined(typeof(RemarkAttribute),true))
            {
                RemarkAttribute attribute = (RemarkAttribute)filed.GetCustomAttribute(typeof(RemarkAttribute), true);
                return attribute.GetRemark();
            }
            else
            {
                return value.ToString();
            }
        }
    }
}
