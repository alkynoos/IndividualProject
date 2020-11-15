using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.BusinessLogic
{
    class StudentsPerCourse
    {
        
        protected internal static List<string> stream = new List<string>() { "C#", "Java", "Python", "JavaScript", "PHP" };
        protected internal static List<string> type = new List<string>() { "Full Time", "Part Time", "Online", "Hybrid Full Time", "Hybrid Part Time" };

        protected internal void ListPerStudentPerCourse()
        {
            PrintList(MakeListStudentPerCourse(SelectFromListOfSrings(stream), SelectFromListOfSrings(type)));
        }

        protected internal List<Student> MakeListStudentPerCourse(string stream, string type)
        {

            List<Student> studentsPerCourse = List.students.FindAll(student => student.StudentStream == stream && student.StreamType == type);
            return (studentsPerCourse);
        }

        

        protected internal static void PrintList(List<Student> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        protected internal string SelectFromListOfSrings (List<string> element) //--> maybe i can make it so i use it from utils
        {            
            string result = "";
            int counter = 1;
            foreach (var item in element)
            {
                Console.WriteLine($"{counter++}.{item}"); //-->presents the lists of choice
            }
            int choice = Int32.Parse(Console.ReadLine());
            while (choice > element.Count || choice <= 0) //--> checks for correct input
            {
                Console.WriteLine("Enter Correct Selection: ");
                choice = Int32.Parse(Console.ReadLine());
            }
            result = element.ElementAt(choice - 1);            
            return (result);
        }
    }
}
