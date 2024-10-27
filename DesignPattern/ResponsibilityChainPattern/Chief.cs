using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsibilityChainPattern
{
    public class Chief:AbstractAuditor
    {
        public override void Audit(ApplyContext context)
        {
            Console.WriteLine($"This is Chief:{this.Name} audit");
            if (context.Hour <= 32)
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
