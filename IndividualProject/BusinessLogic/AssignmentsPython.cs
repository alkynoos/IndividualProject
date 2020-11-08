using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.BusinessLogic
{
    class AssignmentsPython
    {
        protected internal static void PrintListOfAssignmentInPythonFullTime()
        {
            List<Assignment> assignmentInPythonFullTime = List.assignments.FindAll(assignment => assignment.AssignmentStream == "Python" && assignment.AssignmentType == "Full Time");
            foreach (var assignment in assignmentInPythonFullTime)
            {
                Console.WriteLine(assignment);
            }
        }

        protected internal static void PrintListOfAssignmentInPythonPartTime()
        {
            List<Assignment> assignmentInPythonPartTime = List.assignments.FindAll(assignment => assignment.AssignmentStream == "Python" && assignment.AssignmentType == "Part Time");
            foreach (var assignment in assignmentInPythonPartTime)
            {
                Console.WriteLine(assignment);
            }
        }

        protected internal static void PrintListOfAssignmentInPythonOnline()
        {
            List<Assignment> assignmentInPythonOnline = List.assignments.FindAll(assignment => assignment.AssignmentStream == "Python" && assignment.AssignmentType == "Online");
            foreach (var assignment in assignmentInPythonOnline)
            {
                Console.WriteLine(assignment);
            }
        }

        protected internal static void PrintListOfAssignmentInPythonHybridFullTime()
        {
            List<Assignment> assignmentInPHPHybridFullTime = List.assignments.FindAll(assignment => assignment.AssignmentStream == "Python" && assignment.AssignmentType == "Hybrid Full Time");
            foreach (var assignment in assignmentInPHPHybridFullTime)
            {
                Console.WriteLine(assignment);
            }
        }

        protected internal static void PrintListOfAssignmentInPythonHybridPartTime()
        {
            List<Assignment> assignmentInPythonHybridPartTime = List.assignments.FindAll(assignment => assignment.AssignmentStream == "Python" && assignment.AssignmentType == "Hybrid Part Time");
            foreach (var assignment in assignmentInPythonHybridPartTime)
            {
                Console.WriteLine(assignment);
            }
        }
    }
}
