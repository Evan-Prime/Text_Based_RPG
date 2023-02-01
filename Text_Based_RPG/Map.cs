﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class Map
    {
        public char[,] map = new char[,] // dimensions defined by following data:
        {
            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' ','║',' ',' ',' ','║',' ',' ',' ',' ',' ',' ','║',' ',' ',' ','║',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' ','║',' ',' ',' ','║',' ',' ',' ',' ',' ',' ','║',' ',' ',' ','║',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' ','║',' ',' ',' ','║',' ',' ',' ',' ',' ',' ','║',' ',' ',' ','║',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' ','╚','═','═','═','╝',' ',' ',' ',' ',' ',' ','╚','═','═','═','╝',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' ','╔','═','═','═','╗',' ',' ',' ',' ',' ',' ','╔','═','═','═','╗',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' ','║',' ',' ',' ','║',' ',' ',' ',' ',' ',' ','║',' ',' ',' ','║',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' ','║',' ',' ',' ','║',' ',' ',' ',' ',' ',' ','║',' ',' ',' ','║',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' ','║',' ',' ',' ','║',' ',' ',' ',' ',' ',' ','║',' ',' ',' ','║',' ',' ',' ',' ',' ',' ',' '},
            {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
        };

        public void DrawMap(int scale)
        {
            Console.Write("╔");
            for (int borderLine = 0; borderLine < map.GetLength(1) * scale; borderLine++)
            {
                Console.Write("═");
            }
            Console.Write("╗");

            Console.WriteLine();

            for (int y = 0; y <= 11; y++)
            {
                for (int rows = 0; rows < scale; rows++)
                {
                    Console.Write("║");
                    for (int x = 0; x <= 29; x++)
                    {

                        for (int columns = 0; columns < scale; columns++)
                        {
                            Console.Write(map[y, x]);
                        }

                    }
                    Console.Write("║");

                    Console.WriteLine();
                }
            }

            Console.Write("╚");
            for (int borderLine = 0; borderLine < map.GetLength(1) * scale; borderLine++)
            {
                Console.Write("═");
            }
            Console.Write("╝");
        }

        public void Drawtile(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }
    }
}
