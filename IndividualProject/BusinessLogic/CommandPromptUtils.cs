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
            if (subjects == null) subjects = new List<string>() { "C#", "Java", "Python", "JavaScript", "PHP" }; // --> so we can use an other if given or use the defult
            Trainer trainer = new Trainer();
            trainer.FirstName   = AskDetail("Give me your first name");
            trainer.LastName    = AskDetail("Give me your last name");
            trainer.Subject     = AskDetail("Select me your subject you teach",subjects);
            Console.Clear();
            return (trainer);
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
            int choice = Int32.Parse(Console.ReadLine());

            while (choice > elements.Count || choice <= 0)
            {
                Console.Write("Enter Correct selection: ");
                choice = Convert.ToInt32(Console.ReadLine());
            }
            result = elements.ElementAt(choice - 1);//elements[choice - 1];
            return (result);
        }

        protected internal static void PrintTrainersList(List<Trainer> trainers)
        {
            foreach (var item in trainers)
            {
                Console.WriteLine(item);
            }
        }


        //-------------Course--------------------------

        public Course GetCourseDetails(List<string> stream = null, List<string> type = null)
        {
            if (stream == null) stream = new List<string>() { "C#", "Java", "Python", "JavaScript", "PHP" };
            if (type == null) type = new List<string>() { "Full Time", "Part Time", "Online", "Hybrid Full Time", "Hybrid Part Time" };

            Course course = new Course();
            course.TitleNumber = Convert.ToInt32(AskDetail("Give Coding Bootcamp No"));  //--> see if we can use smaller data value
            course.Stream = AskDetail("Select Stream", stream);
            course.Type = AskDetail("Select Type", type);
            course.Start_Date = Convert.ToDateTime(AskDetail("Give Start Date"));  //--> confirm correct operation !!! FIX INPUT FORMAT
            course.End_Date = Convert.ToDateTime(AskDetail("Give End Date"));
            Console.Clear();
            return (course);
        }

        protected internal static void PrintCoursesList(List<Course> courses)
        {
            foreach (var item in courses)
            {
                Console.WriteLine(item);
            }
        }

        //---------------Student--------------------------

        public Student GetStudentDetails(List<string> studentsStream = null, List<string> streamType = null)
        {
            if (studentsStream == null) studentsStream = new List<string>() { "C#", "Java", "Python", "JavaScript", "PHP" };
            if (streamType == null) streamType = new List<string>() { "Full Time", "Part Time", "Online", "Hybrid Full Time", "Hybrid Part Time" };
            Student student = new Student();
            student.FirstName = AskDetail("Give me student first name");
            student.LastName = AskDetail("Give me student last name");
            student.DateOfBirth = Convert.ToDateTime(AskDetail("Give me student date of birth"));
            student.StudentStream = AskDetail("Select student Stream", studentsStream);
            student.StreamType = AskDetail("Select student Stream Type", streamType);            
            student.TuitionFees = Convert.ToDouble(AskDetail("Give me student tuituion fees"));
            Console.Clear();
            return (student);
        }

        protected internal static void PrintStudentsList(List<Student> students) //--> can i find a common value for the Classes so i can make one print methode for all
        {
            foreach (var item in students)
            {
                Console.WriteLine(item);
            }
        }


        ////-------------Assignment--------------------------

        
        public Assignment GetAssignmentDetails(List<string> assignmentStream = null, List<string> assignmentType = null)
        {
            if (assignmentStream == null) assignmentStream = new List<string>() { "Java", "C#", "JavaScript", "PHP", "Python" };
            if (assignmentType == null) assignmentType = new List<string>() { "Full Time", "Part Time", "Online", "Hybrid Full Time", "Hybrid Part Time" };
            Assignment assignment = new Assignment();
            assignment.AssignmentStream = AskDetail("Select assigment Stream", assignmentStream);
            assignment.AssignmentType = AskDetail("Select assigment Stream Type", assignmentType);
            assignment.Title = AskDetail("Give me assigment title");
            assignment.Description = AskDetail("Give me description");
            assignment.SubDateTime = Convert.ToDateTime(AskDetail("Give submission date & time"));
            assignment.OralMark = float.Parse(AskDetail("Give oral mark"));  
            assignment.TotalMark = float.Parse(AskDetail("Give total mark"));
            Console.Clear();
            return (assignment);
        }

        protected internal static void PrintAssignmentsList(List<Assignment> assignments) 
        {
            foreach (var item in assignments)
            {
                Console.WriteLine(item);
            }
        }

        
    }
}
