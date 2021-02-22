using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    class RockPlayer : IPlayer
    {
        public string Name { get; set; }

        public RockPlayer(string name)
        {
            Name = name;
        }
        public RPS GenerateRPS()
        {
            return RPS.rock;
        }
    }
}
