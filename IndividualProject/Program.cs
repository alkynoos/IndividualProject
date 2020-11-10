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
            //ConsoleMenu.Menu();

            // o kodikas katw apo edw einai gia na "testerw" pio eykola ekei pou exw problima

            Console.WriteLine("Testing");
            Console.WriteLine("populating the lists with data");
            SyntheticData.SendSyntheticDataToMemu();

            Console.ReadLine();

            Console.WriteLine("print other list to confirm list contain objects");
            CommandPromptUtils.PrintTrainersList(List.trainers);

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Print the full assignments list");
            CommandPromptUtils.PrintAssignmentsList(List.assignments);

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("using the method");
            AssignmentsJava.PrintListOfAssignmentInJavaFullTime();//-------------------------> auto einai opws to kalo apo th class

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Callign .FindAll Direct at Main");
            List<Assignment> testList = new List<Assignment>(List.assignments.FindAll(x => x.AssignmentStream.Equals("Java") && x.AssignmentType.Equals("Full Time"))); //-----> etsi to grafw sth class 


            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Using for loop at Main");// ------------------. pospa8w to idio me for

            if (List.assignments.Count != 0)
            {
                for (int i = 0; i < List.assignments.Count; i++)
                {
                    if ((List.assignments[i].AssignmentStream.Equals("Java")) && (List.assignments[i].AssignmentType.Equals("Full Time")))
                    {
                        AssignmentsJava.assignmentInJavaFullTime.Add(List.assignments[i]);
                    }
                }
                foreach (var assignment in AssignmentsJava.assignmentInJavaFullTime)
                {
                    Console.WriteLine(assignment);
                }
            }
            else
            {
                Console.WriteLine("No entry found");
            }

            Console.ReadLine();
            Console.Clear();



            Console.WriteLine("trying with other lesson");
            Assignment javaStudent = List.assignments.Find(x => x.AssignmentStream == "C#" && x.AssignmentType == "Full Time");







        }

    }
}
