using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class Render
    {
        private HUD hud;
        private Camera camera;
        private char[,] worldmap;
        private char[,] render1;
        private char[,] render2;
        private int cameraX;
        private int cameraY;


        public Render(Map map, HUD hud, Camera camera)
        {
            this.hud = hud;
            this.camera = camera;
            worldmap = new char[map.map.GetLength(0), map.map.GetLength(1)];
            render1 = new char[Settings.cameraSizeY, Settings.cameraSizeX];
            render2 = new char[Settings.cameraSizeY, Settings.cameraSizeX];
        }

        public void Draw()
        {
            //Drawing to Camera
            //for (int)
            cameraX = camera.X - (Settings.cameraSizeX/2);
            cameraY = camera.Y - (Settings.cameraSizeY/2);

            Console.WriteLine(cameraX + ", " + cameraY);

            //Drawing from Camera to Screen
            for(int y = 0; y < render1.GetLength(0); y++)
            {
                for(int x = 0; x < render1.GetLength(1); x++)
                {
                    render1[y, x] = worldmap[y + cameraY, x + cameraX];
                    if (render1[y, x] != render2[y, x])
                    {
                        switch (render1[y, x])
                        {
                            case 'o':
                                Console.ForegroundColor = ConsoleColor.Blue;
                                break;
                            case '0':
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                                break;
                            case '*':
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                break;
                            case '☻':
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                break;
                            case '☺':
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                break;
                            case '+':
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                            case '♥':
                                Console.ForegroundColor = ConsoleColor.Red;
                                break;
                            case '^':
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                break;
                            case 'X':
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                break;
                            case '█':
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                break;
                            case ' ':
                                Console.BackgroundColor = ConsoleColor.Black;
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                break;
                        }
                        Console.SetCursorPosition(x, y);
                        Console.Write(render1[y, x]);
                    }
                }
            }
            MatchRender();
        }

        public void MatchRender()
        {
            for (int y = 0; y < render1.GetLength(0); y++)
            {
                for (int x = 0; x < render1.GetLength(1); x++)
                {
                    render2[y, x] = render1[y, x];
                }
            }
        }

        public void AddToRender(char Icon, int x, int y)
        {
            worldmap[y, x] = Icon;
        }
    }
}
