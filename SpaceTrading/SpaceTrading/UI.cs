using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTrading
{
  static class UI
    {
        public static ConsoleKey EllicitInput(string prompt = "> ")
        {
            Console.SetCursorPosition(0, Console.WindowHeight - 1);
            Console.Write(prompt);
            return Console.ReadKey(true).Key;
        }
    }
}