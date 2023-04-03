using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class ItemManager
    {
        Item[] items = new Item[30];
        public DamageUp damageUp;
        public HealthPotion healthPotion;
        public HealthUp healthUp;
        int x;
        int y;

        public ItemManager(Player player, EnemyManager enemyManager)
        {
            for (int i = 0; i < items.Length; i++)
            {
                x = Settings.RandomNum(15, 115);
                y = Settings.RandomNum(1, 19);
                while (GameManager.map.FloorCheck(x, y) == false || enemyManager.IsAnyoneHere(x, y, 0) == true || IsAnyItemHere(x, y) == true)
                {
                    x = Settings.RandomNum(15, 115);
                    y = Settings.RandomNum(1, 19);
                }
                if (i <= 24)
                {
                    healthPotion = new HealthPotion(x, y, player, 5);
                    items[i] = healthPotion;
                }
                if (i >= 25 && i <= 27)
                {
                    healthUp = new HealthUp(x, y, player, 5);
                    items[i] = healthUp;
                }
                if (i >= 28 && i <= 29)
                {
                    damageUp = new DamageUp(x, y, player, 5);
                    items[i] = damageUp;
                }
            }
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
                if (items[i] == null)
                {
                    return false;
                }

                if (items[i].AmIHere(targetX, targetY) == true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
