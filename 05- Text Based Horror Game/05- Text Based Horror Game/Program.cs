using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05__Text_Based_Horror_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Haunted Mansion!");
            Console.WriteLine();
            Console.WriteLine("You are a distant family member of a rich millionaire who has just passed away, leaving this mansion to you.");
            Console.WriteLine("Now that you are the newfound owner, you decide to take a look inside.");
            Console.WriteLine("The house is out-dated, creaky, and falling apart. You walk in the front door.");
            Console.WriteLine();
            Console.WriteLine("Do you want to enter the living room or the dining room?");
            Console.WriteLine("Press '1' for the living Room and '2' for the dining room: ");
            // ask player to choose a way
            Console.Write("> ");
            string roomChoice = Console.ReadLine();

            
            if (roomChoice == "1")
            {
                Console.WriteLine("You chose to go into the living room.");
                Console.WriteLine("As you walk in, you see a sleeping pitbull guarding some gold jewelry.");
                Console.WriteLine("Do you want to steal the jewelry?");
                Console.WriteLine("Press 'y' for yes or 'n' for no: ");
                // asks a user to enter their choice
                Console.Write("> ");
                string pitBullChoice = Console.ReadLine();

                if (pitBullChoice == "y")
                {
                    Console.WriteLine("You attempt to steal the jewelry, but the pitbull wakes up and rips you to shreds.");
                    Console.WriteLine("You have now died.");
                    Console.WriteLine("Greed destroys the Soul!");
                }
                else if (pitBullChoice == "n")
                {
                    Console.WriteLine("You decide not to steal the dog's jewelry.");
                    Console.WriteLine("Your turn back and find your way out of the house safely.");
                    Console.WriteLine("Life is more than Anything!");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please answer yes or no.");
                }
            }
            else if (roomChoice == "2")
            {
                Console.WriteLine("You chose to go into the dining room.");
                Console.WriteLine("As you walk in, you see a shiny vase on the table");
                Console.WriteLine("Do you want to open it?");
                Console.WriteLine("Press 'y' for yes or 'n' for no: ");
                // asks a user to enter their choice
                Console.Write("> ");
                string vaseChoice = Console.ReadLine();

                if (vaseChoice == "y")
                {
                    Console.WriteLine("You open the vase and find a pile of bones!");
                }
                else if (vaseChoice == "n")
                {
                    Console.WriteLine("You decide not to open the vase.");
                    Console.WriteLine("As you turn to leave, you hear a cracking sound coming from the corner");
                    Console.WriteLine("A dark figure with glowing red eyes launches at you, knocking you unconcious");
                    Console.WriteLine("You wake up in your bed. It was all a dream!!! ");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please answer yes or no.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please answer living room or dining room.");
            }
            Console.WriteLine("                                      ");
            Console.WriteLine("Thank You");
            Console.WriteLine("                                      ");
            Console.WriteLine("--Created by Akshay");
        }

    }
}
