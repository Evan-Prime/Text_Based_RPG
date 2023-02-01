using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class Program
    {
        static bool gameOver; // true or false
        static Map map = new Map();
        static Player player = new Player();

        static void Main(string[] args)
        {
            player.playerPosx = 2;
            player.playerPosy = 2;
            gameOver = false;
            map.DrawMap(1);
            player.Draw();
            

            while (gameOver == false)
            {
                Console.CursorVisible = false;
                ConsoleKeyInfo input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Escape)
                {
                    gameOver = true;
                }
                player.Update(input);
                player.Draw();
            }
        }

    }
}
