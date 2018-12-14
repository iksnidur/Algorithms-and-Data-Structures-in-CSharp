using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        class Student
        {
            public Student(string first, string last, int age, string prog)
            {
                this.FirstName = first;
                this.LastName = last;
                this.Age = age;
                this.Program = prog;
            }

            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Program { get; set; }
            //public Stack<string> Grades = new Stack<string>();
            public List<string> Grades = new List<string>();
        }
        static void Main(string[] args)
        {
            // Create a Generic List of type Student
            List<Student> students = new List<Student>();
            Student stud1 = new Student("Tom", "Thumb", 12, "Computer Science");
            Student stud2 = new Student("Fred", "Flintstone", 45, "Geology");
            Student stud3 = new Student("Mickey", "Mouse", 35, "Animation");
            //stud1.Grades.Push("A");
            //stud1.Grades.Push("A");
            //stud1.Grades.Push("A");
            //stud1.Grades.Push("C");
            //stud1.Grades.Push("A");
            //stud2.Grades.Push("B");
            //stud2.Grades.Push("A");
            //stud2.Grades.Push("A");
            //stud2.Grades.Push("B");
            //stud2.Grades.Push("B");
            //stud3.Grades.Push("B");
            //stud3.Grades.Push("C");
            //stud3.Grades.Push("C");
            //stud3.Grades.Push("B");
            //stud3.Grades.Push("C");
            stud1.Grades.Add("A");
            stud1.Grades.Add("A");
            stud1.Grades.Add("A");
            stud1.Grades.Add("C");
            stud1.Grades.Add("A");
            stud2.Grades.Add("B");
            stud2.Grades.Add("A");
            stud2.Grades.Add("A");
            stud2.Grades.Add("B");
            stud2.Grades.Add("B");
            stud3.Grades.Add("B");
            stud3.Grades.Add("C");
            stud3.Grades.Add("C");
            stud3.Grades.Add("B");
            stud3.Grades.Add("C");
            students.Add(stud1);
            students.Add(stud2);
            students.Add(stud3);
            foreach (Student stud in students)
            {
                Console.WriteLine(stud.FirstName+" " +stud.LastName);
            }
            //stud1.Grades.Pop();
            //stud1.Grades.Push("D");
            //stud2.Grades.Pop();
            //stud2.Grades.Push("D");
            //stud3.Grades.Pop();
            //stud3.Grades.Push("D");
            stud1.Grades.Sort();
            stud2.Grades.Sort();
            stud3.Grades.Sort();
            bool exists = students.Contains<Student>(stud1);
            Console.WriteLine(exists.ToString());
            students.Remove(stud3);
            Console.WriteLine(students.Count());
            exists = students.Contains<Student>(stud3);
            Console.WriteLine(exists.ToString());
            foreach (Student stud in students)
            {
                Console.Write("\n"+stud.FirstName + " " + stud.LastName);
                foreach (var g in stud.Grades)
                {
                    Console.Write(" "+g);
                }
            }
        }
    }
}
