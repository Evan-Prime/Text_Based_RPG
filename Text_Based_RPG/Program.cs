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
        public static Map map = new Map();
        static Player player = new Player();
        static Enemy enemy = new Enemy();

        static void Main(string[] args)
        {
            player.x = 2;
            player.y = 2;
            enemy.x = 3;
            enemy.y = 9;
            gameOver = false;
            map.DrawMap(1);
            player.Draw();
            enemy.Draw();
            

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
                enemy.Update();
                enemy.Draw();
            }
        }

    }
}
