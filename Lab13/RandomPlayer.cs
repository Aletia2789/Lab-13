using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    class RandomPlayer : IPlayer
        
    {
        public string Name { get; set; }

        public RandomPlayer(string name)
        {
            Name = name;
        }        
        public RPS GenerateRPS()  
        {
            var random = new Random();
            RPS randomEnum = (RPS)random.Next(0, 3);

            return randomEnum;
        }
    }
}
