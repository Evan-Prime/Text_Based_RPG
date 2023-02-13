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
        static int scale;
        public static Map map = new Map();
        public static Player player = new Player();
        public static Enemy enemy = new Enemy();

        static void Main(string[] args)
        {
            // initializing
            player.x = 2;
            player.y = 2;
            enemy.x = 3;
            enemy.y = 9;
            gameOver = false;
            scale = 1;
            map.DrawMap(scale);
            player.Draw();
            enemy.Draw();
            Console.CursorVisible = false;

            // game loop
            while (gameOver == false)
            {
                ConsoleKeyInfo input = Console.ReadKey(true);
                if ((input.Key == ConsoleKey.Escape) /* || player.health <= 0 */)
                {
                    gameOver = true;
                }

                // update
                player.Update(input);
                enemy.Update();

                // draw
                enemy.Draw();
                player.Draw();
            }
        }

    }
}
