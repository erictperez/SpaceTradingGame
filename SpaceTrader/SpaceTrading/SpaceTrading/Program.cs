﻿using System;

namespace SpaceTrading
{
    class Program
    {
        enum { X, Y};
        static void Main(string[] args)
        {
            
            {
                System.Console.SetWindowSize

                // Start by asking for the user's name:
                Console.Write("What is your name?: ");
                string name = Console.ReadLine();
                Console.WriteLine($"Hello, {name}! Welcome to your story.");
                Console.WriteLine("Are you ready to take off?");
                Console.Write("Type YES or NO: ");
                string leaveChoice = Console.ReadLine();
                string upperChoice = leaveChoice.ToUpper();
                if (upperChoice == "NO")
                {
                    Console.WriteLine("Not much of an adventure.");
                }
                else if (upperChoice == "YES")
                {
                    Console.WriteLine("You've borded the ship and the crew is already on board. Choose your destinantion");
                    Console.Write("Type X or Y:");
                }
                string planetChoice = Console.ReadLine().ToUpper();
                if (planetChoice == "X")
                {
                    Console.WriteLine("You've landed on planet X, the locals are hostile, Will you fight!?!");
                    Console.Write("Type your answer:");

                }
                else if (planetChoice == "Y")
                {
                    Console.WriteLine("You've landed on planet Y, the locals are offer you a choice of three treasure chest, which one will you take!?!");
                    Console.Write("Enter a number (1-3):");
                }
                string actionChoice = Console.ReadLine().ToUpper();
                string chestChoice = Console.ReadLine();
                if (actionChoice == "YES")
                {
                    Console.WriteLine("You successfully bludgeon all the locals. You now have your payment and some extra gas.");
                }
                else
                {
                    Console.WriteLine("You were flayed and battered.");
                }

                switch (chestChoice)
                {
                    case "1":
                        Console.WriteLine("You choose the first chest. Lucky choice! There is 200 space dollars");
                        break;
                    case "2":
                        Console.WriteLine("You choose the second chest. A space snake bit you and you died.");
                        break;
                    case "3":
                        Console.WriteLine("You choose the third chest. It is empty.....");
                        break;
                    default:
                        break;
                }
               
            }
        }
    }




}
 