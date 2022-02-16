using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunktionen
{
    class Program
    {
        static void Main(string[] args)
        {
            const string sText = "  > Hallo vom C#-Buch V2.0!   ";

            Console.WriteLine(sText);
            Console.WriteLine(sText.Length);

            Console.WriteLine();

            // Konvertierungs-Funktionen
            Console.WriteLine(sText.ToLower());
            Console.WriteLine(sText.ToUpper());
            Console.WriteLine(sText.Trim());

            Console.WriteLine();

            // Trennungs-Funktionen
            Console.WriteLine(sText.Split(' ').Length);
            Console.WriteLine(sText.Split(new string[] { " ", "-" }, StringSplitOptions.RemoveEmptyEntries).Length);
            Console.WriteLine(sText.Substring(4, 5));

            Console.WriteLine();

            // Such-Funktionen
            Console.WriteLine(sText.IndexOf(' '));
            Console.WriteLine(sText.LastIndexOf(' '));

            Console.WriteLine();

            // Prüf-Funktionen (gibt true oder false zurück)
            Console.WriteLine(sText.Contains("hallo")); // wird nicht gefunden (mit "Hallo" wäre es gefunden worden)
            Console.WriteLine(sText.StartsWith("C"));
            Console.WriteLine(sText.EndsWith("!"));

            Console.WriteLine();

            // Veränderungs-Funktionen
            Console.WriteLine(sText.Insert(24, "1"));   // aus V2.0 wird V2.10
            Console.WriteLine(sText.Remove(9, 4));      // entfernt "vom"

            Console.ReadKey();
        }
    }
}
