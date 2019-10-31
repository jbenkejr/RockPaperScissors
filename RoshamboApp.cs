using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors
{
    class RoshamboApp
    {
        public PlayerOne Player1 { get; set; }
        public PlayerTwo Player2 { get; set; }

        public RoshamboApp(PlayerOne player1, PlayerTwo player2)
        {
            Player1 = player1;
            Player2 = player2;
        }

        public RoshamboApp()
        {

        }

        

        public Player PlayMatchUp()
        {

            var result = WinningHand(Player1.Roshambo, Player2.Roshambo);

            if (Player1.GenerateRoshambo() == result)
            {
                return Player1;
            }

            if (Player2.GenerateRoshambo() == result)
            {
                return Player2;
            }

            return PlayMatchUp();

        }
        public Roshambo WinningHand(Roshambo p1, Roshambo p2)
        {
            if (p1 == Roshambo.Paper && p2 == Roshambo.Rock)
            {
                return Roshambo.Paper;
            }

            if (p1 == Roshambo.Paper && p2 == Roshambo.Scissors)
            {
                return Roshambo.Scissors;
            }

            if (p1 == Roshambo.Scissors && p2 == Roshambo.Paper)
            {
                return Roshambo.Scissors;
            }

            if (p1 == Roshambo.Scissors && p2 == Roshambo.Rock)
            {
                return Roshambo.Rock;
            }

            if (p1 == Roshambo.Rock && p2 == Roshambo.Paper)
            {
                return Roshambo.Paper;
            }

            if (p1 == Roshambo.Rock && p2 == Roshambo.Scissors)
            {
                return Roshambo.Rock;
            }

            return 0;
        }
    }
}
