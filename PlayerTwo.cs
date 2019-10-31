using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors
{
    class PlayerTwo : Player
    {
        public PlayerTwo(string name, Roshambo roshambo) : base(name, roshambo)
        {
           
        }

        public PlayerTwo()
        {

        }


        public override Roshambo GenerateRoshambo()
        {
            Random random = new Random();

            Array value = Enum.GetValues(typeof(Roshambo));            
            return (Roshambo)value.GetValue(random.Next(value.Length));        
        }
    }
}
