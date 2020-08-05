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
        public void Run()
        {
            //bool quit;

            //do
            {
                startGame();
                leaveChoice();
                planetChoice();
               
               

            } 
            //while (!quit);


            Console.WriteLine(); // Ensures "press any key to quit..." is on its own line
        }

        public void startGame()
        { 
            // Start by asking for the user's name:
            Print("What is your name?: ");
            string name = Console.ReadLine();
            Print($"Hello, {name}! Welcome to your story.");
            
           
        }
        public void leaveChoice()
        {
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

                    try
                    {
                        StreamReader sr = new StreamReader(@"C:\Users\bulld\Desktop\MSSA Program Files\spaceship.txt");
                        line = sr.ReadLine();
                        while (line != null)
                        {
                            Print(line, 1);
                            line = sr.ReadLine();
                        }
                        sr.Close();                    
                        Print("You've borded the ship and the crew is already on board. Choose your destinantion");
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
        public void planetChoice()
        {
            
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
    
        void actionChoice()
        {
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

        public void chestChoice()
        {
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
        public static void Print(string text, int speed = 80)
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
