using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelsee1
{
    internal class Teacher
    {
        public int Department;
        public string FName;
        public string LName;
        public DateTime birth { get; set; }

        public int Age { get; set; }



        public Teacher(int department, string fName, string lName, DateTime _birth)
        {
            Department = department;
            FName = fName;
            LName = lName;
            birth = _birth;
            Age = (int)(DateTime.Now - birth).TotalDays / 365;

        }
        public override string ToString()  // ToString  gør at teksten kommer frem hver gang jeg kører programmet //
        {
            return Department + FName + LName + birth.ToString("dd/MM/yyyy") + " Age:" + Age;
        }
    }
}
