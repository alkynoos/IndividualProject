using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndividualProject.BusinessLogic;
using IndividualProject.Models;

namespace IndividualProject
{
    class Program 
    {
        static void Main(string[] args)
        {
            ConsoleMenu.Menu();


            //List.CallAllTheInputs();

            //List.InputToStudentList();

            //StudentsPerCourseJava.PrintListOfStudentsInJavaFullTime();



            //CommandPromptUtils cpUtils = new CommandPromptUtils(); // we need to create the CommandPromptUtils so we can use the methode below
            //Trainer trainer = cpUtils.GetTrainerDetails();
            ////Console.WriteLine(trainer);

            //CommandPromptUtils cpUtils2 = new CommandPromptUtils(); 
            //Trainer trainer2 = cpUtils.GetTrainerDetails();
            //Console.WriteLine(trainer2);

            //Trainer trainer = new Trainer(); // make sure to "call" the currect namespace at the top
            //trainer.FirstName = "G"; // setFirstName set
        }

        //static void InputToTrainersList()
        //{
        //    CommandPromptUtils cpUtils = new CommandPromptUtils();
        //    Console.Write("Please write number of trainers to be inputed: ");
        //    int trainerInputs = Int32.Parse(Console.ReadLine());
        //    List<Trainer> trainers = new List<Trainer>();
        //    for (int i = 1; i <= trainerInputs; i++)
        //    {
        //        trainers.Add(cpUtils.GetTrainerDetails());                
        //    }
        //    cpUtils.PrintTrainersList(trainers); 
        //}
        
        //static void InputToCourseList()
        //{
        //    CommandPromptUtils cpUtils = new CommandPromptUtils();
        //    Console.Write("Please write number of courses to be inputed: ");
        //    int courseInputs = Int32.Parse(Console.ReadLine());
        //    List<Course> courses = new List<Course>();
        //    for (int i = 1; i <= courseInputs; i++)
        //    {
        //        courses.Add(cpUtils.GetCourseDetails());                
        //    }
        //    cpUtils.PrintCoursesList(courses);
        //}
        //static void InputToStudentList()
        //{
        //    CommandPromptUtils cpUtils = new CommandPromptUtils();
        //    Console.Write("Please write number of students to be inputed: ");
        //    int studentInputs = Int32.Parse(Console.ReadLine());
        //    List<Student> students = new List<Student>();
        //    for (int i = 1; i <= studentInputs; i++)
        //    {                
        //        students.Add(cpUtils.GetStudentDetails());                
        //    }
        //    cpUtils.PrintStudentsList(students);
        //}

        //static void InputToAssignmentList()
        //{
        //    CommandPromptUtils cpUtils = new CommandPromptUtils();
        //    Console.Write("Please write number of assignments to be inputed: ");
        //    int assignmentInputs = Int32.Parse(Console.ReadLine());
        //    List<Assignment> assignments = new List<Assignment>();
        //    for (int i = 1; i <= assignmentInputs; i++)
        //    {
        //        assignments.Add(cpUtils.GetAssignmentDetails());
        //    }
        //    cpUtils.PrintAssignmentsList(assignments);
        //}

        // Create appropriate methodes in order to ask from the user date for main classes
    }
}
