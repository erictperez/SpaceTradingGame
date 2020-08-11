using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.IO;

namespace SpaceTrading
{
    class Actions
    {
        public Actions()
        {

        }
        public static void closingMessage(QuitReason quitReason)
        {
            Console.Clear();
            switch (quitReason)
            {

                case QuitReason.UserQuit:
                    Console.WriteLine("See you later.... \n\n");
                    break;
                case QuitReason.Age:
                    Console.WriteLine("You are too old \n\n");
                    break;
                case QuitReason.OutOfMoney:
                    Console.WriteLine("Youre broke $ 0.00  \n\n");
                    break;
                case QuitReason.DontQuit:
                    throw new NotImplementedException("No quitting");
                    break;
            }

             static void startGame()
            {
                Console.Clear();
                // Start by asking for the user's name:
                string line;
                Print("What is your name?: ");
                string name = Console.ReadLine();
                Print($"Hello, {name}! Welcome to your story.");
                try
                {
                    StreamReader sr = new StreamReader(@"..\..\..\..\spaceship.txt");
                    line = sr.ReadLine();
                    while (line != null)
                    {
                        Print(line, 1);
                        line = sr.ReadLine();
                    }
                    sr.Close();

                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }

            }
            static void leaveChoice()
            {
                Console.Clear();
                Print("Are you ready to take off?");
                Console.Write("Type YES or NO: ");
                string leaveChoice = Console.ReadLine();
                string upperChoice = leaveChoice.ToUpper();
                string line;
                try
                {
                    if (upperChoice == "NO")
                    {
                        Print("Not much of an adventure.");
                    }
                    else if (upperChoice == "YES")
                    {
                        //Print("You've boarded the ship and the crew is already on board. Choose your destinantion");
                        //Print("Type X or Y:");

                        try
                        {
                            StreamReader sr = new StreamReader(@"..\..\..\..\blastoff.txt");
                            line = sr.ReadLine();
                            while (line != null)
                            {
                                Print(line, 1);
                                line = sr.ReadLine();
                            }
                            sr.Close();
                            Print("You've boarded the ship with your computerized crew. Choose your destinantion");
                            Print("Type X or Y:");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Exception: " + e.Message);
                        }

                    }

                }
                catch
                {
                    throw new SystemException();
                }

            }
           static void planetChoice()
            {
                Console.Clear();
                string planetChoice = Console.ReadLine().ToUpper();
                if (planetChoice == "X")
                {
                    Print("You've landed on planet X, the locals are hostile, Will you fight!?!");
                    Print("Type your answer:");
                    actionChoice();
                }
                else if (planetChoice == "Y")
                {
                    Print("You've landed on planet Y, the locals are offer you a choice of three treasure chest, which one will you take!?!");
                    Print("Enter a number (1-3):");
                    chestChoice();

                }
            }

             static void actionChoice()
            {
                Console.Clear();
                string actionChoice = Console.ReadLine().ToUpper();
                try
                {
                    if (actionChoice == "YES")
                    {
                        Print("You successfully bludgeon all the locals. You now have your payment and some extra gas.");
                    }
                    else
                    {
                        Print("You were flayed and battered.");
                    }
                }
                catch
                {
                    throw new SystemException();
                }

            }

             static void chestChoice()
            {
                Console.Clear();
                string chestChoice = Console.ReadLine();
                switch (chestChoice)
                {
                    case "1":
                        Print("You choose the first chest. Lucky choice! There is 200 space dollars");
                        break;
                    case "2":
                        Print("You choose the second chest. A space snake bit you and you died.");
                        break;
                    case "3":
                        Print("You choose the third chest. It is empty.....");
                        break;
                    default:
                        break;
                }
            }
           static void Print(string text, int speed = 1)
            {
                foreach (char c in text)
                {
                    Console.Write(c);
                    System.Threading.Thread.Sleep(speed);
                }
                Console.WriteLine();
            }
        }
    }
}