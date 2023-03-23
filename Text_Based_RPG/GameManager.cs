using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class GameManager
    {
        static bool gameOver; // true or false
        static int scale;
        public static Map map = new Map();
        public static EnemyManager enemyManager = new EnemyManager();
        public static Player player = new Player();
        public static ItemManager itemManager = new ItemManager(player);
        


        public GameManager ()
        {
            player.SetItemManager(itemManager);
            player.SetEnemyManager(enemyManager);
        }

        public void Run()
        {
            // initializing
            player.x = 2;
            player.y = 2;
            gameOver = false;
            scale = 1;
            map.DrawMap(scale);
            player.Draw();
            itemManager.Draw();
            enemyManager.Draw();
            Console.CursorVisible = false;

            // game loop
            while (gameOver == false)
            {

                Console.CursorVisible = false;
                ConsoleKeyInfo input = Console.ReadKey(true);
                if ((input.Key == ConsoleKey.Escape) || player.health <= 0)
                {
                    gameOver = true;
                }

                // update
                player.Update(input);
                enemyManager.Update();

                // draw
                itemManager.Draw();
                enemyManager.Draw();
                player.Draw();
            }
        }
    }
}
