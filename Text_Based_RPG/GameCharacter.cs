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
        public int damage;
        public char icon;

        public GameCharacter (int x, int y, int tempX, int tempY, int health, int damage, char icon)
        {
            this.x = x;
            this.y = y;
            this.tempX = tempX;
            this.tempY = tempY;
            this.health = health;
            this.damage = damage;
            this.icon = icon;
        }
        public void TakeDamage(int hp)
        {
            if (hp < 0) return;
            health -= hp;
            if (health < 0) health = 0;
        }
        public void Draw()
        {
            Program.map.Drawtile(tempX, tempY);
            Console.SetCursorPosition(x, y);
            Console.Write(icon);
        }

        public bool FoeCheck(int foeX, int foeY, int direction, GameCharacter target)
        {
            /*
             * 1 - up
             * 2 - down
             * 3 - left
             * 4 - right
            */
            bool foe = false;
            if (foeY == y - 1 && foeX == x && direction == 1)
            {
                target.TakeDamage(damage);
                foe = true;
            }
            else if (foeY == y + 1 && foeX == x && direction == 2)
            {
                target.TakeDamage(damage);
                foe = true;
            }
            else if (foeY == y && foeX == x - 1 && direction == 3)
            {
                target.TakeDamage(damage);
                foe = true;
            }
            else if (foeY == y && foeX == x + 1 && direction == 4)
            {
                target.TakeDamage(damage);
                foe = true;
            }
            return foe;
        }
    }
}
