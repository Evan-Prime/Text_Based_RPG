using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class Player : GameCharacter
    {
        EnemyManager enemyManager;
        ItemManager itemManager;
        public int maxHealth;

        public Player(EnemyManager enemyManager, ItemManager itemManager, int x = 2, int y = 2, int tempX = 2, int tempY = 2, int health = 10, int damage = 5, char icon = '☺') : base(x, y, tempX, tempY, health, damage, icon)
        {
            this.enemyManager = enemyManager;
            this.itemManager = itemManager;
            maxHealth = health;
        }

        public void Update(ConsoleKeyInfo input)
        {
            // read user input
            tempX = x;
            tempY = y;

            if ((input.Key == ConsoleKey.W || input.Key == ConsoleKey.UpArrow) && GameManager.map.FloorCheck(x, y - 1) == true && enemyManager.IsAnyoneHere(x, y - 1, damage) == false && itemManager.IsAnyItemHere(x, y - 1) == false)
            {
                y--;
            }
            else if ((input.Key == ConsoleKey.S || input.Key == ConsoleKey.DownArrow) && GameManager.map.FloorCheck(x, y + 1) == true && enemyManager.IsAnyoneHere(x, y + 1, damage) == false && itemManager.IsAnyItemHere(x, y + 1) == false)
            {
                y++;
            }
            else if ((input.Key == ConsoleKey.A || input.Key == ConsoleKey.LeftArrow) && GameManager.map.FloorCheck(x - 1, y) == true && enemyManager.IsAnyoneHere(x - 1, y, damage) == false && itemManager.IsAnyItemHere(x - 1, y) == false)
            {
                x--;
            }
            else if ((input.Key == ConsoleKey.D || input.Key == ConsoleKey.RightArrow) && GameManager.map.FloorCheck(x + 1, y) == true && enemyManager.IsAnyoneHere(x + 1, y, damage) == false && itemManager.IsAnyItemHere(x + 1, y) == false)
            {
                x++;
            }
        }
    }
}
