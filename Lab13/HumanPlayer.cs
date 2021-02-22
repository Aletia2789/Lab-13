using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    class HumanPlayer : IPlayer

    {
        public HumanPlayer(string name)
        {
            Name = name;
        }
        public string Name { get;  set; }
              
        public RPS GenerateRPS()
        {
            Console.WriteLine("Please select one of the following choices: \n 1=Rock \n 2=Paper \n 3=Scissors ");
            string choice = Console.ReadLine();
            while (choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("Sorry, " + choice + " is not an option. \nPlease select one of the following choices: \n 1=Rock \n 2=Paper \n 3=Scissors ");
                choice = Console.ReadLine();
            }
            switch (choice)
            {
                case "1":     
                    return RPS.rock;
                    break;
                
                case "2":
                    return RPS.paper;
                    break;
               
                case "3":
                    return RPS.scissors;
                    break;
                
                default:
                    return RPS.rock;

            }
        }
        
    }
}
