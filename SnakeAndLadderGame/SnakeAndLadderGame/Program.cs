using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("=============Welcome To Snake And Ladder Game===============");
            SnakeAndLadder player1 = new SnakeAndLadder();
            SnakeAndLadder player2 = new SnakeAndLadder();
            Console.WriteLine("Player 1: ");
            player1.StartsGame();
            Console.WriteLine("Player 2: ");
            player2.StartsGame();
            player1.TillWin(player2);
            Console.ReadLine();
        }
    }
}
