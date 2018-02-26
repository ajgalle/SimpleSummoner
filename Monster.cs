using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSummoner
{
    class Monster
    {
        private static readonly Random _random = new Random();

        const double ChanceOfOrc = .25;


        public Monster(string PetName)
        {
            if (_random.NextDouble() < ChanceOfOrc)
                {
                    Orc orc = new Orc(); 
                } else
                {
                    Rat rat = new Rat(PetName);
                };
            
        }
    }
}
