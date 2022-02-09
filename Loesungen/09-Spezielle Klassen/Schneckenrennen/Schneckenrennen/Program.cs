using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schneckenrennen
{
    class Program
    {
        static void Main(string[] args)
        {
            Rennen rennen = new Rennen("Master of Schleim", 1000);
            rennen.AddRennschnecke(new Rennschnecke("Harald", "Powerschnecke", 80));
            rennen.AddRennschnecke(new Rennschnecke("Kevin", "Powerschnecke", 80));
            
            rennen.AddRennschnecke(new Rennschnecke("Eveline", "Turboschnecke", 80));
            rennen.AddRennschnecke(new Rennschnecke("Gertrud", "Turboschnecke", 80));

            Console.WriteLine(rennen.ToString());
            Console.ReadKey(true);

            rennen.Durchfuehren();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************Gewinner***************");
            Console.WriteLine(rennen.ErmittleGewinner());
            Console.WriteLine("************************************");
            Console.ResetColor();
            rennen.Zuruecksetzen();
            Console.ReadKey(true);

        }
    }
}
