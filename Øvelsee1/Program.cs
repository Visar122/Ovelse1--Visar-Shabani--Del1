using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelsee1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(001, "- Alexander", " Runge ", new DateTime(2003, 08, 08));
            s1.Mellemnavn = " M.H ";


            Student s2 = new Student(002, "- Alexander", " Runge ", new DateTime(2001, 09, 02));
            s2.Mellemnavn = " M.H ";
            Student s3 = new Student(003, "- Alexander", " Runge ", new DateTime(2004, 10, 09));
            s3.Mellemnavn = " M.H ";

            Student s4 = new Student(004, "- Amanda", " Gudmand ", new DateTime(1999, 02, 08));
            s4.Mellemnavn = " Elisabeth Vang";
            Student s5 = new Student(005, "- Amanda ", " Gudmand ", new DateTime(1999, 02, 08));
            s5.Mellemnavn = " Elisabeth Vang ";
            Student s6 = new Student(006, "- Amanda ", " Gudmand ", new DateTime(1999, 02, 08));
            s6.Mellemnavn = " Elisabeth Vang";

            Student s7 = new Student(007, "- Denis", " Paaske ", new DateTime(2000, 10, 08));
            s7.Mellemnavn = " Daniel B";
            Student s8 = new Student(008, "- Denis", " Paaske ", new DateTime(2000, 10, 08));
            s8.Mellemnavn = " Daniel B";
            Student s9 = new Student(009, "- Denis", " Paaske ", new DateTime(2000, 10, 08));
            s9.Mellemnavn = " Daniel ";

            Student s10 = new Student(010, "- Ozan", " Korkmaz ", new DateTime(1997, 01, 01));
            Student s11 = new Student(011, "- Ozan", " Korkmaz ", new DateTime(1997, 01, 01));

            Student s12 = new Student(012, "- Camilla", "Kløjgaard ", new DateTime(1998, 02, 02));
            Student s13 = new Student(013, "- Camilla", "Kløjgaard ", new DateTime(1998, 09, 02));

            Teacher t1 = new Teacher(1, "- Niels", " Olsen ", new DateTime(1996, 04, 01));
            Teacher t2 = new Teacher(10, "- Niels", " Olsen ", new DateTime(1996, 04, 01));
            Teacher t3 = new Teacher(20, "- Niels", " Olsen ", new DateTime(1996, 04, 01));

            Course fag1 = new Course("StudieTek");
            Course fag2 = new Course("Grprog");
            Course fag3 = new Course("OOP");

            Console.WriteLine($"\n{s1} ,  fag: {fag1}, lærer:{t1}");
            Console.WriteLine($"{s2}   ,  fag: {fag2}, lærer:{t2}");
            Console.WriteLine($"{s3}   ,  fag: {fag3}, lærer:{t3}");

            Console.WriteLine($"\n{s4} ,  fag: {fag1}, lærer:{t1}");
            Console.WriteLine($"{s5}   ,  fag: {fag2}, lærer:{t2}");
            Console.WriteLine($"{s6}   ,  fag: {fag3}, lærer:{t3}");

            Console.WriteLine($"\n{s7} ,  fag: {fag1}, lærer:{t1}");
            Console.WriteLine($"{s8}   ,  fag: {fag2}, lærer:{t2}");
            Console.WriteLine($"{s9}   ,  fag: {fag3}, lærer:{t3}");

            Console.WriteLine($"\n{s10} ,  fag: {fag2}, lærer:{t2}");
            Console.WriteLine($"{s11}   ,  fag: {fag3}, lærer:{t3}");

            Console.WriteLine($"\n{s12} ,  fag: {fag2}, lærer:{t2}");
            Console.WriteLine($"{s13}   ,  fag: {fag3}, lærer:{t3}");



            Console.ReadLine();
        }
    }
}
