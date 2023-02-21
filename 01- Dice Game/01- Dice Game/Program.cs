using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01__Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Dice Game: ");
            Console.WriteLine();
            int playerRandomNumber;
            int enemyRandomNumber;

            int playerPoints=0;
            int enemyPoints=0;

            Random random= new Random();

            for(int i=0; i<6; i++)
            {
                Console.WriteLine("Press any key to roll the dice!");

                Console.ReadKey();

                playerRandomNumber= random.Next(1,7);

                Console.WriteLine("you rolled: "+ playerRandomNumber);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNumber = random.Next(1, 7);

                Console.WriteLine("AI Enemy rolled: " + enemyRandomNumber);
               

                if (playerRandomNumber > enemyRandomNumber)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round!");
                }
                else if (playerRandomNumber < enemyRandomNumber)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round!");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }
                Console.WriteLine("The score is now - Player : " + playerPoints + " | Enemy : " + enemyPoints + ".");
                Console.WriteLine("------------------------------------------------------------");

            }
            if(playerPoints > enemyPoints)
            {
                Console.WriteLine("Player Won!!!");
            }
            else if(enemyPoints > playerPoints)
            {
                Console.WriteLine("Enemy Won!");
            }
            else
            {
                Console.WriteLine("It's a Draw!!");
            }

            Console.WriteLine("                                      ");
            Console.WriteLine("Thank You");
            Console.WriteLine("                                      ");
            Console.WriteLine("--Created by Akshay");
        }
    }
}
