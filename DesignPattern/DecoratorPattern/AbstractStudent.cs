using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class AbstractStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public abstract void Study();
    }
}
