using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class Program
    {
        public bool gameOver; // true or false
        static Map map = new Map();
        static Player player = new Player();

        static void Main(string[] args)
        {
            gameOver = false;
            map.DrawMap(1);
            while (gameOver == false)
            {
                player.Update();
                player.Draw();
                if (input.Key == ConsoleKey.Escape)
                {
                    gameOver = true;
                }
            }
            Console.ReadKey(true);
        }

    }
}
