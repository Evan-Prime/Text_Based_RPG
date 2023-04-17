using System;
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
        public string name;
        public int effectValue;
        public Player player;

        public Item(int x, int y, char icon, bool active, string name, int effectValue, Player player)
        {
            this.x = x;
            this.y = y;
            this.icon = icon;
            this.active = active;
            this.name = name;
            this.effectValue = effectValue;
            this.player = player;
        }

        public abstract void Use();

        public bool AmIHere(int targetX, int targetY, bool IsPlayer)
        {

            bool item = false;
            if (targetY == y && targetX == x && active == true)
            {
                item = true;
                if (IsPlayer == true)
                {
                    Use();
                }
                
                if (active == false)
                {
                   GameManager.render.AddToRender(' ', x, y);
                }
            }
            return item;
        }

        public void Draw()
        {
            if (active == true)
            {
                GameManager.render.AddToRender(icon, x, y);
            }
            else
            {
                GameManager.render.AddToRender(' ', x, y);
            }
        }
    }
}
