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
            

            CommandPromptUtils cpUtils = new CommandPromptUtils(); 
            List<Trainer> trainers = new List<Trainer>();
            trainers.Add(cpUtils.GetTrainerDetails());            
            cpUtils.PrintTrainersList(trainers);











            //CommandPromptUtils cpUtils = new CommandPromptUtils(); // we need to create the CommandPromptUtils so we can use the methode below
            //Trainer trainer = cpUtils.GetTrainerDetails();
            ////Console.WriteLine(trainer);

            //CommandPromptUtils cpUtils2 = new CommandPromptUtils(); 
            //Trainer trainer2 = cpUtils.GetTrainerDetails();
            //Console.WriteLine(trainer2);

            //Trainer trainer = new Trainer(); // make sure to "call" the currect namespace at the top
            //trainer.FirstName = "G"; // setFirstName set
        }

        // Create appropriate methodes in order to ask from the user date for main classes
    }
}
