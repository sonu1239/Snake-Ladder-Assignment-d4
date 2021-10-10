﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnekeAndLadder
{
    class Program
    {
        public const int NO_PLAY = 0;
        public const int LADDER = 1;
        public const int SNAKE = 2;
        public const int FINAL = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the snake and ladder game.");
            Console.WriteLine();
            Console.WriteLine("Player mode:single: Starting position at 0");
            Console.WriteLine("*Start Game*");
            Console.WriteLine();

            //Variables
            int position = 0;
            int count = 0;

            Random die = new Random();     //creatting random object from random class
            Random options = new Random();

            while (position < FINAL)
            {
                int dice = die.Next(1, 7);       //simulating the die throw 
                //Console.WriteLine("The number on this die roll is: " + dice);
                int opt = options.Next(0, 3);    //simulating the options
                count++;                         //counter to count the number of die thrown

                //options use
                if (opt == NO_PLAY)
                {
                    //Console.WriteLine("No play: Player in same position-- " + position);
                }
                else if (opt == LADDER)
                {
                    position = position + dice;
                    if (position > 100)
                    {
                        Console.WriteLine("Try Again, throw exceeded 100!");
                        position = position - dice;
                    }
                    else
                    {
                        Console.WriteLine("Ladder! new postion-- " + position);
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}