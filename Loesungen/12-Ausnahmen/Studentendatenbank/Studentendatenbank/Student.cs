using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Studentendatenbank
{
    public class Student : IStudentFunktionen
    {
        public string Name { get; set; }
        public string Vorname { get; set; }
        public int MartrikelNr { get; set; }
        public DateTime Geburtsdatum { get; set; }

        public Student()
        { }

        public Student(string name, string vorname, int martrikelNr, DateTime geburtsdatum)
        {
            this.Name = name;
            this.Vorname = vorname;
            this.MartrikelNr = martrikelNr;
            this.Geburtsdatum = geburtsdatum;
        }

        public void PrintMe()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Vorname: {Vorname}");
            Console.WriteLine($"MartrikelNr: {MartrikelNr}");
            Console.WriteLine($"Geburtsdatum: {Geburtsdatum.ToString("dd.MM.yyyy")}");
        }
    }
}
