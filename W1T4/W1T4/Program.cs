using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1T4
{
    class Student
    {
        string FirstName;
        string LastName;
        double GPA;

        public Student(string FirstName, string LastName, double GPA)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.GPA = GPA;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + GPA;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add new student");
            string s = Console.ReadLine();
            string[] sts = s.Split(' ');
            Console.WriteLine("You have added: ");
            Student a = new Student(sts[0], sts[1], double.Parse(sts[2]));
            Console.WriteLine(a);
        }
    }
}
