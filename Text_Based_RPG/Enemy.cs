using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    abstract class Enemy : GameCharacter
    {
        public int moveAt;
        public int moveCounter;
        public string name;

        public Enemy (int x =3, int y = 9, int tempX = 3, int tempY = 9, int health = 10, int maxHealth = 10, int damage = 5, char icon = '☻', int moveAt = 2, string name = "Enemy") : base (x, y, tempX, tempY, health, maxHealth, damage, icon)
        {
            moveCounter = 0;
            this.moveAt = moveAt;
            this.name = name;
        }

        public abstract void Update();

        public void Draw()
        {
            base.Draw();
        }

        public bool MoveCheck()
        {
            bool move = false;
            if (moveCounter >= moveAt)
            {
                moveCounter = 0;
                move = true;
            }
            return move;
        }
    }
}
