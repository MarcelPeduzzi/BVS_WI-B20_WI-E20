using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp11
{
    public abstract class Tier
    {
        public Tier(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public int Farbe { get; set; }

        public abstract void PrintTierTyp();

        public void Fressen()
        {
            Console.WriteLine("Fressen");
        }
    }
}