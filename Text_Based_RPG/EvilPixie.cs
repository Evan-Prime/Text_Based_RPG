using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class EvilPixie: Enemy
    {

        bool moveUp = true;

        public EvilPixie(int x, int y, int tempX, int tempY) : base(x, y, tempX, tempY, 5, 5, 2, '*', 1)
        {

        }

        public override void Update ()
        {
            tempX = x;
            tempY = y;

            if (health > 0 && MoveCheck() == true)
            {
                if (GameManager.map.FloorCheck(x, y - 1) == true && moveUp == true && GameManager.enemyManager.IsAnyoneHere(x, y - 1, 0) == false && GameManager.player.AmIHere(x, y - 1, damage) == false && GameManager.itemManager.IsAnyItemHere(x, y - 1) == false)
                {
                    y--;
                }
                else
                {
                    moveUp = false;
                }

                if (GameManager.map.FloorCheck(x, y + 1) == true && moveUp == false && GameManager.enemyManager.IsAnyoneHere(x, y + 1, 0) == false && GameManager.player.AmIHere(x, y + 1, damage) == false && GameManager.itemManager.IsAnyItemHere(x, y + 1) == false)
                {
                    y++;
                }
                else
                {
                    moveUp = true;
                }
            }

            moveCounter++;
        }
    }
}
