using System;
using System.Collections.Generic;
using System.IO;

namespace UebungFileHandling
{
    internal class PersonList
    {
        // set auf Private damit diese Liste nur innerhabl dieser Klasse
        // befüllt werden kann
        public List<Person> personenListe { get; private set; } = new List<Person>();


        // overloading FillUp
        public void FillUp(string filePath)
        {
           var lines = File.ReadAllLines(filePath);
           FillUp(lines);
        }

        // overloading FillUp
        public void FillUp(string[] lines)
        {
            // Zuerst löschen
            personenListe.Clear();

            // jetzt abfüllen
            foreach (string line in lines)
            {
                personenListe.Add(new Person(line));
            }
        }

        // List auf Console ausgeben
        public void Print()
        {
            foreach (Person person in personenListe)
            {
                person.Print();
            }
        }

        // Speicher in ein File
        public void Save(string filePath)
        {
            string[] stringArray = new string[personenListe.Count];

            int i = 0;
            foreach(Person person in personenListe)
            {
                stringArray[i++] = person.ToString();
            }
            File.WriteAllLines(filePath, stringArray);
        }

        // Person hinzufügen
        public void Add(Person person)
        {
            personenListe.Add(person);
        }
    }
}
