using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03__Rock_Paper_Scissors_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random =new Random();

            int playerScore = 0;
            int enemyScore = 0;

            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine();
            while(playerScore!=3 && enemyScore!=3)
            {

                Console.Write("Press 'r' for Rock, 'p' for Paper, 's' for Scissors: ");

                string playerChoice= Console.ReadLine();

                int enemyChoice = random.Next(0, 3);
                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);
                if (enemyChoice == 0)
                {
                    Console.WriteLine("Enemy chooses rock.");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Tie!");
                            break;
                        case "p":
                            Console.WriteLine("Player wins this round!");
                            playerScore++;
                            break;
                        default:
                            Console.WriteLine("Enemy wins this round!");
                            enemyScore++;
                            break;
                    }
                }
                else if (enemyChoice == 1)
                {
                    Console.WriteLine("Enemy chooses paper.");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Enemy wins this round!");
                            enemyScore++;
                            break;
                        case "p":
                            Console.WriteLine("Tie!");
                            break;
                        default:
                            Console.WriteLine("Player wins this round!");
                            playerScore++;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Enemy chooses scissors.");
                    switch (playerChoice)
                    {
                        case "r":
                            Console.WriteLine("Player wins this round!");
                            playerScore++;
                            break;
                        case "p":
                            Console.WriteLine("Enemy wins this round!");
                            enemyScore++;
                            break;
                        default:
                            Console.WriteLine("Tie!");
                            break;
                    }
                }
                Console.WriteLine("Player's Score: " + playerScore + "| Enemy's Score: " + enemyScore);
                Console.WriteLine("-----------------------------------------------");
            }
            if (playerScore == 3)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose! Try Again!");
            }
            Console.WriteLine("                                      ");
            Console.WriteLine("Thank You");
            Console.WriteLine("                                      ");
            Console.WriteLine("--Created by Akshay");
        }
    }
}
