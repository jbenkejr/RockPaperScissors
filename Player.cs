using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors
{
    abstract class Player
    {
        public string Name { get; set; }
        public Roshambo Roshambo { get; set; }

        public Player(string name, Roshambo roshambo)
        {
            Name = name;
            Roshambo = roshambo;
        }

        public Player()
        {

        }
        public abstract Roshambo GenerateRoshambo();
    }
}
