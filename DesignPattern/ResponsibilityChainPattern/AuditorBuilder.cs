using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsibilityChainPattern
{
    public class AuditorBuilder
    {
        public static AbstractAuditor Build()
        {
            PM pm = new PM { Name = "PM" };
            AbstractAuditor l = new Lead { Name = "Lead" };
            AbstractAuditor m = new Manager { Name = "Manager" };
            AbstractAuditor ci = new Chief { Name = "Chief" };
            AbstractAuditor ceo = new CEO { Name = "CEO" };
            pm.SetNextAuditor(l);
            l.SetNextAuditor(m);
            m.SetNextAuditor(ci);
            ci.SetNextAuditor(ceo);
            return pm;
            //流程的配置： 反射+配置文件
        }
    }
}
