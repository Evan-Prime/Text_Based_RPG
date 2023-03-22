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

        public Player(EnemyManager enemyManager, int x = 2, int y = 2, int tempX = 2, int tempY = 2, int health = 10, int damage = 5, char icon = '☺') : base(x, y, tempX, tempY, health, damage, icon)
        {
            this.enemyManager = enemyManager;
        }

        public void Update(ConsoleKeyInfo input)
        {
            // read user input
            tempX = x;
            tempY = y;

            if ((input.Key == ConsoleKey.W || input.Key == ConsoleKey.UpArrow) && GameManager.map.FloorCheck(x, y - 1) == true && enemyManager.IsAnyoneHere(x, y - 1, damage) == false)
            {
                y--;
            }
            else if ((input.Key == ConsoleKey.S || input.Key == ConsoleKey.DownArrow) && GameManager.map.FloorCheck(x, y + 1) == true && enemyManager.IsAnyoneHere(x, y + 1, damage) == false)
            {
                y++;
            }
            else if ((input.Key == ConsoleKey.A || input.Key == ConsoleKey.LeftArrow) && GameManager.map.FloorCheck(x - 1, y) == true && enemyManager.IsAnyoneHere(x - 1, y, damage) == false)
            {
                x--;
            }
            else if ((input.Key == ConsoleKey.D || input.Key == ConsoleKey.RightArrow) && GameManager.map.FloorCheck(x + 1, y) == true && enemyManager.IsAnyoneHere(x + 1, y, damage) == false)
            {
                x++;
            }
        }

        public void Draw()
        {
            base.Draw();
        }

        public void TakeDamage(int damageValue)
        {
            base.TakeDamage(damageValue);
        }
    }
}
