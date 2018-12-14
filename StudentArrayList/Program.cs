using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentArrayList
{
    class Program
    {
        public class Student
        {
            public string Name;
            public string Surname;
            public Stack Grades;
            public Student()
            {
                Grades = new Stack();
            }

        }
        static void Main(string[] args)
        {
            ArrayList students = new ArrayList();
            Student first = new Student() { Name = "John", Surname = "Johnski" };
            Student second = new Student() { Name = "Karla", Surname = "Kahoon" };
            Student third = new Student() { Name = "Dan", Surname = "Viesly" };
            first.Grades.Push("A");
            first.Grades.Push("A");
            first.Grades.Push("A");
            first.Grades.Push("C");
            first.Grades.Push("A");
            second.Grades.Push("B");
            second.Grades.Push("A");
            second.Grades.Push("A");
            second.Grades.Push("B");
            second.Grades.Push("B");
            third.Grades.Push("B");
            third.Grades.Push("C");
            third.Grades.Push("C");
            third.Grades.Push("B");
            third.Grades.Push("C");
            students.Add(first);
            students.Add(second);
            students.Add(third);
            foreach (Student s in students)
            {
                Console.WriteLine("Name = {0}, Surname = {1}", s.Name, s.Surname);
            }

        }
    }
}
