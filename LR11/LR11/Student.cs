using System;
using System.Collections.Generic;
using System.Text;

namespace LR11
{
    delegate bool StudentPredicateDelegate(Student student);
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int age { get; set; }

        public Student(string fistName, string lastName, int Age)
        {
            this.FirstName = fistName;
            this.LastName = lastName;
            this.age = Age;
        }

        public static bool Vozrast(Student student)
        {
            if (student.age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool First(Student student)
        {
            if (student.FirstName[0] == 'A') return true;
            else
            {
                return false;
            }
        }

        public static bool First_Symbols(Student student)
        {
            if (student.LastName.Length > 3) { return true; }
            else
            {
                return false;
            }
        }
    }
}
