using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork0807.Interface
{
    public abstract class AbstractVentriloquist
    {
        public string Person { get; set; }
        public string Desk { get; set; }
        public string Chair { get; set; }
        public string Fan { get; set; }
        public string Ruler { get; set; }
        public event Action FireOn;
        protected Func<int, bool> JudgeFunc = t => t > 400;
        public void SetTempreature(int temperature)
        {
            if (JudgeFunc(temperature))
            {
                FireOn?.Invoke();
            }
        }
       public void ShowUniSkill()
        {
            Console.WriteLine("UniSkill is begin");
            this.ShowUniSkillCore();
            Console.WriteLine("UniSkill is end");
        }

        protected abstract void ShowUniSkillCore();
        public void Play()
        {
            Console.WriteLine("The perform is start");
        }

        public abstract void ImitateDogBark();
        public abstract void ImitatePeopleVice();
        public abstract void ImitateSoundOfWind();

        public virtual void OpeningRemarks()
        {
            Console.WriteLine("Firstly, welcome to our theater");
        }

        public virtual void ConcludingRemarks()
        {
            Console.WriteLine("Finally, thanks for coming to our theater. See you again next time");
        }
    }
}
