﻿using System;
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
            hud.SetItemManager(itemManager);
        }

        public void Run()
        {
            // initializing
            InputManager.IsGameRunning(false);
            player.Draw();
            enemyManager.Draw();
            itemManager.Draw();
            hud.Update();
            Settings.CursorVisablityFalse();

            // game loop
            while (InputManager.IsGameRunning(false) == false)
            {


                // update
                InputManager.Update();
                player.Update(InputManager.input);
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
