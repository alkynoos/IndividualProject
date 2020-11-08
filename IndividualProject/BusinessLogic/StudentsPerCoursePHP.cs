using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.BusinessLogic
{
    class StudentsPerCoursePHP
    {
        protected internal static void PrintListOfStudentsInPHPFullTime()
        {
            List<Student> studentsInPHPFullTime = List.students.FindAll(student => student.StudentStream == "PHP" && student.StreamType == "Full Time");
            foreach (var student in studentsInPHPFullTime)
            {
                Console.WriteLine(student);
            }
        }

        protected internal static void PrintListOfStudentsInPHPPartTime()
        {
            List<Student> studentsInPHPPartTime = List.students.FindAll(student => student.StudentStream == "PHP" && student.StreamType == "Part Time");
            foreach (var student in studentsInPHPPartTime)
            {
                Console.WriteLine(student);
            }
        }

        protected internal static void PrintListOfStudentsInPHPOnline()
        {
            List<Student> studentsInPHPOnline = List.students.FindAll(student => student.StudentStream == "PHP" && student.StreamType == "Online");
            foreach (var student in studentsInPHPOnline)
            {
                Console.WriteLine(student);
            }
        }

        protected internal static void PrintListOfStudentsInPHPHybridFullTime()
        {
            List<Student> studentsInPHPHybridFullTime = List.students.FindAll(student => student.StudentStream == "PHP" && student.StreamType == "Hybrid Full Time");
            foreach (var student in studentsInPHPHybridFullTime)
            {
                Console.WriteLine(student);
            }
        }

        protected internal static void PrintListOfStudentsInPHPHybridPartTime()
        {
            List<Student> studentsInPHPHybridPartTime = List.students.FindAll(student => student.StudentStream == "PHP" && student.StreamType == "Hybrid Part Time");
            foreach (var student in studentsInPHPHybridPartTime)
            {
                Console.WriteLine(student);
            }
        }
    }
}
