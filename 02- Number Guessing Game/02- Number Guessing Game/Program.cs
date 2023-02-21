﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02__Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectGuess = false;
            Random random = new Random();

            int randomNumber = random.Next(1, 11);

            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("A number between 1 and 10 is generated.");
            Console.WriteLine("If you guess the correct number, you win!");

            while (!isCorrectGuess)
            {
                Console.WriteLine("Please enter your guess.");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > randomNumber)
                {
                    Console.WriteLine("Your guess is too high!");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Your guess is too low!");
                }
                else
                {
                    Console.WriteLine("Correct!");
                    isCorrectGuess = true;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Congratulations, you have won the game!");
            Console.WriteLine("                                      ");
            Console.WriteLine("Thank You");
            Console.WriteLine("                                      ");
            Console.WriteLine("--Created by Akshay");
            Console.WriteLine();
        }
    }
}
