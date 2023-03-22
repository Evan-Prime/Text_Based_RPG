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
        public static EvilClone clone = new EvilClone(19, 19, 19, 19);
        public static EvilPixie pixie = new EvilPixie(6, 16, 6, 16);
        public static NormalSlime slime = new NormalSlime(54, 18, 54, 18);
        public static EnemyManager enemyManager = new EnemyManager(new Enemy[] {clone, pixie, slime});
        public static Player player = new Player(enemyManager);


        public GameManager ()
        {
            
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
            clone.Draw();
            pixie.Draw();
            slime.Draw();
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
                clone.Update();
                pixie.Update();
                slime.Update();

                // draw
                clone.Draw();
                pixie.Draw();
                slime.Draw();
                player.Draw();
            }
        }
    }
}
