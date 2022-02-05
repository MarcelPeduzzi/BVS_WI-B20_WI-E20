using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp11
{
    public class Tiger : LandSaeugetier
    {
        public Tiger(string name) : base(name)
        {
        }

        public void Jagen()
        {
            Console.WriteLine("Jagen");
        }

        public override void PrintTierTyp()
        {
            Console.WriteLine("Ich bin ein Tiger");
        }
    }
}