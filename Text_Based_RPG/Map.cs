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
            string[] mapTotal = File.ReadAllLines(@"Map.txt");
            map = new char[mapTotal.Length, mapTotal[0].Length];
            for (int y = 0; y < mapTotal.Length; y++)
            {
                for (int x = 0; x < mapTotal[y].Length; x++)
                {
                    map[y, x] = mapTotal[y][x];
                }
            }
        }
         
        public void DrawMap()
        {
            //string[] mapTotal = File.ReadAllLines(@"Map.txt");
            //map = new char[mapTotal.Length, mapTotal[0].Length];
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    //map[y, x] = mapTotal[y][x];
                    GameManager.render.AddToRender(map[y, x], x, y);
                }
            }
        }

        public void Drawtile(int x, int y)
        {
            GameManager.render.AddToRender(map[y, x], x, y);
        }

        public bool IsFloorHere (int x, int y)
        {
            bool floor = false;
            if (map[y,x] == ' ')
            {
                floor = true;
            }
            return floor;
        }
    }
}
