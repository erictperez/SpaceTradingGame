using System;
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
            //var quitReason = eventLoop();
            //Actions.closingMessage(quitReason);

            Console.WriteLine(); // Ensures "press any key to quit..." is on its own line
        }
        private QuitReason EventLoop()

        {

            QuitReason quitReason;



            do

            {

                Console.Clear();



                // Print the current location

                Console.WriteLine($"Location: {hero.location.name}    Age: {hero.age:f2} years    Credits: {hero.money:f1}\n");



                // Print a description of that location

                Console.WriteLine(hero.location.description);



                // Provide options to the user re. things they can do

                PrintOptionList();



                var key = UI.ElicitInput();



                quitReason = ShouldQuit(HandleInput(key));

            } while (quitReason == QuitReason.DontQuit);



            return quitReason;

        }



        private QuitReason ShouldQuit(QuitReason quitReason)

        {

            QuitReason AgeCheck() => hero.age >= 70 ? QuitReason.Age : QuitReason.DontQuit;

            QuitReason MoneyCheck() => hero.money < 0 ? QuitReason.OutOfMoney : QuitReason.DontQuit;





            if (quitReason == QuitReason.DontQuit)

            {

                quitReason = AgeCheck();

            }



            if (quitReason == QuitReason.DontQuit)

            {

                quitReason = MoneyCheck();

            }



            return quitReason;

        }



        private void PrintOptionList()

        {

            Console.WriteLine();

            Console.WriteLine("1. Travel to other locations");

            Console.WriteLine("2. Buy items");

            Console.WriteLine("3. Sell items");

            Console.WriteLine("q. Quit");

        }



        private QuitReason HandleInput(ConsoleKey key)

        {

            switch (key)

            {

                case ConsoleKey.Q:

                    return QuitReason.UserQuit;

                case ConsoleKey.D1:

                    TravelMenu();

                    break;

                case ConsoleKey.D2:

                    BuyMenu();

                    break;

                case ConsoleKey.D3:

                    SellMenu();

                    break;

            }



            return QuitReason.DontQuit;

        }



        private void SellMenu()

        {

            Console.Clear();



            if (hero.inventory.Any())

            {

                PrintItems(hero.inventory);



                var itemIndex = UI.ElicitInput("Which item would you like to sell: ", 1, hero.inventory.Count);



                if (!itemIndex.cancelled)

                {

                    hero.SellItem(hero.inventory[itemIndex.input - 1]);

                }

            }

            else

            {

                Console.WriteLine("Nothing to sell...");

                UI.ElicitInput("Press any key to continue...");

            }

        }



        private void BuyMenu()

        {

            Console.Clear();



            List<Item> items = hero.location.items;



            PrintItems(items);



            var itemIndex = UI.ElicitInput("Which item would you like to buy: ", 1, items.Count);



            if (!itemIndex.cancelled)

            {

                hero.BuyItem(items[itemIndex.input - 1]);

            }

        }



        private void PrintItems(List<Item> items)

        {

            for (int i = 0; i < items.Count; ++i)

            {

                var item = items[i];

                var cost = hero.location.CostOf(item);



                Console.WriteLine($"{i + 1}. {item.name} - {cost:f2}cr");

            }

        }



        private void TravelMenu()

        {

            var done = false;

            int selector = 0;

            int count = locations.Count;



            do

            {

                Console.Clear();

                Console.WriteLine("Travel to:");



                PrintLocationsAndDistances(selector);



                var key = UI.ElicitInput("");





                switch (key)

                {

                    case ConsoleKey.DownArrow:

                        selector++;

                        selector %= count;

                        break;

                    case ConsoleKey.UpArrow:

                        selector--;

                        selector = (selector + count) % count;

                        break;

                    case ConsoleKey.Q:

                        done = true;

                        break;

                    case ConsoleKey.RightArrow:

                    case ConsoleKey.Enter:

                        done = true;

                        var warpSpeed = UI.ElicitInput("How fast (in warp units) would you like to go?", 0.0, 9.5);

                        hero.TravelTo(locations[selector], warpSpeed);

                        break;

                }

            } while (!done);

        }



        private void PrintLocationsAndDistances(int selector)

        {

            for (int i = 0; i < locations.Count; ++i)

            {

                Location destination = locations[i];



                var distance = hero.location.DistanceTo(destination);



                Console.Write($" - ");



                if (i == selector)

                {

                    UI.Highlight();

                }



                Console.WriteLine($"{destination.name}: {distance:f2}ly");



                UI.ResetColors();

            }

        }

    }

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
