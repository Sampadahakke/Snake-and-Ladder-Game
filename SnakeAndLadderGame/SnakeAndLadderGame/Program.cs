﻿using System;
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
            SnakeAndLadder snake = new SnakeAndLadder();    
            snake.StartsGame();
            Console.ReadLine();
        }
    }
}
