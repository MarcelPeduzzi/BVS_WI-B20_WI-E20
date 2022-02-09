using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp11
{
    public abstract class LandSaeugetier : Tier
    {
        protected LandSaeugetier(string name) : base(name)
        {
        }

        public void Laufen()
        {
            Console.WriteLine("Laufen");
        }
    }
}