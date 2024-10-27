using System;
using System.Collections.Generic;
using System.Text;
using HomeWork0807.Interface;

namespace HomeWork0807
{
    public class EastVentriloquist:AbstractVentriloquist,IFee
    {
        private string _eastThing;

        public string EastThing
        {
            get => _eastThing;
            set => _eastThing = value;
        }

        public void EastUniqueSkill()
        {
            Console.WriteLine("This is Unique Skill from East");
        }

        public void CollectFee()
        {
            Console.WriteLine("East collects fee");
        }

        protected override void ShowUniSkillCore()
        {
            Console.WriteLine("East UniSkill");
        }

        public override void ImitateDogBark()
        {
            Console.WriteLine("East Dog Barking");
        }

        public override void ImitatePeopleVice()
        {
            Console.WriteLine("East Speaking");
        }

        public override void ImitateSoundOfWind()
        {
            Console.WriteLine("East Wind");
        }
    }
}
