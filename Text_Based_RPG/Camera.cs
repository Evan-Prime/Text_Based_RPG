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
            X = playerX;
            Y = playerY;
        }
    }
}
