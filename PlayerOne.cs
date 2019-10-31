using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors
{
    class PlayerOne : Player
    {
        public PlayerOne(string name, Roshambo roshambo) : base(name, roshambo)
        {
           
        }

        public PlayerOne()
        {

        }

        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
    }
}
