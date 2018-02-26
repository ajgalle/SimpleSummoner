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
            string userEntry="";
            const int GoldToStartTheGameWith = 1000;

            Shop shop = new Shop(GoldToStartTheGameWith);
            Library library = new Library();


            while (userEntry.ToLower() != "b")
            {

                Console.WriteLine("Hello, summoner. What would you like to do today? ");
                Console.WriteLine("A. Buy some packs to get more creature cards.");
                Console.WriteLine("B. View my collection and may deck.");
                Console.WriteLine("C. Quit");


                try
                {
                    userEntry = Console.ReadLine();

                    if (userEntry.ToLower() == "a")
                    {
                        shop.BuyPacks();
                    }

                    else if (userEntry.ToLower() == "b")
                    {
                        library.ShowLibrary();
                    } 
                 

                }
                catch (Exception ex)
                {
                    
                    Console.WriteLine("I'm sorry, I didn't understand you.  Please try again.");
                    Console.WriteLine("The system said you did this: " + ex);

                }
            


                
                

            }

            Console.WriteLine("Good bye.");

        }
    }
}
