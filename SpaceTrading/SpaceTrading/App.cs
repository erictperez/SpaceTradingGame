﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrading
{
    public enum QuitReason { DontQuit, UserQuit, Age, OutOfMoney };
    class App
    {
        List<Location> locations = new List<Location>();
        Location currentLocation;
        public App()
        {
            locations.Add(new Location("Earth", "A pretty boring planet. Everybody wears diapers.", 0, 0));
            currentLocation = locations[0];
        }
        public void Run()
        {
            Actions.startGame();
            Actions.leaveChoice();
            Actions.planetChoiceA();
            eventLoop();
            Actions.closingMessage();

            Console.WriteLine(); // Ensures "press any key to quit..." is on its own line
        }
        public QuitReason eventLoop()
        {
            var quitReason = QuitReason.DontQuit;
            do
            {
                Console.Clear();
                // print current location
                Console.WriteLine($"Welcome to: {currentLocation.name}, {currentLocation.description}");
                var key = UI.EllicitInput();
                quitReason = HandleInput(key);
                PrintOptionList();
               
            }
            while (quitReason == QuitReason.DontQuit);
            return quitReason;
        }

        private void PrintOptionList()
        {
            Console.WriteLine();
            Console.WriteLine("1. Travel to Other Locations");
            Console.WriteLine("q. to quit");
        }

        public QuitReason HandleInput(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.Q:
                    return QuitReason.UserQuit;
                case ConsoleKey.D1:
                    TravelMenu();
                    break;
            }
            return QuitReason.DontQuit;
        }

        private void TravelMenu()
        {
            Console.WriteLine("Travel to: ");
            for (int i = 0; i < locations.Count; i++)
            {
                Location destination = locations[i];

                var distance = currentLocation.DistanceTo(destination);
                Console.WriteLine($"(i + 1). {destination.name}: {distance}ly \n");
            }
        }
    }
}
