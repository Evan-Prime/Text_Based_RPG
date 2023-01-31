using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class Player
    {
        static int playerPosx; // play position
        static int playerPosy; // play position

        static void Update()
        {
            // read user input
            ConsoleKeyInfo input;
            input = Console.ReadKey(true);

            if (input.Key == ConsoleKey.W || input.Key == ConsoleKey.UpArrow)
            {
                playerPosy--;
            }
            if (input.Key == ConsoleKey.S || input.Key == ConsoleKey.DownArrow)
            {
                playerPosy++;
            }
            if (input.Key == ConsoleKey.D || input.Key == ConsoleKey.RightArrow)
            {
                playerPosx++;
            }
            if (input.Key == ConsoleKey.A || input.Key == ConsoleKey.LeftArrow)
            {
                playerPosx--;
            }
            if (input.Key == ConsoleKey.Escape)
            {
                gameOver = true;
            }

        }

        static void Draw()
        {
            Console.Clear();

            Console.SetCursorPosition(playerPosx, playerPosy);
            Console.Write("☺");
        }
    }
}
