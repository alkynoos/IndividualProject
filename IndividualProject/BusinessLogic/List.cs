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
        //Try to gather the similar code in method

        //public static CommandPromptUtils AskForInput(string message, out CommandPromptUtils cpUtils) 
        //{
        //    CommandPromptUtils cpUtils = new CommandPromptUtils();
        //    Console.WriteLine($"Please write number of {message} to be inputed: ");
        //    int Inputs = Int32.Parse(Console.ReadLine());
        //}

        protected internal static List<Trainer> trainers = new List<Trainer>();
        protected internal static List<Course> courses = new List<Course>();  
        protected internal static List<Student> students = new List<Student>();
        protected internal static List<Assignment> assignments = new List<Assignment>();


        protected internal static void InputToTrainersList()
        {
            //AskForInput("trainers");

            CommandPromptUtils cpUtils = new CommandPromptUtils();
            Console.Write("Please write number of trainers to be inputed: ");
            int trainerInputs = Int32.Parse(Console.ReadLine());
            //List<Trainer> trainers = new List<Trainer>();
            for (int i = 1; i <= trainerInputs; i++)
            {
                trainers.Add(cpUtils.GetTrainerDetails());
            }
            //cpUtils.PrintTrainersList(trainers);
        }
        protected internal static void InputToCourseList()
        {
            CommandPromptUtils cpUtils = new CommandPromptUtils();
            Console.Write("Please write number of courses to be inputed: ");
            int courseInputs = Int32.Parse(Console.ReadLine());
            //List<Course> courses = new List<Course>();
            for (int i = 1; i <= courseInputs; i++)
            {
                courses.Add(cpUtils.GetCourseDetails());
            }
            //cpUtils.PrintCoursesList(courses);
        }
        protected internal static void InputToStudentList()
        {
            CommandPromptUtils cpUtils = new CommandPromptUtils();
            Console.Write("Please write number of students to be inputed: ");
            int studentInputs = Int32.Parse(Console.ReadLine());
            //List<Student> students = new List<Student>();
            for (int i = 1; i <= studentInputs; i++)
            {
                students.Add(cpUtils.GetStudentDetails());
            }
            //cpUtils.PrintStudentsList(students);
        }
        protected internal static void InputToAssignmentList()
        {
            CommandPromptUtils cpUtils = new CommandPromptUtils();
            Console.Write("Please write number of assignments to be inputed: ");
            int assignmentInputs = Int32.Parse(Console.ReadLine());
            //List<Assignment> assignments = new List<Assignment>();
            for (int i = 1; i <= assignmentInputs; i++)
            {
                assignments.Add(cpUtils.GetAssignmentDetails());
            }
            //cpUtils.PrintAssignmentsList(assignments);
            
        }

        //public static List<Trainer> SyntheticDataTrainer()
        //{
        //    trainers.Add(new Trainer("Aadam", "English", "Java"));
        //    return (trainers);
        //}
    }
}
