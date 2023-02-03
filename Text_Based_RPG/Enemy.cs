using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class Enemy
    {
        public int x; // play position
        public int y; // play position
        int tempX;
        int tempY;
        Random random = new Random();

        public void Update()
        {
            // read user input
            tempX = x;
            tempY = y;

            switch (random.Next(0,4))
            {
                case 0:
                    if (Program.map.WallCheck(x, y-1) == true)
                    {
                        y--;
                    }
                    break;
                case 1:
                    if (Program.map.WallCheck(x,y+1) == true)
                    {
                        y++;
                    }
                    break;
                case 2:
                    if (Program.map.WallCheck(x-1, y) == true)
                    {
                        x--;
                    }
                    break;
                case 3:
                    if (Program.map.WallCheck(x+1, y) == true)
                    {
                        x++;
                    }
                    break;
            }
        }

        public void Draw()
        {
            Program.map.Drawtile(tempX, tempY);
            Console.SetCursorPosition(x, y);
            Console.Write("☻");
        }
    }
}
