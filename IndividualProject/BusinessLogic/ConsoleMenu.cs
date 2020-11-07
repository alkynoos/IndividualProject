using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IndividualProject.BusinessLogic
{
    class ConsoleMenu
    {
        protected internal static void Menu()
        {
            Console.WriteLine("Choose Action: ");
            Console.WriteLine("1) Input Data Menu.");
            Console.WriteLine("2) Print Input Lists Menu.");
            Console.WriteLine("3) Print Students Per Course Menu.");
            //Console.WriteLine("4) Input list of Assignments.");
            //Console.WriteLine("5) Continue without inputs.");
            Console.WriteLine("6) Exit .");

            ConsoleKeyInfo menuSelection;
            menuSelection = Console.ReadKey(true);

            switch (menuSelection.KeyChar)
            {
                case '1':
                    Console.Clear();
                    Console.WriteLine("Input Data Menu.");
                    InputDataMenu();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case '2':
                    Console.Clear();
                    Console.WriteLine("Print Input Lists Menu.");
                    PrintInputListsMenu();
                    Console.ReadKey();
                    break;
                case '3':
                    Console.Clear();
                    Console.WriteLine("Print Students Per Course.");
                    PrintStudentsPerCourse();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                //case '4':
                //    Console.Clear();
                //    Console.WriteLine("Greating a list of Assignments.");
                //    List.InputToAssignmentList();
                //    Console.ReadKey();
                //    Console.Clear();
                //    Menu();
                //    break;
                //case '5':
                //    Console.Clear();
                //    Console.WriteLine("Greating a lists with sythetic data ");
                //    Console.ReadKey();
                //    Console.Clear();
                //    Menu();
                //    break;
                case '6':
                    Console.Clear();
                    Console.WriteLine("Back to Main Menu.");
                    // find console Exit from console commant
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

        }

        protected internal static void InputDataMenu()
        {
            Console.WriteLine("Choose Action: ");
            Console.WriteLine("1) Input list of Students.");
            Console.WriteLine("2) Input list of Course.");
            Console.WriteLine("3) Input list of Trainer.");
            Console.WriteLine("4) Input list of Assignments.");
            Console.WriteLine("5) Continue without inputs.");
            Console.WriteLine("6) Back to Main Menu.");

            ConsoleKeyInfo menuSelection;
            menuSelection = Console.ReadKey(true);

            switch (menuSelection.KeyChar)
            {
                case '1':
                    Console.Clear();
                    Console.WriteLine("Greating a list of Students.");
                    List.InputToStudentList();
                    Console.ReadKey();
                    Console.Clear();
                    InputDataMenu();
                    break;
                case '2':
                    Console.Clear();
                    Console.WriteLine("Greating a list of Course.");
                    List.InputToCourseList();
                    Console.ReadKey();
                    break;
                case '3':
                    Console.Clear();
                    Console.WriteLine("Greating a list of Trainer.");
                    List.InputToTrainersList();
                    Console.ReadKey();
                    Console.Clear();
                    InputDataMenu();
                    break;
                case '4':
                    Console.Clear();
                    Console.WriteLine("Greating a list of Assignments.");
                    List.InputToAssignmentList();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case '5':
                    Console.Clear();
                    Console.WriteLine("Greating a lists with sythetic data. ");
                    // to do sythetic data lists
                    Console.ReadKey();
                    Console.Clear();
                    InputDataMenu();
                    break;
                case '6':
                    Console.Clear();
                    Console.WriteLine("Back to Main Menu.");
                    Menu();
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

        }

        protected internal static void PrintInputListsMenu()
        {
            Console.WriteLine("Choose Action: ");
            Console.WriteLine("1) Print list Students.");
            Console.WriteLine("2) Print list of Course.");
            Console.WriteLine("3) Print list of Trainer.");
            Console.WriteLine("4) Print list of Assignments.");
            Console.WriteLine("5) Back to Main Menu.");
            

            ConsoleKeyInfo menuSelection;
            menuSelection = Console.ReadKey(true);

            switch (menuSelection.KeyChar)
            {
                case '1':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Students.");
                    CommandPromptUtils.PrintStudentsList(List.students);
                    Console.ReadKey();
                    Console.Clear();
                    PrintInputListsMenu();
                    break;
                case '2':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Course.");
                    CommandPromptUtils.PrintCoursesList(List.courses);
                    Console.ReadKey();
                    PrintInputListsMenu();
                    break;
                case '3':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Trainer.");
                    CommandPromptUtils.PrintTrainersList(List.trainers);
                    Console.ReadKey();
                    Console.Clear();
                    PrintInputListsMenu();
                    break;
                case '4':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Assignments.");
                    CommandPromptUtils.PrintAssignmentsList(List.assignments);
                    Console.ReadKey();
                    Console.Clear();
                    PrintInputListsMenu();
                    break;
                case '5':
                    Console.Clear();
                    Console.WriteLine("Back to Main Menu ");
                    Menu();
                    Console.ReadKey();
                    Console.Clear();
                    break;                
            }

        }

        protected internal static void PrintStudentsPerCourse()
        {
            Console.WriteLine("Choose Action: ");
            Console.WriteLine("1) Java.");
            Console.WriteLine("2) C# .");
            Console.WriteLine("3) JavaScript.");
            Console.WriteLine("4) PHP.");
            Console.WriteLine("5) Back to Main Menu.");


            ConsoleKeyInfo menuSelection;
            menuSelection = Console.ReadKey(true);

            switch (menuSelection.KeyChar)
            {
                case '1':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Java Students.");
                    PrintStudentsOfJava();
                    Console.ReadKey();
                    Console.Clear();
                    PrintStudentsPerCourse();
                    break;
                case '2':
                    Console.Clear();
                    Console.WriteLine("Printing the list of C# Students.");
                    PrintStudentsOfCSharp();
                    Console.ReadKey();
                    PrintStudentsPerCourse();
                    break;
                case '3':
                    Console.Clear();
                    Console.WriteLine("Printing the list of JavaScript Students.");
                    PrintStudentsOfJavaScript();
                    Console.ReadKey();
                    Console.Clear();
                    PrintStudentsPerCourse();
                    break;
                case '4':
                    Console.Clear();
                    Console.WriteLine("Printing the list of PHP Students.");
                    PrintStudentsOfPHP();
                    Console.ReadKey();
                    Console.Clear();
                    PrintStudentsPerCourse();
                    break;
                case '5':
                    Console.Clear();
                    Console.WriteLine("Back to Main Menu ");
                    Menu(); 
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

        }

        protected internal static void PrintStudentsOfJava()
        {
            Console.WriteLine("Choose Action: ");
            Console.WriteLine("1) Full Time.");
            Console.WriteLine("2) Part Time.");
            Console.WriteLine("3) Online. ");
            Console.WriteLine("4) Hybrid Full Time.");
            Console.WriteLine("5) Hybrid Part Time.");
            Console.WriteLine("6) Go Back.");


            ConsoleKeyInfo menuSelection;
            menuSelection = Console.ReadKey(true);

            switch (menuSelection.KeyChar)
            {
                case '1':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Java Full Time Students.");
                    StudentsPerCourseJava.PrintListOfStudentsInJavaFullTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintStudentsOfJava();
                    break;
                case '2':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Java Part Time Students.");
                    StudentsPerCourseJava.PrintListOfStudentsInJavaPartTime();
                    Console.ReadKey();
                    PrintStudentsOfJava();
                    break;
                case '3':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Java Online Students.");
                    StudentsPerCourseJava.PrintListOfStudentsJavaInOnline();
                    Console.ReadKey();
                    Console.Clear();
                    PrintStudentsOfJava();
                    break;
                case '4':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Java Hybrid Full Time Students.");
                    StudentsPerCourseJava.PrintListOfStudentsInJavaHybridFullTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintStudentsOfJava();
                    break;
                case '5':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Java Hybrid Part Time Students.");
                    StudentsPerCourseJava.PrintListOfStudentsInJavaHybridPartTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintStudentsOfJava();
                    break;
                case '6':
                    Console.Clear();
                    Console.WriteLine("Go Back.");
                    PrintStudentsPerCourse();
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

        }

        protected internal static void PrintStudentsOfCSharp()
        {
            Console.WriteLine("Choose Action: ");
            Console.WriteLine("1) Full Time.");
            Console.WriteLine("2) Part Time.");
            Console.WriteLine("3) Online. ");
            Console.WriteLine("4) Hybrid Full Time.");
            Console.WriteLine("5) Hybrid Part Time.");
            Console.WriteLine("6) Go Back.");


            ConsoleKeyInfo menuSelection;
            menuSelection = Console.ReadKey(true);

            switch (menuSelection.KeyChar)
            {
                case '1':
                    Console.Clear();
                    Console.WriteLine("Printing the list of C# Full Time Students.");
                    StudentsPerCourseCSharp.PrintListOfStudentsInCSharpFullTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintStudentsOfCSharp();
                    break;
                case '2':
                    Console.Clear();
                    Console.WriteLine("Printing the list of C# Part Time Students.");
                    StudentsPerCourseCSharp.PrintListOfStudentsInCSharpPartTime();
                    Console.ReadKey();
                    PrintStudentsOfCSharp();
                    break;
                case '3':
                    Console.Clear();
                    Console.WriteLine("Printing the list of C# Online Students.");
                    StudentsPerCourseCSharp.PrintListOfStudentsInCSharpOnline();
                    Console.ReadKey();
                    Console.Clear();
                    PrintStudentsOfCSharp();
                    break;
                case '4':
                    Console.Clear();
                    Console.WriteLine("Printing the list of C# Hybrid Full Time Students.");
                    StudentsPerCourseCSharp.PrintListOfStudentsInCSharpHybridFullTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintStudentsOfCSharp();
                    break;
                case '5':
                    Console.Clear();
                    Console.WriteLine("Printing the list of C# Hybrid Part Time Students.");
                    StudentsPerCourseCSharp.PrintListOfStudentsInCSharpHybridPartTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintStudentsOfCSharp();
                    break;
                case '6':
                    Console.Clear();
                    Console.WriteLine("Go Back.");
                    PrintStudentsPerCourse();
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

        }

        protected internal static void PrintStudentsOfJavaScript()
        {
            Console.WriteLine("Choose Action: ");
            Console.WriteLine("1) Full Time.");
            Console.WriteLine("2) Part Time.");
            Console.WriteLine("3) Online. ");
            Console.WriteLine("4) Hybrid Full Time.");
            Console.WriteLine("5) Hybrid Part Time.");
            Console.WriteLine("6) Go Back.");


            ConsoleKeyInfo menuSelection;
            menuSelection = Console.ReadKey(true);

            switch (menuSelection.KeyChar)
            {
                case '1':
                    Console.Clear();
                    Console.WriteLine("Printing the list of JavaScript Full Time Students.");
                    StudentsPerCourseJavaScript.PrintListOfStudentsInJavaScriptFullTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintStudentsOfJavaScript();
                    break;
                case '2':
                    Console.Clear();
                    Console.WriteLine("Printing the list of JavaScript Part Time Students.");
                    StudentsPerCourseJavaScript.PrintListOfStudentsInJavaScriptPartTime();
                    Console.ReadKey();
                    PrintStudentsOfJavaScript();
                    break;
                case '3':
                    Console.Clear();
                    Console.WriteLine("Printing the list of JavaScript Online Students.");
                    StudentsPerCourseJavaScript.PrintListOfStudentsInJavaScriptOnline();
                    Console.ReadKey();
                    Console.Clear();
                    PrintStudentsOfJavaScript();
                    break;
                case '4':
                    Console.Clear();
                    Console.WriteLine("Printing the list of JavaScript Hybrid Full Time Students.");
                    StudentsPerCourseJavaScript.PrintListOfStudentsInJavaScriptHybridFullTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintStudentsOfJavaScript();
                    break;
                case '5':
                    Console.Clear();
                    Console.WriteLine("Printing the list of JavaScript Hybrid Part Time Students.");
                    StudentsPerCourseJavaScript.PrintListOfStudentsInJavaScriptHybridPartTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintStudentsOfJavaScript();
                    break;
                case '6':
                    Console.Clear();
                    Console.WriteLine("Go Back.");
                    PrintStudentsPerCourse();
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

        }

        protected internal static void PrintStudentsOfPHP()
        {
            Console.WriteLine("Choose Action: ");
            Console.WriteLine("1) Full Time.");
            Console.WriteLine("2) Part Time.");
            Console.WriteLine("3) Online. ");
            Console.WriteLine("4) Hybrid Full Time.");
            Console.WriteLine("5) Hybrid Part Time.");
            Console.WriteLine("6) Go Back.");


            ConsoleKeyInfo menuSelection;
            menuSelection = Console.ReadKey(true);

            switch (menuSelection.KeyChar)
            {
                case '1':
                    Console.Clear();
                    Console.WriteLine("Printing the list of PHP Full Time Students.");
                    StudentsPerCoursePHP.PrintListOfStudentsInPHPFullTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintStudentsOfPHP();
                    break;
                case '2':
                    Console.Clear();
                    Console.WriteLine("Printing the list of PHP Part Time Students.");
                    StudentsPerCoursePHP.PrintListOfStudentsInPHPPartTime();
                    Console.ReadKey();
                    PrintStudentsOfPHP();
                    break;
                case '3':
                    Console.Clear();
                    Console.WriteLine("Printing the list of PHP Online Students.");
                    StudentsPerCoursePHP.PrintListOfStudentsInPHPOnline();
                    Console.ReadKey();
                    Console.Clear();
                    PrintStudentsOfPHP();
                    break;
                case '4':
                    Console.Clear();
                    Console.WriteLine("Printing the list of PHP Hybrid Full Time Students.");
                    StudentsPerCoursePHP.PrintListOfStudentsInPHPHybridFullTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintStudentsOfPHP();
                    break;
                case '5':
                    Console.Clear();
                    Console.WriteLine("Printing the list of JavaScript Hybrid Part Time Students.");
                    StudentsPerCoursePHP.PrintListOfStudentsInPHPHybridPartTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintStudentsOfJava();
                    break;
                case '6':
                    Console.Clear();
                    Console.WriteLine("Go Back.");
                    PrintStudentsPerCourse();
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

        }

    }
    
}
