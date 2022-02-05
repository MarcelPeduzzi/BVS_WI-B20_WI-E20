using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp11
{
    public class Schaf : LandSaeugetier
    {
        public Schaf(string name) : base(name)
        {
        }

        public void Grasen()
        {
            Console.WriteLine("Grasen");
        }

        public override void PrintTierTyp()
        {
            Console.WriteLine("Ich bin ein Schaf");
        }
    }
}