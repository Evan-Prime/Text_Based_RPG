﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    abstract class Item
    {
        public int x;
        public int y;
        public char icon;
        public bool active;
        public Player player;

        public Item(int x, int y, char icon, bool active, Player player)
        {
            this.x = x;
            this.y = y;
            this.icon = icon;
            this.active = active;
            this.player = player;
        }

        public abstract void PickUpEffect();

        public bool AmIHere(int targetX, int targetY)
        {

            bool item = false;
            if (targetY == y && targetX == x && active == true)
            {
                item = true;
                PickUpEffect();
                if (active == false)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(' ');
                }
            }
            return item;
        }

        public void Draw()
        {
            if (active == true)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(icon);
            }
        }
    }
}
