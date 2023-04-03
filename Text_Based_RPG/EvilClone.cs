using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class EvilClone: Enemy
    {
        public EvilClone (int x, int y, int tempX, int tempY) : base (x, y, tempX, tempY, 10, 10, 5, '☻', 3, "Evil Clone")
        {

        }

        public override void Update()
        {
            tempX = x;
            tempY = y;

            if (health > 0 && MoveCheck() == true)
            {
                switch (Settings.RandomNum(0, 4))
                {
                    case 0:
                        if ((GameManager.map.FloorCheck(x, y - 1) == true) && GameManager.enemyManager.IsAnyoneHere(x, y - 1, 0) == false && GameManager.player.AmIHere(x, y - 1, damage) == false && GameManager.itemManager.IsAnyItemHere(x, y - 1) == false)
                        {
                            y--;
                        }
                        break;
                    case 1:
                        if ((GameManager.map.FloorCheck(x, y + 1) == true) && GameManager.enemyManager.IsAnyoneHere(x, y + 1, 0) == false && GameManager.player.AmIHere(x, y + 1, damage) == false && GameManager.itemManager.IsAnyItemHere(x, y + 1) == false)
                        {
                            y++;
                        }
                        break;
                    case 2:
                        if ((GameManager.map.FloorCheck(x - 1, y) == true) && GameManager.enemyManager.IsAnyoneHere(x - 1, y, 0) == false && GameManager.player.AmIHere(x - 1, y, damage) == false && GameManager.itemManager.IsAnyItemHere(x - 1, y) == false)
                        {
                            x--;
                        }
                        break;
                    case 3:
                        if ((GameManager.map.FloorCheck(x + 1, y) == true) && GameManager.enemyManager.IsAnyoneHere(x + 1, y, 0) == false && GameManager.player.AmIHere(x + 1, y, damage) == false && GameManager.itemManager.IsAnyItemHere(x + 1, y) == false)
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
