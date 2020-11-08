using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.BusinessLogic
{
    class StudentsPerCoursePython
    {
        protected internal static void PrintListOfStudentsInPythonFullTime()
        {
            List<Student> studentsInPythonFullTime = List.students.FindAll(student => student.StudentStream == "Python" && student.StreamType == "Full Time");
            foreach (var student in studentsInPythonFullTime)
            {
                Console.WriteLine(student);
            }
        }

        protected internal static void PrintListOfStudentsInPythonPartTime()
        {
            List<Student> studentsInPythonPartTime = List.students.FindAll(student => student.StudentStream == "Python" && student.StreamType == "Part Time");
            foreach (var student in studentsInPythonPartTime)
            {
                Console.WriteLine(student);
            }
        }

        protected internal static void PrintListOfStudentsInPythonOnline()
        {
            List<Student> studentsInPythonOnline = List.students.FindAll(student => student.StudentStream == "Python" && student.StreamType == "Online");
            foreach (var student in studentsInPythonOnline)
            {
                Console.WriteLine(student);
            }
        }

        protected internal static void PrintListOfStudentsInPythonHybridFullTime()
        {
            List<Student> studentsInPythonHybridFullTime = List.students.FindAll(student => student.StudentStream == "Python" && student.StreamType == "Hybrid Full Time");
            foreach (var student in studentsInPythonHybridFullTime)
            {
                Console.WriteLine(student);
            }
        }

        protected internal static void PrintListOfStudentsInPythonHybridPartTime()
        {
            List<Student> studentsInPythonHybridPartTime = List.students.FindAll(student => student.StudentStream == "Python" && student.StreamType == "Hybrid Part Time");
            foreach (var student in studentsInPythonHybridPartTime)
            {
                Console.WriteLine(student);
            }
        }
    }
}
