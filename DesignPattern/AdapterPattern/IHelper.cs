using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public interface IHelper
    {
        void Add<T>();
        void Delete<T>();
    }
}
