using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsibilityChainPattern
{
    public abstract class AbstractAuditor
    {
        public string Name { get; set; }
        private AbstractAuditor _auditor;
        public void SetNextAuditor(AbstractAuditor abstractAuditor)
        {
            _auditor = abstractAuditor;
        }

        public abstract void Audit(ApplyContext context);

        protected void AuditNext(ApplyContext context)
        {
            _auditor?.Audit(context);
        }
    }
}
