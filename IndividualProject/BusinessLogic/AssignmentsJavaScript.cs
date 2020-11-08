using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.BusinessLogic
{
    class AssignmentsJavaScript
    {
        protected internal static void PrintListOfAssignmentInJavaScriptFullTime()
        {
            List<Assignment> assignmentInJavaScriptFullTime = List.assignments.FindAll(assignment => assignment.AssignmentStream == "JavaScript" && assignment.AssignmentType == "Full Time");
            foreach (var assignment in assignmentInJavaScriptFullTime)
            {
                Console.WriteLine(assignment);
            }
        }

        protected internal static void PrintListOfAssignmentInJavaScriptPartTime()
        {
            List<Assignment> assignmentInJavaScriptPartTime = List.assignments.FindAll(assignment => assignment.AssignmentStream == "JavaScript" && assignment.AssignmentType == "Part Time");
            foreach (var assignment in assignmentInJavaScriptPartTime)
            {
                Console.WriteLine(assignment);
            }
        }

        protected internal static void PrintListOfAssignmentInJavaScriptOnline()
        {
            List<Assignment> assignmentInJavaScriptOnline = List.assignments.FindAll(assignment => assignment.AssignmentStream == "JavaScript" && assignment.AssignmentType == "Online");
            foreach (var assignment in assignmentInJavaScriptOnline)
            {
                Console.WriteLine(assignment);
            }
        }

        protected internal static void PrintListOfAssignmentInJavaScriptHybridFullTime()
        {
            List<Assignment> assignmentInJavaScriptHybridFullTime = List.assignments.FindAll(assignment => assignment.AssignmentStream == "JavaScript" && assignment.AssignmentType == "Hybrid Full Time");
            foreach (var assignment in assignmentInJavaScriptHybridFullTime)
            {
                Console.WriteLine(assignment);
            }
        }

        protected internal static void PrintListOfAssignmentInJavaScriptHybridPartTime()
        {
            List<Assignment> assignmentInJavaScriptHybridPartTime = List.assignments.FindAll(assignment => assignment.AssignmentStream == "JavaScript" && assignment.AssignmentType == "Hybrid Part Time");
            foreach (var assignment in assignmentInJavaScriptHybridPartTime)
            {
                Console.WriteLine(assignment);
            }
        }
    }
}
