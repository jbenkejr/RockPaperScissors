using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors
{
    class PlayerThree : Player
    {
        public PlayerThree(string name, Roshambo roshambo) : base(name, roshambo)
        {
        
        }
        
        public PlayerThree()
        {

        }

        public static int GetUserInput()
        {
            Console.Write("Rock Paper or Scissors (1/2/3): ");
            int input = int.Parse(Console.ReadLine());
            return input;

        }
        public override Roshambo GenerateRoshambo()
        {
            Roshambo userChoice = (Roshambo)Convert.ToInt32(GetUserInput());

            return userChoice;
        }
    }
}
