using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.BusinessLogic
{
    class StudentsPerCourseCSharp
    {
        protected internal static void PrintListOfStudentsInCSharpFullTime()
        {
            List<Student> studentsInCSharpFullTime = List.students.FindAll(student => student.StudentStream == "C#" && student.StreamType == "Full Time");
            foreach (var student in studentsInCSharpFullTime)
            {
                Console.WriteLine(student);
            }
        }

        protected internal static void PrintListOfStudentsInCSharpPartTime()
        {
            List<Student> studentsInCSharpPartTime = List.students.FindAll(student => student.StudentStream == "C#" && student.StreamType == "Part Time");
            foreach (var student in studentsInCSharpPartTime)
            {
                Console.WriteLine(student);
            }
        }

        protected internal static void PrintListOfStudentsInCSharpOnline()
        {
            List<Student> studentsInCSharpOnline = List.students.FindAll(student => student.StudentStream == "C#" && student.StreamType == "Online");
            foreach (var student in studentsInCSharpOnline)
            {
                Console.WriteLine(student);
            }
        }

        protected internal static void PrintListOfStudentsInCSharpHybridFullTime()
        {
            List<Student> studentsInCSharpHybridFullTime = List.students.FindAll(student => student.StudentStream == "C#" && student.StreamType == "Hybrid Full Time");
            foreach (var student in studentsInCSharpHybridFullTime)
            {
                Console.WriteLine(student);
            }
        }

        protected internal static void PrintListOfStudentsInCSharpHybridPartTime()
        {
            List<Student> studentsInCSharpHybridPartTime = List.students.FindAll(student => student.StudentStream == "C#" && student.StreamType == "Hybrid Part Time");
            foreach (var student in studentsInCSharpHybridPartTime)
            {
                Console.WriteLine(student);
            }
        }
    }
}
