using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSummoner
{
    class Shop
    {
        const double ChanceForDragon = .1;
        const double ChanceForOrc = .25;
        const int CostPerPack = 10;

        private int _gold;

        
        public Shop(int GoldToStartTheGameWith)
        {
            _gold = GoldToStartTheGameWith;
        }

        public void BuyPacks()
        {
            try
            {
                Console.WriteLine("Welcome to the shop. You have " + _gold + ". Each pack is " + CostPerPack + " gold. How many packs would you like to buy?");
                int PacksToBuy = int.Parse(Console.ReadLine());
                _gold -= (10 * PacksToBuy);

                for (int i = 0; i <= PacksToBuy; i++)
                {
                    // Using Random, let's see what Monster is in this pack.
                    Random random = new Random();

                    if (random.Next() < ChanceForOrc)
                        {
                        Console.WriteLine("You got an orc!");
                        // When an orc is created, its constructor will it add it to the library.
                        Orc orc = new Orc();

                        }
                    else if (random.Next() < ChanceForDragon)
                        { 
                        Console.WriteLine("You got a Dragon!");
                        Dragon dragon = new Dragon();
                        }
                    else
                       {
                        Console.WriteLine("You got a rat.");
                        Rat rat = new Rat();
                        }

                }

            }
            catch
            {
                Console.WriteLine("I'm sorry, I didn't understand you.");
            }
        }



    }
}
