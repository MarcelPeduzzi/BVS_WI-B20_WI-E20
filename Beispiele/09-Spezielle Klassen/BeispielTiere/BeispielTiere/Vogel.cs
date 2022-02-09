using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp11
{
    public class Vogel : Tier
    {
        public Vogel(string name) : base(name)
        {
        }

        public void Fliegen()
        {
            Console.WriteLine("Fliegen");
        }

        public override void PrintTierTyp()
        {
            Console.WriteLine("Ich bin ein Vogel");
        }
    }
}