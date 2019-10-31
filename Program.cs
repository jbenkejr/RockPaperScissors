using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Rock Paper Scissors game! ");

          //  Player p = new PlayerThree();
            RoshamboApp roshambo = new RoshamboApp();

            roshambo.PlayMatchUp();
            

            //Console.Write("Enter your name: ");
            //string userName = Console.ReadLine();

            

        }
    }
}
