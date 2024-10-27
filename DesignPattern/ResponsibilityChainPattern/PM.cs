using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsibilityChainPattern
{
    public class PM : AbstractAuditor
    {
        public override void Audit(ApplyContext context)
        {
            Console.WriteLine($"This is PM:{this.Name} audit");
            if (context.Hour <= 8)
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
