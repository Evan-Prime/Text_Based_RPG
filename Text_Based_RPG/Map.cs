using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Text_Based_RPG
{
    internal class Map
    {
        public char[,] map;

        public Map()
        {
            DrawMap();
        }
         
        public void DrawMap()
        {
            string[] mapTotal = File.ReadAllLines(@"Map.txt");
            map = new char[mapTotal.Length, mapTotal[0].Length];
            for (int y = 0; y < mapTotal.Length; y++)
            {
                for (int x = 0; x < mapTotal[y].Length; x++)
                {
                    map[y, x] = mapTotal[y][x];
                    switch(map[y, x])
                    {
                        case '█':
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            break;
                        case ' ':
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;
                    }
                    Console.Write(map[y, x]);
                }
                Console.WriteLine();
            }
        }

        public void Drawtile(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            //x = x + 1;
            //y = y + 1;
            Console.Write(map[y,x]);
        }

        public bool FloorCheck (int x, int y)
        {
            bool wall = false;
            if (map[y,x] == ' ')
            {
                wall = true;
            }
            return wall;
        }
    }
}
