using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class Enemy : GameCharacter
    {
        Random random = new Random();
        public int moveAt;
        public int moveCounter;

        public Enemy (int x =3, int y = 9, int tempX = 3, int tempY = 9, int health = 10, int damage = 5, char icon = '☻', int moveAt = 2) : base (x, y, tempX, tempY, health, damage, icon)
        {
            moveCounter = 0;
            this.moveAt = moveAt;
        }

        public virtual void Update()
        {
            // read user input
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

        public void Draw()
        {
            if (health > 0)
            {
                base.Draw();
            }
        }

        public void TakeDamage(int damageValue)
        {
            base.TakeDamage(damageValue);
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
