using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class Player : GameCharacter
    {
        public Player(int x = 2, int y = 2, int tempX = 2, int tempY = 2, int health = 10, int damage = 5, char icon = '☺') : base (x,y,tempX,tempY,health,damage,icon)
        {
            
        }

        public void Update(ConsoleKeyInfo input)
        {
            // read user input
            tempX = x;
            tempY = y;
            
            if ((input.Key == ConsoleKey.W || input.Key == ConsoleKey.UpArrow) && Program.map.WallCheck(x, y-1) == true && base.FoeCheck(Program.enemy.x, Program.enemy.y, 1, Program.enemy) == false)
            {
                y--;
            }
            else if ((input.Key == ConsoleKey.S || input.Key == ConsoleKey.DownArrow) && Program.map.WallCheck(x, y+1) == true && base.FoeCheck(Program.enemy.x, Program.enemy.y, 2, Program.enemy) == false)
            {
                y++;
            }
            else if ((input.Key == ConsoleKey.A || input.Key == ConsoleKey.LeftArrow) && Program.map.WallCheck(x-1, y) == true && base.FoeCheck(Program.enemy.x, Program.enemy.y, 3, Program.enemy) == false)
            {
                x--;
            }
            else if ((input.Key == ConsoleKey.D || input.Key == ConsoleKey.RightArrow) && Program.map.WallCheck(x+1, y) == true && base.FoeCheck(Program.enemy.x, Program.enemy.y, 4, Program.enemy) == false)
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
