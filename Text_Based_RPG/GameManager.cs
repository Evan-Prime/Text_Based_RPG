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
        public static Map map = new Map();
        public static EnemyManager enemyManager = new EnemyManager();
        public static Player player = new Player();
        public static ItemManager itemManager = new ItemManager(player, enemyManager);
        public static HUD hud = new HUD(player, enemyManager);
        


        public GameManager ()
        {
            player.SetItemManager(itemManager);
            player.SetEnemyManager(enemyManager);
        }

        public void Run()
        {
            // initializing
            gameOver = false;
            player.Draw();
            itemManager.Draw();
            enemyManager.Draw();
            hud.Update();
            Console.CursorVisible = false;

            // game loop
            while (gameOver == false)
            {

                Console.CursorVisible = false;
                ConsoleKeyInfo input = Console.ReadKey(true);
                if (input.Key == ConsoleKey.Escape)
                {
                    gameOver = true;
                }

                // update
                player.Update(input);
                enemyManager.Update();
                hud.Update();

                // draw
                itemManager.Draw();
                enemyManager.Draw();
                player.Draw();
            }
        }
    }
}
