using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.BusinessLogic
{
    class AssignmentsJava
    {

        
        protected internal static  List<Assignment> assignmentInJavaFullTime = List.assignments.FindAll(assignment => assignment.AssignmentStream == "Java" && assignment.AssignmentType == "Full Time");

        protected internal static void PrintListOfAssignmentInJavaFullTime()
        {
            foreach (var assignment in assignmentInJavaFullTime)
            {
                Console.WriteLine(assignment);
            }
        }

        protected internal static void PrintListOfAssignmentInJavaPartTime()
        {
            List<Assignment> assignmentInJavaPartTime = List.assignments.FindAll(assignment => assignment.AssignmentStream == "Java" && assignment.AssignmentType == "Part Time");
            foreach (var assignment in assignmentInJavaPartTime)
            {
                Console.WriteLine(assignment);
            }
        }

        protected internal static void PrintListOfAssignmentInJavaOnline()
        {
            List<Assignment> assignmentInJavaOnline = List.assignments.FindAll(assignment => assignment.AssignmentStream == "Java" && assignment.AssignmentType == "Online");
            foreach (var assignment in assignmentInJavaOnline)
            {
                Console.WriteLine(assignment);
            }
        }

        protected internal static void PrintListOfAssignmentInJavaHybridFullTime()
        {
            List<Assignment> assignmentInJavaHybridFullTime = List.assignments.FindAll(assignment => assignment.AssignmentStream == "Java" && assignment.AssignmentType == "Hybrid Full Time");
            foreach (var assignment in assignmentInJavaHybridFullTime)
            {
                Console.WriteLine(assignment);
            }
        }

        protected internal static void PrintListOfAssignmentInJavaHybridPartTime()
        {
            List<Assignment> assignmentInJavaHybridPartTime = List.assignments.FindAll(assignment => assignment.AssignmentStream == "Java" && assignment.AssignmentType == "Hybrid Part Time");
            foreach (var assignment in assignmentInJavaHybridPartTime)
            {
                Console.WriteLine(assignment);
            }
        }
    }
}
