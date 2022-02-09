using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    internal class SnakeAndLadder
    {
        //Position of player
        private int Position = 0;

        //Random method for class
         Random number = new Random();


        public void StartsGame()
        {
            Console.WriteLine("Your position is "+Position);
        }
        
        //Method To Get Random Number
        public void RandomNumber()
        {
            int Number= number.Next(1, 7);
            Position += Number;
            StartsGame();
            Option(Number);
            Check();
            Console.ReadLine();
        }

        //Method To Get Option For Play
        public void Option(int Number)
        {
            int OptionForPlay = number.Next(0, 3);

            switch (OptionForPlay)
            {
                case 0:
                    Console.WriteLine("No Play");
                    Console.WriteLine("Your Position is same");
                    break;

                case 1:
                    Console.WriteLine("You Got A Ladder!!");
                    Position += Number;
                    StartsGame();
                    break;

                case 2:
                    Console.WriteLine("Oh No!! Snake Trap ");
                    Position -= Number;
                    StartsGame();
                    break;

                default:
                    Console.WriteLine("Error!!");
                    break;

            }

        }
        private void Check()
        {
            if (Position < 0)
                Position = 0;
            else if (Position >= 100)
                Position = 100;
        }


         //Method for Player Till It Reaches Winning Position}
            public void TillWin()
        {
            while (Position < 100) ;
            RandomNumber();
            Console.WriteLine("\nCongratulations!! You Won!!");
        }


    }
}
