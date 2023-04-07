using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class GameCharacter
    {
        public int x;
        public int y;
        public int tempX;
        public int tempY;
        public int health;
        public int maxHealth;
        public int damage;
        public char icon;

        public GameCharacter (int x, int y, int tempX, int tempY, int health, int maxHealth, int damage, char icon)
        {
            this.x = x;
            this.y = y;
            this.tempX = tempX;
            this.tempY = tempY;
            this.health = health;
            this.maxHealth = maxHealth;
            this.damage = damage;
            this.icon = icon;
        }

        public void TakeDamage(int hp)
        {
            if (hp < 0) return;
            health -= hp;
            if (health < 0) health = 0;
            if (health == 0)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(' ');
            }
        }

        public void Draw()
        {
            switch (icon)
            {
                case 'o':
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case '0':
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case '*':
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case '☻':
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case '☺':
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
            }

            if (health > 0)
            {
                if (GameManager.enemyManager.IsAnyoneHere(tempX, tempY, 0) == false)
                {
                    GameManager.map.Drawtile(tempX, tempY);
                }
                Console.SetCursorPosition(x, y);
                Console.Write(icon);
            }

        }

        public bool AmIHere (int targetX, int targetY, int damage)
        {
            
            bool foe = false;
            if (health > 0) 
            {
                if (targetY == y && targetX == x)
                {
                    TakeDamage(damage);
                    foe = true;
                }
            }
            return foe;
        }
    }
}
