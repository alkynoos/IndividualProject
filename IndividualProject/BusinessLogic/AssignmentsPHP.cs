using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.BusinessLogic
{
    class AssignmentsPHP
    {
        protected internal static void PrintListOfAssignmentInPHPFullTime()
        {
            List<Assignment> assignmentInPHPFullTime = List.assignments.FindAll(assignment => assignment.AssignmentStream == "PHP" && assignment.AssignmentType == "Full Time");
            foreach (var assignment in assignmentInPHPFullTime)
            {
                Console.WriteLine(assignment);
            }
        }

        protected internal static void PrintListOfAssignmentInPHPPartTime()
        {
            List<Assignment> assignmentInPHPPartTime = List.assignments.FindAll(assignment => assignment.AssignmentStream == "PHP" && assignment.AssignmentType == "Part Time");
            foreach (var assignment in assignmentInPHPPartTime)
            {
                Console.WriteLine(assignment);
            }
        }

        protected internal static void PrintListOfAssignmentInPHPOnline()
        {
            List<Assignment> assignmentInPHPOnline = List.assignments.FindAll(assignment => assignment.AssignmentStream == "PHP" && assignment.AssignmentType == "Online");
            foreach (var assignment in assignmentInPHPOnline)
            {
                Console.WriteLine(assignment);
            }
        }

        protected internal static void PrintListOfAssignmentInPHPHybridFullTime()
        {
            List<Assignment> assignmentInPHPHybridFullTime = List.assignments.FindAll(assignment => assignment.AssignmentStream == "PHP" && assignment.AssignmentType == "Hybrid Full Time");
            foreach (var assignment in assignmentInPHPHybridFullTime)
            {
                Console.WriteLine(assignment);
            }
        }

        protected internal static void PrintListOfAssignmentInPHPHybridPartTime()
        {
            List<Assignment> assignmentInPHPHybridPartTime = List.assignments.FindAll(assignment => assignment.AssignmentStream == "PHP" && assignment.AssignmentType == "Hybrid Part Time");
            foreach (var assignment in assignmentInPHPHybridPartTime)
            {
                Console.WriteLine(assignment);
            }
        }
    }
}
