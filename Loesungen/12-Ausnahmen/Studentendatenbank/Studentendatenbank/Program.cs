using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentendatenbank
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Aufgabe 1

            Console.WriteLine();
            Console.WriteLine("************ Aufgabe 1 **************");

            Student student1 = new Student();

            student1.Name = "Rüdiger";
            student1.Vorname = "Karl-Heinz";
            student1.Geburtsdatum = new DateTime(1980, 4, 17);
            student1.MartrikelNr = 1;

            Ausgabe(student1);

            #endregion

            #region Aufgabe 2

            Console.WriteLine();
            Console.WriteLine("************ Aufgabe 2 **************");

            Student student2 = new Student("Dieter", "Bohlen", 2, new DateTime(1965, 3, 12));

            Ausgabe(student2);

            #endregion

            #region Aufgabe 3

            Console.WriteLine();
            Console.WriteLine("************ Aufgabe 3 **************");

            Student student3 = new Student("Murray", "Bill", 3, new DateTime(1962, 5, 30));
            student3.PrintMe();

            Console.ReadKey(true);

            #endregion

            #region Aufgabe 4

            Console.WriteLine();
            Console.WriteLine("************ Aufgabe 4 **************");

            Random random = new Random();
            Student[] studenten = new Student[100];

            for (int i = 0; i < studenten.Length; i++)
            {
                studenten[i] = new Student($"Name{i}", $"Vorname{i}", random.Next(), new DateTime(1982, 4, 12));
            }

            foreach (var student in studenten)
            {
                student.PrintMe();
            }

            Console.ReadKey(true);
            #endregion

            #region Aufgabe 5       

            Console.WriteLine();
            Console.WriteLine("************ Aufgabe 5 **************");

            StudentDatabase studentDatabase = new StudentDatabase(3);

            try
            {
                studentDatabase.AddStudent("Name1", "Vorname1", 1, new DateTime(1990, 12, 12));
                studentDatabase.AddStudent("Name2", "Vorname2", 2, new DateTime(1991, 12, 12));
                studentDatabase.AddStudent("Name3", "Vorname3", 3, new DateTime(1992, 12, 12));
                studentDatabase.AddStudent("Name4", "Vorname4", 4, new DateTime(1993, 12, 12));
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine($"!!!!! Fehler: {ex.Message}");
            }

            studentDatabase.PrintMe();

            Console.ReadKey();

            #endregion

            #region Aufgabe 6       

            Console.WriteLine();
            Console.WriteLine("************ Aufgabe 6 **************");

            Console.WriteLine("Studenten vor dem löschen:");
            studentDatabase.PrintMe();

            studentDatabase.DeleteStudent(3);

            Console.WriteLine("Studenten nach dem löschen:");
            studentDatabase.PrintMe();

            Console.ReadKey(true);

            #endregion

            #region Aufgabe 7

            Console.WriteLine();
            Console.WriteLine("************ Aufgabe 7 **************");

            Console.WriteLine($"Anzahl Studenten: {studentDatabase.NumberOfStudents()}");

            Console.ReadKey(true);
            #endregion
        }

        private static void Ausgabe(Student student)
        {
            Console.WriteLine($"Name: {student.Name}"); Console.WriteLine($"Vorname: {student.Vorname}"); Console.WriteLine($"MartrikelNr: {student.MartrikelNr}");
            Console.WriteLine($"Geburtsdatum: {student.Geburtsdatum.ToString("dd.MM.yyyy")}");

            Console.ReadKey(true);
        }
    }
}
