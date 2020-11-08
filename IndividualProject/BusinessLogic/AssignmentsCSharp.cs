using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.BusinessLogic
{
    class AssignmentsCSharp
    {
        protected internal static void PrintListOfAssignmentInCSharpFullTime()
        {
            List<Assignment> assignmentInCSharpFullTime = List.assignments.FindAll(assignment => assignment.AssignmentStream == "C#" && assignment.AssignmentType == "Full Time");
            foreach (var assignment in assignmentInCSharpFullTime)
            {
                Console.WriteLine(assignment);
            }
        }

        protected internal static void PrintListOfAssignmentInCSharpPartTime()
        {
            List<Assignment> assignmentInCSharpPartTime = List.assignments.FindAll(assignment => assignment.AssignmentStream == "C#" && assignment.AssignmentType == "Part Time");
            foreach (var assignment in assignmentInCSharpPartTime)
            {
                Console.WriteLine(assignment);
            }
        }

        protected internal static void PrintListOfAssignmentInCSharpOnline()
        {
            List<Assignment> assignmentInCSharpOnline = List.assignments.FindAll(assignment => assignment.AssignmentStream == "C#" && assignment.AssignmentType == "Online");
            foreach (var assignment in assignmentInCSharpOnline)
            {
                Console.WriteLine(assignment);
            }
        }

        protected internal static void PrintListOfAssignmentInCSharpHybridFullTime()
        {
            List<Assignment> assignmentInCSharpHybridFullTime = List.assignments.FindAll(assignment => assignment.AssignmentStream == "C#" && assignment.AssignmentType == "Hybrid Full Time");
            foreach (var assignment in assignmentInCSharpHybridFullTime)
            {
                Console.WriteLine(assignment);
            }
        }

        protected internal static void PrintListOfAssignmentInCSharpHybridPartTime()
        {
            List<Assignment> assignmentInCSharpHybridPartTime = List.assignments.FindAll(assignment => assignment.AssignmentStream == "C#" && assignment.AssignmentType == "Hybrid Part Time");
            foreach (var assignment in assignmentInCSharpHybridPartTime)
            {
                Console.WriteLine(assignment);
            }
        }
    }
}
