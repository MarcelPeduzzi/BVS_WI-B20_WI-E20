using System;
using System.IO;

namespace UebungFileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            // File lesen und auf Console ausgeben
            string file = @"C:\Temp\Filehandling\Testdatei.txt";

            string[] lines;
            lines = File.ReadAllLines(file);

            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }

            // Erstellen eines Directory
            Directory.CreateDirectory(@"C:\Temp\Filehandling\TestVerzeichnis");

            // File verschieben
            // File.Move(@"C:\Temp\Filehandling\Testdatei.txt", @"C:\Temp\Filehandling\TestVerzeichnis\Testdatei.txt");



            // Zusatz
            var personList = new PersonList();

            // Liste abfüllen mittels string[]
            personList.FillUp(lines);

            // List auf Console drucken
            personList.Print();

            // neue Person der Liste hinzufügen
            personList.Add(new Person("Knöpfli", "Hansli")
            {
                Strasse = "Hüetliweg",
                HausNr = "12",
                Plz = "9000",
                Ort = "St.Gallen"
            });

            // Liste auf Filesystem speichern
            personList.Save(@"c:\temp\neu.txt");
        }

        
    }
}
