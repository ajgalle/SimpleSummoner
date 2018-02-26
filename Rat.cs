using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSummoner
{
    
    class Rat : Monster
    {


        public Rat(string PetName) : base(PetName)
        {
            
            Console.WriteLine("Hi! My name is " + PetName+ " and I am a rat.");
            
        }


    }
}
