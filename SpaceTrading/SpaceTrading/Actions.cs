﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Numerics;

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
                planetChoiceA();
               
               

            } 
            //while (!quit);


            Console.WriteLine(); // Ensures "press any key to quit..." is on its own line
        }

        public void startGame()
        { 
            // Start by asking for the user's name:
            
            string line;
            Print("What is your name?: ");
            string name = Console.ReadLine();
            Print($"Hello, {name}! Welcome to your story.");
            try
                    {
                        StreamReader sr = new StreamReader(@"C:\Users\bulld\source\repos\SpaceTradingGame\SpaceTrading\spaceship.txt");
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
                        //Print("You've boarded the ship and the crew is already on board. Choose your destinantion");
                        //Print("Type X or Y:");
                    
                    try
                    {
                        StreamReader sr = new StreamReader(@"C:\Users\bulld\source\repos\SpaceTradingGame\SpaceTrading\blastoff.txt");
                        line = sr.ReadLine();
                        while (line != null)
                        {
                            Print(line, 1);
                            line = sr.ReadLine();
                        }
                        sr.Close();
                        Print("You've boarded the ship with your computerized crew. Choose your destinantion");
                        Print("Enter A)mazonia, D)ecapod10, E)arth, 6)Tarantulon6, 9)Thuban9, T)ornadus !");
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
        public void planetChoiceA()
        {

            string planetChoiceA = Console.ReadLine().ToUpper();
            if (planetChoiceA == "A")
            {
                try
                {
                    string line;
                    StreamReader sr = new StreamReader(@"C:\Users\bulld\source\repos\SpaceTradingGame\SpaceTrading\amazonia.txt");
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
                
                Print("You have chosen Planet Amazonia. You set auto-pilot and land safely. The planet has a mall filled with scavenger trading posts. A savage scavenger appears. What do you do?!?");
                actionChoiceA();
            }

        }
        public void planetChoiceD()
        {

            string planetChoiceD = Console.ReadLine().ToUpper();
            if (planetChoiceD == "D")
            {
                try
                {
                    string line;
                    StreamReader sr = new StreamReader(@"C:\Users\bulld\source\repos\SpaceTradingGame\SpaceTrading\amazonia.txt");
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

                Print("You have chosen Planet Decapod10. You set auto-pilot and land somewhat safely. The planet has no human life but is filled with Egg-Like Pods. What do you do?!?");
                actionChoiceB();
            }

        }
        public void planetChoiceE()
        {

            string planetChoiceE = Console.ReadLine().ToUpper();
            if (planetChoiceE == "E")
            {
                try
                {
                    string line;
                    StreamReader sr = new StreamReader(@"C:\Users\bulld\source\repos\SpaceTradingGame\SpaceTrading\amazonia.txt");
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

                Print("You have chosen Planet Earth. You set auto-pilot and head towards planet Earth. Due to the amount of deliveries you have, you conduct a intergalactic U-Turn because you know better!!!");

            }

        }
        public void planetChoiceT()
        {

            string planetChoiceT = Console.ReadLine().ToUpper();
            if (planetChoiceT == "T")
            {
                try
                {
                    string line;
                    StreamReader sr = new StreamReader(@"C:\Users\bulld\source\repos\SpaceTradingGame\SpaceTrading\amazonia.txt");
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

                Print("You have chosen Planet Tornadus. You enter a space storm near the planet. The space storm destroys the ship in route and YOU suffer a excruciating prolonged death! Time moves extremely slow! Your last remaining words were 'Why would I choose to go to a planet called Torn....'. As you try to speak your last living words, a space snake strikes your tongue and crawls inside your body. The only living thing in your spacesuit now is the space snake. RIP Explorer!!!!");
            }

        }

        public void actionChoiceA()
        {
 
            Print("You have two options. K)ill Scavenger   OR  T)rade with Scavenger");
            Print("Type your answer:");
                
           using StreamReader sr = new StreamReader(@"C:\Users\bulld\source\repos\SpaceTradingGame\SpaceTrading\alienA.txt");
            string line;
            do
            {
                line = sr.ReadLine();
                Console.WriteLine(line);
            } while (line != null);

            
            string actionChoiceA = Console.ReadLine().ToUpper();
            try
            {
                if (actionChoiceA == "K")
                {
                    Print("You cannot kill the scavenger. Apparently, they are immune to death!");
                    Print("You were flayed and battered.");
                    Print("Rest In Peace Fellow Explorer! Try not to be so violent!");

                }
                else if (actionChoiceA == "T")
                {
                    Print("You can Trade Currency for the following:");
                    Print("A)Liquid IV | B)Fuel | C)Food | D)Deliver Package");
                    tradeChoiceA();

                }
            }
            catch
            {
                throw new SystemException();
            }
          
        }

        public void actionChoiceB()
        {

            Print("You have two options. D)rop Package off on a Pod   OR  C)ut into Pod because your curious!");
            Print("Type your answer:");

            using StreamReader sr = new StreamReader(@"C:\Users\bulld\source\repos\SpaceTradingGame\SpaceTrading\alienA.txt");
            string line;
            do
            {
                line = sr.ReadLine();
                Console.WriteLine(line);
            } while (line != null);


            string actionChoiceA = Console.ReadLine().ToUpper();
            try
            {
                if (actionChoiceA == "D")
                {
                    Print("The Pod Opens up and drops extra currency from excitement from its awaited package. You return to the ship! Superb Job!!");
                    Print("You were flayed and battered.");
                    Print("Rest In Peace Fellow Explorer! Try not to be so violent!");
                }
                else if (actionChoiceA == "C")
                {
                    Print("The Pod Opens up and a long tailed snake creature crawls out! As it smiles at you, you feel a sense of self-worth. This creature was created just like all creatures. The difference is.....");
                    Print("This specific creature was made to eat human faces. It swiftly attaches to your space helmet and melds into the glass! This instantly kills you!");
                    Print("RIP Explorer but why would you cut into a Pod? Now you have to start all over!!!!!!!!!!");
                    leaveChoice();
                }
            }
            catch
            {
                throw new SystemException();
            }

        }
        public void tradeChoiceA()
        {
            string tradeChoiceA = Console.ReadLine().ToUpper();
            switch (tradeChoiceA)
            {
                case "A":
                    Print("You have successfully cured your current thirst!");
                    break;
                case "B":
                    Print("You have successfully topped off your spaceship with fresh fuel!");
                    break;
                case "C":
                    Print("You have sucessfully cured your current hunger!");
                    break;
                case "D":
                    Print("You just handed the Package (unknowingly) to the scavenger. It was awaiting the package all along. It makes sense why the Scavenger appeared so quickly. Happy that you successfully delivered the package without dying. You return to the ship!");
                    try
                    {
                        string line;
                        StreamReader sr = new StreamReader(@"C:\Users\bulld\source\repos\SpaceTradingGame\SpaceTrading\blastoff.txt");
                        line = sr.ReadLine();
                        while (line != null)
                        {
                            Print(line, 1);
                            line = sr.ReadLine();
                        }
                        sr.Close();
                        Print("You've boarded the ship with your computerized crew. Choose your next destinantion");
                        Print("Enter D)ecapod10, E)arth, 6)Tarantulon6, 9)Thuban9, T)ornadus !");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: " + e.Message);
                    }
                    break;
                default:
                    break;
            }
        }
        public static void Print(string text, int speed = 1)
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
