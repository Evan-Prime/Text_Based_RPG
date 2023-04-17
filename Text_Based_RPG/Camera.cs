using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class Camera
    {
        private Map map;
        private Player player;
        private int playerX;
        private int playerY;
        public int X;
        public int Y;


        public Camera(Map map, Player player)
        {
            this.map = map;
            this.player = player;
        }

        public void Update()
        {
            playerX = player.x;
            playerY = player.y;
            if (playerX >= (Settings.cameraSizeX / 2) && playerX <= (map.map.GetLength(1) - Settings.cameraSizeX / 2))
            {
                X = playerX;
            }

            if (playerY >= (Settings.cameraSizeY / 2) && playerY <= (map.map.GetLength(0) - Settings.cameraSizeY / 2))
            {
                Y = playerY;
            }
        }
    }
}
