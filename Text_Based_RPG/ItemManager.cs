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
        public DamageUp damageUp;
        public HealthPotion healthPotion;
        public HealthUp healthUp;

        public ItemManager(Player player)
        {
            damageUp = new DamageUp(16, 14, player, 5);
            healthPotion = new HealthPotion(74, 16, player, 5);
            healthUp = new HealthUp(77, 16, player, 5);
            items = new Item[3] {damageUp, healthPotion, healthUp};
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
