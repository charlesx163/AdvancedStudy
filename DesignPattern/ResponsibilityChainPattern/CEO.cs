using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsibilityChainPattern
{
    public class CEO:AbstractAuditor
    {
        public override void Audit(ApplyContext context)
        {
            Console.WriteLine($"This is CEO:{this.Name} audit");
            if (context.Hour <= 64)
            {
                context.Result = true;
                context.Remark = "enjoy your vacation";
            }
            else
            {
                context.Result = false;
                context.Remark = "reject you apply";
            }
        }
    }
}
