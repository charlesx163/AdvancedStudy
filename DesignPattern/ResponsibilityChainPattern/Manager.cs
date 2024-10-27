using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsibilityChainPattern
{
    public class Manager:AbstractAuditor
    {
        public override void Audit(ApplyContext context)
        {
            Console.WriteLine($"This is Manager:{this.Name} audit");
            if (context.Hour <= 24)
            {
                context.Result = true;
                context.Remark = "enjoy your vacation";
            }
            else
            {
                base.AuditNext(context);
            }
        }
    }
}
