using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UDatentypen_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Marcel";
            string lastName = "Peduzzi";
            string street = "Dorfstrasse 21";
            string plz = "9306";
            string location = "Freidorf";
            int age = 49;
            decimal salary = 5000;

            Console.WriteLine("Adresse:");
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine(street);
            Console.WriteLine(plz + " " + location);
            Console.WriteLine();
            Console.WriteLine("Alter: " + age);
            Console.WriteLine("Gehalt: " + salary);

            Console.ReadKey(false);
        }
    }
}
