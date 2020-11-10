using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.BusinessLogic
{
    class StudentsPerCourseJava 
    {
        protected internal static List<Student> studentsInJavaFullTime = List.students.FindAll(student => student.StudentStream == "Java" && student.StreamType == "Full Time");
        protected internal static List<Student> studentsInJavaPartTime = List.students.FindAll(student => student.StudentStream == "Java" && student.StreamType == "Part Time");
        protected internal static List<Student> studentsInJavaOnline = List.students.FindAll(student => student.StudentStream == "Java" && student.StreamType == "Online");
        protected internal static List<Student> studentsInJavaHybridFullTime = List.students.FindAll(student => student.StudentStream == "Java" && student.StreamType == "Hybrid Full Time");
        protected internal static List<Student> studentsInJavaHybridPartTime = List.students.FindAll(student => student.StudentStream == "Java" && student.StreamType == "Hybrid Part Time");

        protected internal static void PrintListOfStudentsInJavaFullTime()
        {
            //List<Student> studentsInJavaFullTime = List.students.FindAll(student => student.StudentStream == "Java" && student.StreamType == "Full Time");
            foreach (var student in studentsInJavaFullTime)
            {
                Console.WriteLine(student);
            }
        }

       
        protected internal static void PrintListOfStudentsInJavaPartTime()
        {
            //List<Student> studentsInJavaPartTime = List.students.FindAll(student => student.StudentStream == "Java" && student.StreamType == "Part Time");
            foreach (var student in studentsInJavaPartTime)
            {
                Console.WriteLine(student);
            }
        }

        protected internal static void PrintListOfStudentsJavaInOnline()
        {
            //List<Student> studentsInJavaOnline = List.students.FindAll(student => student.StudentStream == "Java" && student.StreamType == "Online");
            foreach (var student in studentsInJavaOnline)
            {
                Console.WriteLine(student);
            }
        }

        protected internal static void PrintListOfStudentsInJavaHybridFullTime()
        {
            //List<Student> studentsInJavaHybridFullTime = List.students.FindAll(student => student.StudentStream == "Java" && student.StreamType == "Hybrid Full Time");
            foreach (var student in studentsInJavaHybridFullTime)
            {
                Console.WriteLine(student);
            }
        }

        protected internal static void PrintListOfStudentsInJavaHybridPartTime()
        {
            //List<Student> studentsInJavaHybridPartTime = List.students.FindAll(student => student.StudentStream == "Java" && student.StreamType == "Hybrid Part Time");
            foreach (var student in studentsInJavaHybridPartTime)
            {
                Console.WriteLine(student);
            }
        }

        protected internal static void GiveStudentAssignmentInJavaFullTime(List<Assignment> assignments)
        {
            foreach (var student in studentsInJavaFullTime)
            {
                Console.WriteLine("*********************************************************");
                Console.WriteLine($"{student.FirstName} {student.LastName}");
                foreach (var assingment in assignments)
                {
                    Console.WriteLine(assingment);
                }
                //Console.WriteLine(assignments.ToString());
                Console.WriteLine("*********************************************************");
            }
        }
    }
}
