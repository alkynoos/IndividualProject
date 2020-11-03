using IndividualProject.Models;
using Microsoft.SqlServer.Server;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.BusinessLogic
{
    class CommandPromptUtils
    {
        //-----------Trainer-------------------
        public Trainer GetTrainerDetails(List<string> subjects = null) //--> So we can give other list
        {
            if (subjects == null) subjects = new List<string>() { "C#", "Java", "Python", "JavaScript", "PHP" }; // --> for we can use an other if given or use the diffult
            Trainer trainer = new Trainer();
            trainer.FirstName   = AskDetail("Give me your first name");
            trainer.LastName    = AskDetail("Give me your last name");
            trainer.Subject     = AskDetail("Give me your subject you teach",subjects);
            return (trainer);
        }
        public Course GetCourseDetails(List<string> subjects = null)
        {
            Course course = new Course();
            return (course);
        }

        public Student GetStudentDetails(List<string> subjects = null) // --> check if we need to have list as a parameter
        {
            Student course = new Student();
            return (course);
        }

        public Assignment GetAssignmentDetails(List<string> subjects = null)
        {
            Assignment assignment = new Assignment();
            return (assignment);
        }


        private string AskDetail(string message, List<string> subjects = null) //--> null makes the AskDetails when used not to bring error or 
        {                                                                      //--> I whould need when using AskDetail passing null in the properties
            string result = "";
            Console.Write(message + ": ");
            if (subjects != null)
            {
                //ask for the subject the trainer teaches
                result = SelectFromListOfStrings(subjects);
            }
            else
            {
                result = Console.ReadLine();
            }
            
            return (result);
        }

        private string SelectFromListOfStrings(List<string> elements) //--> we rename the method so we make it versatile for future use
        {
            string result = "";
            int counter = 1;
            Console.WriteLine();
            foreach (var item in elements)
            {
                Console.WriteLine($"{counter++}. {item}"); // --> test the counter                
            }
            int choice = Convert.ToInt32(Console.ReadLine()); //!!!!!!!!
            result = elements.ElementAt(choice - 1);//elements[choice - 1];
            return (result);
        }
        

        public void PrintTrainersList(List<Trainer> trainers)
        {
            foreach (var item in trainers)
            {
                Console.WriteLine(item);
            }
        }

        
        //-------------Course--------------------------

        //public Course GetCourseDetails()
        //{
        //    Course course = new Course();
        //    course.Title      = AskDetail("Give Course Title");  //--> uses the AskDetails from trainer
        //    course.Stream     = AskDetail("Give Stream");
        //    course.Type       = AskDetail("Give Type");
        //    course.Start_Date = Convert.ToDateTime(AskDetail("Give Start Date"));  //--> comferm correct operation
        //    course.End_Date   = Convert.ToDateTime(AskDetail("Give Start Date"));
        //}

        ////-------------Student--------------------------

        //public Student GetStudentDetails()
        //{
        //    Student student = new Student();
        //    student.FirstName    = AskDetail("Give me student first name");
        //    student.LastName     = AskDetail("Give me student last name");
        //    student.DateOfBerth  = Convert.ToDateTime(AskDetail("Give me student date of berth"));
        //    student.TuitionFees  = Double.Parse(AskDetail("Give me student tuituin fees"));
        //}

        

        ////-------------Assignment--------------------------

        //public Assignment GetAssignmentDetails()
        //{
        //    Assignment assignment = new Assignment();
        //    assignment.Title        = AskDetail("Give me assigment title");
        //    assignment.Description  = AskDetail("Give me description");
        //    assignment.SubDateTime  = Convert.ToDateTime("Give submission date & time");
        //    assignment.OralMark     = float.Parse(AskDetail("Give oral mark"));  //--> check float correct operation
        //    assignment.TotalMark    = float.Parse(AskDetail("Give total mark"));
        //}
    }
}
