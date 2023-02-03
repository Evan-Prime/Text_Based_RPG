using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class Player
    {
        public int x; // play position
        public int y; // play position
        int tempX;
        int tempY;

        public void Update(ConsoleKeyInfo input)
        {
            // read user input
            tempX = x;
            tempY = y;
            
            if ((input.Key == ConsoleKey.W || input.Key == ConsoleKey.UpArrow) && Program.map.WallCheck(x, y-1) == true)
            {
                y--;
            }
            if ((input.Key == ConsoleKey.S || input.Key == ConsoleKey.DownArrow) && Program.map.WallCheck(x, y+1) == true)
            {
                y++;
            }
            if ((input.Key == ConsoleKey.D || input.Key == ConsoleKey.RightArrow) && Program.map.WallCheck(x+1, y) == true)
            {
                x++;
            }
            if ((input.Key == ConsoleKey.A || input.Key == ConsoleKey.LeftArrow) && Program.map.WallCheck(x-1, y) == true)
            {
                x--;
            }
        }

        public void Draw()
        {
            Program.map.Drawtile(tempX, tempY);
            Console.SetCursorPosition(x, y);
            Console.Write("☺");
        }
    }
}
