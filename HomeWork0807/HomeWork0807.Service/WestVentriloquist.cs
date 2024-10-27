using System;
using System.Collections.Generic;
using System.Text;
using HomeWork0807.Interface;

namespace HomeWork0807.Service
{
    public class WestVentriloquist:AbstractVentriloquist,IFee
    {
        private string _westThing;
        public string WestThing { get; set; }

        public void WestUniqueSkill()
        {
            Console.WriteLine("This is Unique Skill from West");
        }

        protected override void ShowUniSkillCore()
        {
            this.WestUniqueSkill();
        }

        public override void ImitateDogBark()
        {
            Console.WriteLine("West Dog Barking");
        }

        public override void ImitatePeopleVice()
        {
            Console.WriteLine("West Speaking");
        }

        public override void ImitateSoundOfWind()
        {
            Console.WriteLine("West Wind");
        }

        public void CollectFee()
        {
            Console.WriteLine("West collects fee");
        }

        public override void OpeningRemarks()
        {
            Console.WriteLine("Firstly, [West]welcome to our theater");
        }
        public override void ConcludingRemarks()
        {
            Console.WriteLine("Finally, [West]thanks for coming to our theater. See you again next time");
        }
    }
}
