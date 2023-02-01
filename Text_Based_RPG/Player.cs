using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class Player
    {
        public int playerPosx; // play position
        public int playerPosy; // play position
        static Map map = new Map();
        public void Update(ConsoleKeyInfo input)
        {
            // read user input

            if (input.Key == ConsoleKey.W || input.Key == ConsoleKey.UpArrow)
            {
                playerPosy--;
            }
            if (input.Key == ConsoleKey.S || input.Key == ConsoleKey.DownArrow)
            {
                playerPosy++;
            }
            if (input.Key == ConsoleKey.D || input.Key == ConsoleKey.RightArrow)
            {
                playerPosx++;
            }
            if (input.Key == ConsoleKey.A || input.Key == ConsoleKey.LeftArrow)
            {
                playerPosx--;
            }
            
        }

        public void Draw()
        {
            Console.Clear();
            map.DrawMap(1);
            Console.SetCursorPosition(playerPosx, playerPosy);
            Console.Write("☺");
        }
    }
}
