using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelsee1
{
    internal class Student
    {
        public int SudentID;
        public string FirstName;
        public string Mellemnavn;
        public string LastName;

        public DateTime DateOfBirth { get; set; }

        public int Age { get; set; }



        public Student(int _StudentId, string _FirstName, string _LastName, DateTime _DateofBirth)
        {
            SudentID = _StudentId;
            FirstName = _FirstName;
            LastName = _LastName;
            DateOfBirth = _DateofBirth;
            Age = (int)(DateTime.Now - DateOfBirth).TotalDays / 365;


        }
        public override string ToString()  // ToString  gør at teksten kommer frem hver gang jeg kører programmet //
        {
            return +SudentID + FirstName + Mellemnavn + LastName + DateOfBirth.ToString("dd/MM/yyyy") + " Age:" + Age;



        }
    }
}
