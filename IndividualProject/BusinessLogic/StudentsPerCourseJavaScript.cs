using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.BusinessLogic
{
    class StudentsPerCourseJavaScript
    {
        protected internal static void PrintListOfStudentsInJavaScriptFullTime()
        {
            List<Student> studentsInJavaScriptFullTime = List.students.FindAll(student => student.StudentStream == "JavaScript" && student.StreamType == "Full Time");
            foreach (var student in studentsInJavaScriptFullTime)
            {
                Console.WriteLine(student);
            }
        }

        protected internal static void PrintListOfStudentsInJavaScriptPartTime()
        {
            List<Student> studentsInJavaScriptPartTime = List.students.FindAll(student => student.StudentStream == "JavaScript" && student.StreamType == "Part Time");
            foreach (var student in studentsInJavaScriptPartTime)
            {
                Console.WriteLine(student);
            }
        }

        protected internal static void PrintListOfStudentsInJavaScriptOnline()
        {
            List<Student> studentsInJavaScriptOnline = List.students.FindAll(student => student.StudentStream == "JavaScript" && student.StreamType == "Part Time");
            foreach (var student in studentsInJavaScriptOnline)
            {
                Console.WriteLine(student);
            }
        }

        protected internal static void PrintListOfStudentsInJavaScriptHybridFullTime()
        {
            List<Student> studentsInJavaScriptHybridFullTime = List.students.FindAll(student => student.StudentStream == "JavaScript" && student.StreamType == "Hybrid Full Time");
            foreach (var student in studentsInJavaScriptHybridFullTime)
            {
                Console.WriteLine(student);
            }
        }

        protected internal static void PrintListOfStudentsInJavaScriptHybridPartTime()
        {
            List<Student> studentsInJavaScriptHybridPartTime = List.students.FindAll(student => student.StudentStream == "JavaScript" && student.StreamType == "Hybrid Part Time");
            foreach (var student in studentsInJavaScriptHybridPartTime)
            {
                Console.WriteLine(student);
            }
        }
    }
}
