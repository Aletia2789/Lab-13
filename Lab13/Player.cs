using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    interface IPlayer
    {
        public string Name { get; set; }

        public RPS GenerateRPS();

    }

}
