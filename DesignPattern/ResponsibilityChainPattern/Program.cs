using System;

namespace ResponsibilityChainPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplyContext context = new ApplyContext
            {
                Hour = 30,
                Name = "Honda"
            };
            {
                //在这里可以增加减少环节，调整顺序
                //PM pm = new PM {Name = "PM"};
                //AbstractAuditor l = new Lead { Name = "Lead" };
                //AbstractAuditor m = new Manager { Name = "Manager" };
                //AbstractAuditor ci = new Chief { Name = "Chief" };
                //AbstractAuditor ceo = new CEO { Name = "CEO" };
                //pm.SetNextAuditor(l);
                //l.SetNextAuditor(m);
                //m.SetNextAuditor(ci);
                //ci.SetNextAuditor(ceo);
                //pm.Audit(context);

            }
            {
                AbstractAuditor abstractAuditor = AuditorBuilder.Build();
                abstractAuditor.Audit(context);
            }
            if (context.Result)
            {
                Console.WriteLine("Audit successfully");
            }
            Console.WriteLine("Hello World!");
        }
    }
}
