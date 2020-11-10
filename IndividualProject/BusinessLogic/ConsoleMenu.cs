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
            Console.WriteLine("1) Input Data.");
            Console.WriteLine("2) Print Input Lists.");
            Console.WriteLine("3) Print Students Per Course.");
            Console.WriteLine("4) Print Trainers Per Course.");
            Console.WriteLine("5) Print Assingnments Per Course.");
            Console.WriteLine("6) Print Students with there Assingnments.");
            Console.WriteLine("7) Print Students in more then one course.");
            Console.WriteLine("8) Exit.");

            ConsoleKeyInfo menuSelection;
            menuSelection = Console.ReadKey(true);

            switch (menuSelection.KeyChar)
            {
                case '1':
                    Console.Clear();
                    Console.WriteLine("Input Data.");
                    InputDataMenu();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case '2':
                    Console.Clear();
                    Console.WriteLine("Print Input Lists.");
                    PrintInputListsMenu();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case '3':
                    Console.Clear();
                    Console.WriteLine("Print Students Per Course.");
                    PrintStudentsPerCourse();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case '4':
                    Console.Clear();
                    Console.WriteLine("Print Trainers Per Course.");
                    PrintTrainersPerCourse();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case '5':
                    Console.Clear();
                    Console.WriteLine("Print Assingnments Per Course.");
                    PrintAssignmentsPerCourse();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case '6':
                    Console.Clear();
                    Console.WriteLine("Print Students with there Assingnments.");
                    //StudentsPerCourseJava.GiveStudentAssignmentInJavaFullTime(); Under Construction
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case '7':
                    Console.Clear();
                    Console.WriteLine("Print Students in more then one course.");
                    StudentsInMoreCourses.ReturnStudentsInMoreCourses();
                    Console.ReadKey();
                    Console.Clear();
                    Menu();
                    break;
                case '8':                    
                    Environment.Exit(0);                    
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
                    Console.Clear();
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
                    SyntheticData.SendSyntheticDataToMemu();
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
                    Console.Clear();
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
                    Console.WriteLine("Back to Main Menu. ");
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
            Console.WriteLine("5) Python.");
            Console.WriteLine("6) Back to Main Menu.");


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
                    Console.Clear();
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
                    Console.WriteLine("Printing the list of Python Students.");
                    PrintStudentsOfPython();
                    Console.ReadKey();
                    Console.Clear();
                    PrintStudentsPerCourse();
                    break;
                case '6':
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
                    Console.Clear();
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
                    Console.Clear();
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
                    Console.Clear();
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
                    Console.Clear();
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
                    Console.WriteLine("Printing the list of PHP Hybrid Part Time Students.");
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
        protected internal static void PrintStudentsOfPython()
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
                    Console.WriteLine("Printing the list of Python Full Time Students.");
                    StudentsPerCoursePython.PrintListOfStudentsInPythonFullTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintStudentsOfPython();
                    break;
                case '2':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Python Part Time Students.");
                    StudentsPerCoursePython.PrintListOfStudentsInPythonPartTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintStudentsOfPython();
                    break;
                case '3':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Python Online Students.");
                    StudentsPerCoursePython.PrintListOfStudentsInPythonOnline();
                    Console.ReadKey();
                    Console.Clear();
                    PrintStudentsOfPython();
                    break;
                case '4':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Python Hybrid Full Time Students.");
                    StudentsPerCoursePython.PrintListOfStudentsInPythonHybridFullTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintStudentsOfPython();
                    break;
                case '5':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Python Hybrid Part Time Students.");
                    StudentsPerCoursePython.PrintListOfStudentsInPythonHybridPartTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintStudentsOfPython();
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


        protected internal static void PrintTrainersPerCourse()
        {
            Console.WriteLine("Choose Action: ");
            Console.WriteLine("1) Java.");
            Console.WriteLine("2) C# .");
            Console.WriteLine("3) JavaScript.");
            Console.WriteLine("4) PHP.");
            Console.WriteLine("5) Python.");
            Console.WriteLine("6) Back to Main Menu."); ;


            ConsoleKeyInfo menuSelection;
            menuSelection = Console.ReadKey(true);

            switch (menuSelection.KeyChar)
            {
                case '1':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Java Trainers.");
                    TrainersPerCourse.PrintListOfJavaTrainer();
                    Console.ReadKey();
                    Console.Clear();
                    PrintTrainersPerCourse();
                    break;
                case '2':
                    Console.Clear();
                    Console.WriteLine("Printing the list of C# Trainers.");
                    TrainersPerCourse.PrintListOfCSharpTrainer();
                    Console.ReadKey();
                    Console.Clear();
                    PrintTrainersPerCourse();
                    break;
                case '3':
                    Console.Clear();
                    Console.WriteLine("Printing the list of JavaScript Trainers.");
                    TrainersPerCourse.PrintListOfJavaScriptTrainer();
                    Console.ReadKey();
                    Console.Clear();
                    PrintTrainersPerCourse();
                    break;
                case '4':
                    Console.Clear();
                    Console.WriteLine("Printing the list of PHP Trainers.");
                    TrainersPerCourse.PrintListOfPHPTrainer();
                    Console.ReadKey();
                    Console.Clear();
                    PrintTrainersPerCourse();
                    break;
                case '5':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Python Trainers.");
                    TrainersPerCourse.PrintListOfPythonTrainer();
                    Console.ReadKey();
                    Console.Clear();
                    PrintTrainersPerCourse();
                    break;
                case '6':
                    Console.Clear();
                    Console.WriteLine("Back to Main Menu ");
                    Menu();
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

        }

        protected internal static void PrintAssignmentsPerCourse()
        {
            Console.WriteLine("Choose Assignments Per Course: ");
            Console.WriteLine("1) Java.");
            Console.WriteLine("2) C# .");
            Console.WriteLine("3) JavaScript.");
            Console.WriteLine("4) PHP.");
            Console.WriteLine("5) Python.");
            Console.WriteLine("6) Back to Main Menu.");


            ConsoleKeyInfo menuSelection;
            menuSelection = Console.ReadKey(true);

            switch (menuSelection.KeyChar)
            {
                case '1':
                    Console.Clear();
                    Console.WriteLine("Java Assignments.");
                    PrintAssignmentsOfJava();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsPerCourse();
                    break;
                case '2':
                    Console.Clear();
                    Console.WriteLine("C# Assignments.");
                    PrintAssignmentsOfCSharp();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsPerCourse();
                    break;
                case '3':
                    Console.Clear();
                    Console.WriteLine("JavaScript Assignments.");
                    PrintAssignmentsOfJavaScript();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsPerCourse();
                    break;
                case '4':
                    Console.Clear();
                    Console.WriteLine("PHP Assignments.");
                    PrintAssignmentsOfJavaScript();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsPerCourse();
                    break;
                case '5':
                    Console.Clear();
                    Console.WriteLine("Python Assignments. ");
                    PrintAssignmentsOfPHP();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsPerCourse();
                    break;
                case '6':
                    Console.Clear();
                    Console.WriteLine("Back to Main Menu. ");
                    Menu();
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

        }
        protected internal static void PrintAssignmentsOfJava()
        {
            Console.WriteLine("Choose Assignments Of Java: ");
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
                    Console.WriteLine("Printing the list of Java Full Time Assignments.");
                    AssignmentsJava.PrintListOfAssignmentInJavaFullTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsOfJava();
                    break;
                case '2':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Java Part Time Assignments.");
                    AssignmentsJava.PrintListOfAssignmentInJavaPartTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsOfJava();
                    break;
                case '3':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Java Online Assignments.");
                    AssignmentsJava.PrintListOfAssignmentInJavaOnline();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsOfJava();
                    break;
                case '4':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Java Hybrid Full Time Assignments.");
                    AssignmentsJava.PrintListOfAssignmentInJavaHybridFullTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsOfJava();
                    break;
                case '5':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Java Hybrid Part Time Assignments.");
                    AssignmentsJava.PrintListOfAssignmentInJavaHybridPartTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsOfJava();
                    break;
                case '6':
                    Console.Clear();
                    Console.WriteLine("Go Back.");
                    PrintAssignmentsPerCourse();
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

        }
        protected internal static void PrintAssignmentsOfCSharp()
        {
            Console.WriteLine("Choose Assignments Of C#: ");
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
                    Console.WriteLine("Printing the list of C# Full Time Assignments.");
                    AssignmentsCSharp.PrintListOfAssignmentInCSharpFullTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsOfCSharp();
                    break;
                case '2':
                    Console.Clear();
                    Console.WriteLine("Printing the list of C# Part Time Assignments.");
                    AssignmentsCSharp.PrintListOfAssignmentInCSharpPartTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsOfCSharp();
                    break;
                case '3':
                    Console.Clear();
                    Console.WriteLine("Printing the list of C# Online Assignments.");
                    AssignmentsCSharp.PrintListOfAssignmentInCSharpOnline();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsOfCSharp();
                    break;
                case '4':
                    Console.Clear();
                    Console.WriteLine("Printing the list of C# Hybrid Full Time Assignments.");
                    AssignmentsCSharp.PrintListOfAssignmentInCSharpHybridFullTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsOfCSharp();
                    break;
                case '5':
                    Console.Clear();
                    Console.WriteLine("Printing the list of C# Hybrid Part Time Assignments.");
                    AssignmentsCSharp.PrintListOfAssignmentInCSharpHybridPartTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsOfCSharp();
                    break;
                case '6':
                    Console.Clear();
                    Console.WriteLine("Go Back.");
                    PrintAssignmentsPerCourse();
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

        }
        protected internal static void PrintAssignmentsOfJavaScript()
        {
            Console.WriteLine("Choose Assignments Of JavaScript: ");
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
                    Console.WriteLine("Printing the list of JavaScript Full Time Assignments.");
                    AssignmentsJavaScript.PrintListOfAssignmentInJavaScriptFullTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsOfJavaScript();
                    break;
                case '2':
                    Console.Clear();
                    Console.WriteLine("Printing the list of JavaScript Part Time Assignments.");
                    AssignmentsJavaScript.PrintListOfAssignmentInJavaScriptPartTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsOfJavaScript();
                    break;
                case '3':
                    Console.Clear();
                    Console.WriteLine("Printing the list of JavaScript Online Assignments.");
                    AssignmentsJavaScript.PrintListOfAssignmentInJavaScriptOnline();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsOfJavaScript();
                    break;
                case '4':
                    Console.Clear();
                    Console.WriteLine("Printing the list of JavaScript Hybrid Full Time Assignments.");
                    AssignmentsJavaScript.PrintListOfAssignmentInJavaScriptHybridFullTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsOfJavaScript();
                    break;
                case '5':
                    Console.Clear();
                    Console.WriteLine("Printing the list of JavaScript Hybrid Part Time Assignments.");
                    AssignmentsJavaScript.PrintListOfAssignmentInJavaScriptHybridPartTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsOfJavaScript();
                    break;
                case '6':
                    Console.Clear();
                    Console.WriteLine("Go Back.");
                    PrintAssignmentsPerCourse();
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

        }
        protected internal static void PrintAssignmentsOfPHP()
        {
            Console.WriteLine("Choose Assignments Of PHP: ");
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
                    Console.WriteLine("Printing the list of PHP Full Time Assignments.");
                    AssignmentsPHP.PrintListOfAssignmentInPHPFullTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsOfPHP();
                    break;
                case '2':
                    Console.Clear();
                    Console.WriteLine("Printing the list of PHP Part Time Assignments.");
                    AssignmentsPHP.PrintListOfAssignmentInPHPPartTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsOfPHP();
                    break;
                case '3':
                    Console.Clear();
                    Console.WriteLine("Printing the list of PHP Online Assignments.");
                    AssignmentsPHP.PrintListOfAssignmentInPHPOnline();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsOfPHP();
                    break;
                case '4':
                    Console.Clear();
                    Console.WriteLine("Printing the list of PHP Hybrid Full Time Assignments.");
                    AssignmentsPHP.PrintListOfAssignmentInPHPHybridFullTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsOfPHP();
                    break;
                case '5':
                    Console.Clear();
                    Console.WriteLine("Printing the list of PHP Hybrid Part Time Assignments.");
                    AssignmentsPHP.PrintListOfAssignmentInPHPHybridPartTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsOfPHP();
                    break;
                case '6':
                    Console.Clear();
                    Console.WriteLine("Go Back.");
                    PrintAssignmentsPerCourse();
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

        }
        protected internal static void PrintAssignmentsOfPython()
        {
            Console.WriteLine("Choose Assignments Of Python: ");
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
                    Console.WriteLine("Printing the list of Python Full Time Assignments.");
                    AssignmentsPython.PrintListOfAssignmentInPythonFullTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsOfPython();
                    break;
                case '2':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Python Part Time Assignments.");
                    AssignmentsPython.PrintListOfAssignmentInPythonPartTime();
                    Console.ReadKey();
                    PrintAssignmentsOfPython();
                    break;
                case '3':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Python Online Assignments.");
                    AssignmentsPython.PrintListOfAssignmentInPythonOnline();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsOfPython();
                    break;
                case '4':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Python Hybrid Full Time Assignments.");
                    AssignmentsPython.PrintListOfAssignmentInPythonHybridFullTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsOfPython();
                    break;
                case '5':
                    Console.Clear();
                    Console.WriteLine("Printing the list of Python Hybrid Part Time Assignments.");
                    AssignmentsPython.PrintListOfAssignmentInPythonHybridPartTime();
                    Console.ReadKey();
                    Console.Clear();
                    PrintAssignmentsOfPython();
                    break;
                case '6':
                    Console.Clear();
                    Console.WriteLine("Go Back.");
                    PrintAssignmentsPerCourse();
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }

        }
    }
    
}
