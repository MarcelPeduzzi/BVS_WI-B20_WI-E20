using System;

namespace AutoInputSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto bmw = new Auto();

            Console.Write("Farbe eingeben: ");
            bmw.Farbe= Console.ReadLine();
            Console.Write("Aufbauart eingeben: ");
            bmw.Aufbauart = Console.ReadLine();
            Console.Write("PS eingeben: ");

            bool success = int.TryParse(Console.ReadLine(), out int ps);
            if (success==true)
            {
                bmw.Ps = ps;
            }
            else
            {
                Console.WriteLine("Ps muss eine Zahl sein.");
            }

            Console.WriteLine(bmw.Farbe);
            Console.WriteLine(bmw.Ps);
            Console.WriteLine(bmw.Aufbauart);

            bmw.Fahren();
        }
    }


    class Auto
    {

        // Eigenschaften
        public string Farbe { get; set; }
        public string Aufbauart { get;  set; }
        public int Ps { get; set; }

        // Funktionen/Methoden
        public void Fahren()
        {
            Console.WriteLine("Auto ist am fahren.");
        }

        public void Bremsen()
        {
            Console.WriteLine("Auto bremst.");
        }

        public void BlinkenLinks()
        {
            Console.WriteLine("Auto blinkt links");
        }





    }


}
