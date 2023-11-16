using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Большие_Гонки 
{
    internal class Team
    {
        public string Country { get; set; }

        public Team(string country)
        {
            this.Country = country;
        }
        public void PlayGame(IGame game)
        {
            game.Play();
        }
    }
}
