using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class Player : GameCharacter
    {
        ItemManager itemManager;
        private int targetX;
        private int targetY;

        public Player(Map map, EnemyManager enemyManager, int x = 2, int y = 2, int tempX = 2, int tempY = 2, int health = 10, int maxHealth = 10, int damage = 5, char icon = '☺') : base(x, y, tempX, tempY, health, maxHealth, damage, icon, map, enemyManager)
        {

        }

        public void Update(ConsoleKeyInfo input)
        {
            // read user input
            tempX = x;
            tempY = y;
            if (health > 0)
            {
                switch (input.Key)
                {
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        targetY = y - 1;
                        targetX = x;
                        break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        targetY = y + 1;
                        targetX = x;
                        break;
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        targetY = y;
                        targetX = x - 1;
                        break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        targetY = y;
                        targetX = x + 1;
                        break;
                }

                if (map.IsFloorHere(targetX, targetY) == false)
                {
                    return;
                }

                if (enemyManager.IsAnyoneHere(targetX, targetY, damage) == true)
                {
                    return;
                }

                if (itemManager.IsAnyItemHere(targetX, targetY, true) == true)
                {
                    return;
                }

                y = targetY;
                x = targetX;
            }
            else if (health <= 0)
            {
                LoseCondition.Lose();
            }
        }

        public void SetItemManager(ItemManager itemManager)
        {
            this.itemManager = itemManager;
        }
    }
}
