using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal static class InputManager
    {
        public static ConsoleKeyInfo input;
        public static void Update()
        {
            input = Console.ReadKey(true);
        }

        public static bool IsGameRunning(bool gameOver)
        {
            gameOver = false;

            if (input.Key == ConsoleKey.Escape)
            {
                gameOver = true;
            }
            return gameOver;
        }

    }
}
