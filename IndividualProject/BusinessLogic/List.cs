using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.BusinessLogic;
using IndividualProject.Models;

namespace IndividualProject.BusinessLogic
{
    class List
    {
        

        protected internal static List<Trainer> trainers = new List<Trainer>();
        protected internal static List<Course> courses = new List<Course>();  
        protected internal static List<Student> students = new List<Student>();
        protected internal static List<Assignment> assignments = new List<Assignment>();


        protected internal static void InputToTrainersList()
        {            
            CommandPromptUtils cpUtils = new CommandPromptUtils();
            Console.Write("Please write number of trainers to be inputed: ");
            string input = Console.ReadLine();
            int trainerInputs = 0;
            if (int.TryParse(input, out trainerInputs))
            {
                for (int i = 1; i <= trainerInputs; i++)
                {
                    trainers.Add(cpUtils.GetTrainerDetails());
                }
            }
            else
            {
                InputToTrainersList();
            }                     
        }


        protected internal static void InputToCourseList()
        {
            CommandPromptUtils cpUtils = new CommandPromptUtils();
            Console.Write("Please write number of courses to be inputed: ");
            string input = Console.ReadLine();
            int courseInputs = 0;
            if (int.TryParse(input, out courseInputs))
            {
                for (int i = 1; i <= courseInputs; i++)
                {
                    courses.Add(cpUtils.GetCourseDetails());
                }
            }
            else
            {
                InputToCourseList();
            }           
        }

        protected internal static void InputToStudentList()
        {
            CommandPromptUtils cpUtils = new CommandPromptUtils();
            Console.Write("Please write number of students to be inputed: ");
            string input = Console.ReadLine();
            int studentInputs = 0;
            if (int.TryParse(input, out studentInputs))
            {
                for (int i = 1; i <= studentInputs; i++)
                {
                    students.Add(cpUtils.GetStudentDetails());
                }
            }
            else
            {
                InputToStudentList();
            }
                       
        }
        protected internal static void InputToAssignmentList()
        {
            CommandPromptUtils cpUtils = new CommandPromptUtils();
            Console.Write("Please write number of assignments to be inputed: ");

            string input = Console.ReadLine();
            int assignmentInputs = 0;
            if (int.TryParse(input, out assignmentInputs))
            {
                for (int i = 1; i <= assignmentInputs; i++)
                {
                    assignments.Add(cpUtils.GetAssignmentDetails());
                }
            }
            else
            {
                InputToAssignmentList();
            }
                                 
        }




        //protected internal static void StudentAssignments()
        //{
        //    foreach (var student in students)
        //    {
        //        Console.WriteLine(student);

        //        foreach (var assignment in assignments)
        //        {

        //            if (student.StudentStream.Equals("Java") && assignment.AssignmentStream.Equals("Java") && student.StreamType.Equals("Full Time") && assignment.AssignmentType.Equals("Full Time"))
        //            {


        //                Console.WriteLine($"Student {student.FirstName} {student.LastName} " +
        //                                  $"\nhas the Assignment {assignment.Title} {assignment.Description} " +
        //                                  $"\nthat is due for {assignment.SubDateTime}");
        //                Console.WriteLine("-----------------------------------------------------------------------------------");
        //            }
        //            else
        //            {
        //                continue;
        //            }
        //        }
        //    }

        //    for (int i = 0; i < students.Count; i++)
        //    {
        //        for (int j = 0; j < assignments.Count; j++)
        //        {
        //            if (students[i].StudentStream.Equals(assignments[j].AssignmentStream) && students[i].StreamType.Equals(assignments[j].AssignmentType))
        //            {
        //                Console.WriteLine("im in");

        //                Console.WriteLine($"Student {students[i].FirstName} {students[i].LastName} " +
        //                                  $"\nhas the Assignment {assignments[j].Title} {assignments[j].Description} " +
        //                                  $"\nthat is due for {assignments[j].SubDateTime}");
        //                Console.WriteLine("-----------------------------------------------------------------------------------");
        //            }
        //        }
        //    }
        //}


    }
}
