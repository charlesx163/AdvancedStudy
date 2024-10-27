using System;
using System.Collections.Generic;
using System.Text;
using HomeWork0807.Interface;

namespace HomeWork0807
{
    public class SouthVentriloquist:AbstractVentriloquist,IFee
    {
        public override void ImitateDogBark()
        {
            Console.WriteLine("South Dog Barking");
        }

        public override void ImitatePeopleVice()
        {
            Console.WriteLine("South Speaking");
        }

        public override void ImitateSoundOfWind()
        {
            Console.WriteLine("South Wind");
        }

        public void CollectFee()
        {
            Console.WriteLine("South collects fee");
        }

        public override void OpeningRemarks()
        {
            Console.WriteLine("Firstly, [South]welcome to our theater");
        }

        protected override void ShowUniSkillCore()
        {
            Console.WriteLine("South UniSkill");
        }
    }
}
