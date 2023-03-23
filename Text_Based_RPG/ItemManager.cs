using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class ItemManager
    {
        Item[] items;

        public ItemManager(Item[] items)
        {
            this.items = items;
        }

        public void Draw()
        {
            for (int i = 0; i < items.Length; i++)
            {
                items[i].Draw();
            }
        }

        public bool IsAnyItemHere(int targetX, int targetY)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i].AmIHere(targetX, targetY) == true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
