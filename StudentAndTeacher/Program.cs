using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndTeacher
{
    struct Student
    {
        public string Name;
        public string Surname;

        public void Study()
        {
            Console.WriteLine("Student is studying");
        }
    }
    struct Teacher
    {
        public string Name;
        public string Surname;
        public string Subject;

        public void GradeAssignment()
        {
            Console.WriteLine("Teacher is grading");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];

            students[0].Name = "Adam";
            students[0].Surname = "Adamski";
            Console.WriteLine("Student name is {0} {1}", students[0].Name, students[0].Surname);
            students[0].Study();
            
            for (int i = 1; i < students.Length; i++)
            {
                students[i].Name = "Adam" + i;
                students[i].Surname = "Adamski" + i;
            }

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Student name is {0} {1}", students[i].Name, students[i].Surname);
            }

            Console.ReadLine();
        }
    }
}
