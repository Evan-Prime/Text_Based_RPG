using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class NormalSlime: Enemy
    {
        bool moveLeft = true;

        public NormalSlime(int x, int y, int tempX, int tempY) : base(x, y, tempX, tempY, 15, 4, 'o', 3)
        {

        }

        public override void Update()
        {
            tempX = x;
            tempY = y;

            if (health > 0 && MoveCheck() == true)
            {
                if (GameManager.map.FloorCheck(x - 1, y) == true && moveLeft == true && GameManager.enemyManager.IsAnyoneHere(x - 1, y, 0) == false && GameManager.player.AmIHere(x - 1, y, damage) == false)
                {
                    x--;
                }
                else
                {
                    moveLeft = false;
                }

                if (GameManager.map.FloorCheck(x + 1, y) == true && moveLeft == false && GameManager.enemyManager.IsAnyoneHere(x + 1, y, 0) == false && GameManager.player.AmIHere(x + 1, y, damage) == false)
                {
                    x++;
                }
                else
                {
                    moveLeft = true;
                }
            }

            moveCounter++;
        }
    }
}
