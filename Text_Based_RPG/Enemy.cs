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

        public void Update()
        {
            // read user input
            tempX = x;
            tempY = y;

            switch (random.Next(0,4))
            {
                case 0:
                    if ((GameManager.map.WallCheck(x, y-1) == true) && health > 0 && base.FoeCheck(GameManager.player.x, GameManager.player.y, 1, GameManager.player) == false && MoveCheck() == true)
                    {
                        y--;
                    }
                    break;
                case 1:
                    if ((GameManager.map.WallCheck(x, y + 1) == true) && health > 0 && base.FoeCheck(GameManager.player.x, GameManager.player.y, 2, GameManager.player) == false && MoveCheck() == true)
                    {
                        y++;
                    }
                    break;
                case 2:
                    if ((GameManager.map.WallCheck(x-1, y) == true) && health > 0 && base.FoeCheck(GameManager.player.x, GameManager.player.y, 3, GameManager.player) == false && MoveCheck() == true)
                    {
                        x--;
                    }
                    break;
                case 3:
                    if ((GameManager.map.WallCheck(x+1, y) == true) && health > 0 && base.FoeCheck(GameManager.player.x, GameManager.player.y, 4, GameManager.player) == false && MoveCheck() == true)
                    {
                        x++;
                    }
                    break;
            }

            moveCounter++;
        }

        public void Draw()
        {
            base.Draw();
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
