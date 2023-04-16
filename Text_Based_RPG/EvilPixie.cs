using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class EvilPixie: Enemy
    {
        private int targetY;
        private int targetX;
        private bool moveUp = true;

        public EvilPixie(int x, int y, int tempX, int tempY, Map map, EnemyManager enemyManager, Player player, ItemManager itemManager) : base(x, y, tempX, tempY, map, enemyManager, player, itemManager, 5, 5, 2, '*', 1, "Evil Pixie")
        {

        }

        public override void Update ()
        {
            tempX = x;
            tempY = y;

            if (health > 0)
            {
                if (MoveCheck() == true)
                {
                    switch (moveUp)
                    {
                        case true:
                            targetY = y - 1;
                            targetX = x;
                            break;
                        case false:
                            targetY = y + 1;
                            targetX = x;
                            break;
                    }
                    
                    if (map.IsFloorHere(targetX, targetY) == false)
                    {
                        if (moveUp == true)
                        {
                            moveUp = false;
                        }
                        else if (moveUp == false)
                        {
                            moveUp = true;
                        }
                        return;
                    }

                    if (enemyManager.IsAnyoneHere(targetX, targetY, 0) == true)
                    {
                        if (moveUp == true)
                        {
                            moveUp = false;
                        }
                        else if (moveUp == false)
                        {
                            moveUp = true;
                        }
                        return;
                    }

                    if (player.AmIHere(targetX, targetY, damage) == true)
                    {
                        if (moveUp == true)
                        {
                            moveUp = false;
                        }
                        else if (moveUp == false)
                        {
                            moveUp = true;
                        }
                        return;
                    }

                    if (itemManager.IsAnyItemHere(targetX, targetY, false) == true)
                    {
                        if (moveUp == true)
                        {
                            moveUp = false;
                        }
                        else if (moveUp == false)
                        {
                            moveUp = true;
                        }
                        return;
                    }

                    y = targetY;
                    x = targetX;
                }
            }

            

            moveCounter++;
        }
    }
}
