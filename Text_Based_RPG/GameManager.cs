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
        public static Map map;
        public static EnemyManager enemyManager;
        public static Player player;
        public static ItemManager itemManager;
        public static HUD hud;
        


        public GameManager ()
        {
            map = new Map();
            enemyManager = new EnemyManager();
            player = new Player();
            itemManager = new ItemManager(player, enemyManager);
            hud = new HUD();

            player.SetItemManager(itemManager);
            player.SetEnemyManager(enemyManager);
            hud.SetPlayer(player);
            hud.SetEnemyManager(enemyManager);
        }

        public void Run()
        {
            // initializing
            gameOver = false;
            player.Draw();
            enemyManager.Draw();
            itemManager.Draw();
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
