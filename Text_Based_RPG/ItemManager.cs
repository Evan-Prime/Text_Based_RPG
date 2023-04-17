using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class ItemManager
    {
        Player player;
        Item[] items = new Item[35];
        public DamageUp damageUp;
        public HealthPotion healthPotion;
        public HealthUp healthUp;
        public Item usedLast;
        public bool notUsed;
        int x;
        int y;

        public ItemManager(Player player, EnemyManager enemyManager, Map map)
        {
            this.player = player;
            for (int i = 0; i < items.Length; i++)
            {
                x = Settings.RandomNum(15, 115);
                y = Settings.RandomNum(1, 33);
                while (map.IsFloorHere(x, y) == false || enemyManager.IsAnyoneHere(x, y, 0) == true || IsAnyItemHere(x, y, false) == true)
                {
                    x = Settings.RandomNum(15, 115);
                    y = Settings.RandomNum(1, 33);
                }
                if (i <= 24)
                {
                    healthPotion = new HealthPotion(x, y, player, 5);
                    items[i] = healthPotion;
                }
                if (i >= 25 && i <= 29)
                {
                    healthUp = new HealthUp(x, y, player, 5);
                    items[i] = healthUp;
                }
                if (i >= 30 && i <= 34)
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

        public bool IsAnyItemHere(int targetX, int targetY, bool IsPlayer)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                {
                    return false;
                }

                if (items[i].AmIHere(targetX, targetY, IsPlayer) == true)
                {
                    if (IsPlayer == true)
                    {
                        usedLast = items[i];
                        if (player.health == player.maxHealth)
                        {
                            notUsed = true;
                        }
                        else
                        {
                            notUsed = false;
                        }
                    }
                    return true;
                }
            }
            return false;
        }
    }
}
