using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class GameManager
    {
        public static Map map;
        public static EnemyManager enemyManager;
        public static Player player;
        public static InventorySystem inventory;
        public static ItemManager itemManager;
        public static HUD hud;
        public static Camera camera;
        public static Render render;
        


        public GameManager ()
        {
            map = new Map();
            enemyManager = new EnemyManager();
            player = new Player(map, enemyManager);
            inventory = new InventorySystem();
            itemManager = new ItemManager(player, enemyManager, map, inventory);
            hud = new HUD();
            camera = new Camera(map, player);
            render = new Render(map, hud, camera);

            map.DrawMap();
            player.SetItemManager(itemManager);
            enemyManager.SetMap(map);
            enemyManager.SetPlayer(player);
            enemyManager.SetItemManager(itemManager);
            enemyManager.GenerateEnemies();

            hud.SetPlayer(player);
            hud.SetEnemyManager(enemyManager);
            hud.SetItemManager(itemManager);
            hud.SetInventorySystem(inventory);

           
        }

        public void Run()
        {
            // initializing
            bool gameInPlay = true;
            player.Draw();
            enemyManager.Draw();
            itemManager.Draw();
            hud.Update();
            camera.Update();
            render.Draw();
            Settings.CursorVisablityFalse();

            // game loop
            while (gameInPlay == true)
            {

                // update
                InputManager.Update();
                if (InputManager.IsQuiting() == true)
                {
                    break;
                }
                player.Update(InputManager.input);
                if (player.IsPlayerDead() == true)
                {
                    break;
                }
                enemyManager.Update();
                if (enemyManager.IsBossDead() == true)
                {
                    break;
                }
                hud.Update();
                camera.Update();

                // draw
                itemManager.Draw();
                enemyManager.Draw();
                player.Draw();
                render.Draw();
            }
        }
    }
}
