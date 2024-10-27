using System;
using System.Collections.Generic;
using System.Text;
using MyOO.Interface;
using MyOO.Items;
using MyOO.Services;

namespace MyOO
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void UsePhone(BasePhone phone)
        {
            phone.Call();
        }
        public void PalyIphoe(iPhone phone)
        {
            Game game = new Game();
            phone.Game(game);
        }
    }
}
