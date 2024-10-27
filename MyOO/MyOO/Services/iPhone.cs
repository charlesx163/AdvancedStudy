using System;
using System.Collections.Generic;
using System.Text;
using MyOO.Interface;
using MyOO.Items;

namespace MyOO.Services
{
    public class iPhone:BasePhone,IExtend
    {
        public override void System()
        {
            Console.WriteLine($"{this.GetType().Name} system is iOS");
        }
        public void Game(Game game)
        {
            game.Start();
            game.Play();
        }

        public void Video()
        {
            Console.WriteLine($"{this.GetType().Name} Video");
        }
    }
}
