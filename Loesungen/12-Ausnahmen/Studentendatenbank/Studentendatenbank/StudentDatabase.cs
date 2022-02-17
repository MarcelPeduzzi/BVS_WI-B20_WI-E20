using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentendatenbank
{
    public class StudentDatabase : IStudentFunktionen
    {
        private Student[] _students;

        public StudentDatabase(int groesse)
        {
            _students = new Student[groesse];
        }

        public void PrintMe()
        {
            foreach (var student in _students)
            {
                student?.PrintMe();
            }
        }

        public void AddStudent(string name, string vorname, int martrikelNr, DateTime geburtsdatum)
        {
            bool freierPlatzGefunden = false;

            // Der erste freie Platz im Array suchen
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i] == null)
                {
                    _students[i] = new Student(name, vorname, martrikelNr, geburtsdatum);
                    freierPlatzGefunden = true;
                    break;
                }
            }

            if (freierPlatzGefunden == false)
                throw new ApplicationException("Kein Platz mehr in der Datenbank");
        }

        public void DeleteStudent(int martrikelNr)
        {
            for (int i = 0; i < _students.Length; i++)
            {
                if (_students[i] != null && _students[i].MartrikelNr == martrikelNr)
                // andere schreibweise
                // if (_students[i]?.MartrikelNr == martrikelNr)
                {
                    _students[i] = null;
                }
            }
        }

        public int NumberOfStudents()
        {
            int zaehler = 0;

            foreach (var student in _students)
            {
                if (student != null)
                {
                    zaehler++;
                }
            }
            return zaehler;
        }
    }
}
