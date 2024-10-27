using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsibilityChainPattern
{
    public class Lead:AbstractAuditor
    {
        public override void Audit(ApplyContext context)
        {
            Console.WriteLine($"This is Lead:{this.Name} audit");
            if (context.Hour <= 16)
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
