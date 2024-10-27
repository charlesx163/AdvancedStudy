using System;
using System.Collections.Generic;
using System.Text;
using HomeWork0807.Interface;

namespace HomeWork0807
{
    public class NorthVentriloquist:AbstractVentriloquist,IFee
    {
        public override void ImitateDogBark()
        {
            Console.WriteLine("North Dog Barking");
        }

        public override void ImitatePeopleVice()
        {
            Console.WriteLine("North Speaking");
        }

        public override void ImitateSoundOfWind()
        {
            Console.WriteLine("North Wind");
        }

        public void CollectFee()
        {
            Console.WriteLine("North collects fee");
        }

        public override void ConcludingRemarks()
        {
            Console.WriteLine("Finally, [North]thanks for coming to our theater. See you again next time");
        }

        protected override void ShowUniSkillCore()
        {
            Console.WriteLine("North UniSkill");
        }
    }
}
