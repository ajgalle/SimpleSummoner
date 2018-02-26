using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSummoner
{
    class Program
    {
        static void Main(string[] args)
        {
            var PetName = "";
            Monster[] Zoo = { };

            while (PetName.ToLower() != "quit")
            { 
                Console.WriteLine("Hello, summoner.  What do you want to name your pet? Or, just type 'quit' to quit");

                PetName = Console.ReadLine();               

                Monster pet = new Monster(PetName);

                Console.WriteLine("I will add him to your deck.");
                
                
                

            }

            Console.WriteLine("Good bye.");

        }
    }
}
