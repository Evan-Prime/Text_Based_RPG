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

        public Enemy (int x =3, int y = 9, int tempX = 3, int tempY = 9, int health = 10, int damage = 5, char icon = '☻') : base (x, y, tempX, tempY, health, damage, icon)
        {

        }

        public void Update()
        {
            // read user input
            tempX = x;
            tempY = y;

            switch (random.Next(0,4))
            {
                case 0:
                    if ((Program.map.WallCheck(x, y-1) == true) && health > 0 && base.FoeCheck(Program.player.x, Program.player.y, 1, Program.player) == false)
                    {
                        y--;
                    }
                    break;
                case 1:
                    if ((Program.map.WallCheck(x, y + 1) == true) && health > 0 && base.FoeCheck(Program.player.x, Program.player.y, 2, Program.player) == false)
                    {
                        y++;
                    }
                    break;
                case 2:
                    if ((Program.map.WallCheck(x-1, y) == true) && health > 0 && base.FoeCheck(Program.player.x, Program.player.y, 3, Program.player) == false)
                    {
                        x--;
                    }
                    break;
                case 3:
                    if ((Program.map.WallCheck(x+1, y) == true) && health > 0 && base.FoeCheck(Program.player.x, Program.player.y, 4, Program.player) == false)
                    {
                        x++;
                    }
                    break;
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
