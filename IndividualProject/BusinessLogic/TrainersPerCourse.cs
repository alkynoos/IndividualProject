using IndividualProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject.BusinessLogic
{
    class TrainersPerCourse
    {
        
        protected internal static void PrintListOfJavaTrainer()
        {
            List<Trainer> trainersInJava = List.trainers.FindAll(trainer => trainer.Subject == "Java");
            foreach (var trainer in trainersInJava)
            {
                Console.WriteLine(trainer);
            }
        }
        protected internal static void PrintListOfCSharpTrainer()
        {
            List<Trainer> trainersInCSharp = List.trainers.FindAll(trainer => trainer.Subject == "C#");
            foreach (var trainer in trainersInCSharp)
            {
                Console.WriteLine(trainer);
            }
        }
        
        protected internal static void PrintListOfJavaScriptTrainer()
        {
            List<Trainer> trainersInJavaScript = List.trainers.FindAll(trainer => trainer.Subject == "JavaScript");
            foreach (var trainer in trainersInJavaScript)
            {
                Console.WriteLine(trainer);
            }
        }
        protected internal static void PrintListOfPHPTrainer()
        {
            List<Trainer> trainersInPHP = List.trainers.FindAll(trainer => trainer.Subject == "PHP");
            foreach (var trainer in trainersInPHP)
            {
                Console.WriteLine(trainer);
            }
        }
        protected internal static void PrintListOfPythonTrainer()
        {
            List<Trainer> trainersInPython = List.trainers.FindAll(trainer => trainer.Subject == "Python");
            foreach (var trainer in trainersInPython)
            {
                Console.WriteLine(trainer);
            }
        }
    }
}
