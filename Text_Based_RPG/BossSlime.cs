﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class BossSlime: Enemy
    {
        private int targetX;
        private int targetY;

        public BossSlime(int x, int y, int tempX, int tempY, Map map, EnemyManager enemyManager, Player player, ItemManager itemManager) : base(x, y, tempX, tempY, map, enemyManager, player, itemManager, 100, 100, 10, '0', 4, "Boss Slime")
        {

        }

        public override void Update()
        {
            tempX = x;
            tempY = y;

            if (health > 0)
            {
                if (MoveCheck() == true)
                {
                    switch (Settings.RandomNum(0, 4))
                    {
                        case 0:
                            targetY = y - 1;
                            targetX = x;
                            break;
                        case 1:
                            targetY = y + 1;
                            targetX = x;
                            break;
                        case 2:
                            targetY = y;
                            targetX = x - 1;
                            break;
                        case 3:
                            targetY = y;
                            targetX = x + 1;
                            break;
                    }

                    if (map.IsFloorHere(targetX, targetY) == false)
                    {
                        return;
                    }

                    if (enemyManager.IsAnyoneHere(targetX, targetY, 0) == true)
                    {
                        return;
                    }

                    if (player.AmIHere(targetX, targetY, damage) == true)
                    {
                        return;
                    }

                    if (itemManager.IsAnyItemHere(targetX, targetY, false) == true)
                    {
                        return;
                    }

                    y = targetY;
                    x = targetX;
                }
            } 
            else if (health <= 0)
            {
                WinCondition.Win();
            }

            moveCounter++;
        }
    }
}
