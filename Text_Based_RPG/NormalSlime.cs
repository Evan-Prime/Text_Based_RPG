using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class NormalSlime: Enemy
    {
        private int targetY;
        private int targetX;
        private bool moveLeft = true;

        public NormalSlime(int x, int y, int tempX, int tempY) : base(x, y, tempX, tempY, 15, 15, 4, 'o', 4, "Slime")
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
                    switch (moveLeft)
                    {
                        case true:
                            targetY = y;
                            targetX = x - 1;
                            break;
                        case false:
                            targetY = y;
                            targetX = x + 1;
                            break;
                    }

                    if (GameManager.map.IsFloorHere(targetX, targetY) == false)
                    {
                        if (moveLeft == true)
                        {
                            moveLeft = false;
                        }
                        else if (moveLeft == false)
                        {
                            moveLeft = true;
                        }
                        return;
                    }

                    if (GameManager.enemyManager.IsAnyoneHere(targetX, targetY, 0) == true)
                    {
                        if (moveLeft == true)
                        {
                            moveLeft = false;
                        }
                        else if (moveLeft == false)
                        {
                            moveLeft = true;
                        }
                        return;
                    }

                    if (GameManager.player.AmIHere(targetX, targetY, damage) == true)
                    {
                        if (moveLeft == true)
                        {
                            moveLeft = false;
                        }
                        else if (moveLeft == false)
                        {
                            moveLeft = true;
                        }
                        return;
                    }

                    if (GameManager.itemManager.IsAnyItemHere(targetX, targetY, false) == true)
                    {
                        if (moveLeft == true)
                        {
                            moveLeft = false;
                        }
                        else if (moveLeft == false)
                        {
                            moveLeft = true;
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
