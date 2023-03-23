using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class EvilClone: Enemy
    {
        Random random = new Random();

        public EvilClone (int x, int y, int tempX, int tempY) : base (x, y, tempX, tempY, 10, 5, '☻', 2)
        {

        }

        public override void Update()
        {
            tempX = x;
            tempY = y;

            if (health > 0 && MoveCheck() == true)
            {
                switch (random.Next(0, 4))
                {
                    case 0:
                        if ((GameManager.map.FloorCheck(x, y - 1) == true) && GameManager.enemyManager.IsAnyoneHere(x, y - 1, 0) == false && GameManager.player.AmIHere(x, y - 1, damage) == false)
                        {
                            y--;
                        }
                        break;
                    case 1:
                        if ((GameManager.map.FloorCheck(x, y + 1) == true) && GameManager.enemyManager.IsAnyoneHere(x, y + 1, 0) == false && GameManager.player.AmIHere(x, y + 1, damage) == false)
                        {
                            y++;
                        }
                        break;
                    case 2:
                        if ((GameManager.map.FloorCheck(x - 1, y) == true) && GameManager.enemyManager.IsAnyoneHere(x - 1, y, 0) == false && GameManager.player.AmIHere(x - 1, y, damage) == false)
                        {
                            x--;
                        }
                        break;
                    case 3:
                        if ((GameManager.map.FloorCheck(x + 1, y) == true) && GameManager.enemyManager.IsAnyoneHere(x + 1, y, 0) == false && GameManager.player.AmIHere(x + 1, y, damage) == false)
                        {
                            x++;
                        }
                        break;
                }
            }

            moveCounter++;
        }
    }
}
