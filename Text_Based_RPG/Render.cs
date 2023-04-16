using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class Render
    {
        private Map map;
        private HUD hud;
        private char[,] render1;
        private char[,] render2;
        


        public Render(Map map, HUD hud)
        {
            this.map = map;
            this.hud = hud;
            render1 = new char[map.map.GetLength(0), map.map.GetLength(1)];
            render2 = new char[map.map.GetLength(0), map.map.GetLength(1)];
        }

        public void Draw()
        {
            for(int y = 0; y < render1.GetLength(0); y++)
            {
                for(int x = 0; x < render1.GetLength(1); x++)
                {
                    if (render1[y, x] != render2[y, x])
                    {
                        Console.Write(render1[y, x]);
                    }
                }
            }
            render2 = render1;
        }

        public void AddToRender(char Icon, int x, int y)
        {
            render1[y, x] = Icon;
        }
    }
}
