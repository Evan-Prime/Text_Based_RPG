using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class EnemyManager
    {
        Enemy[] enemies = new Enemy[33];

        Player player;
        Map map;
        ItemManager itemManager;

        public EvilClone clone;
        public EvilPixie pixie;
        public NormalSlime slime;
        public BossSlime bossSlime;
        public Enemy attackedLast;
        int x;
        int y;

        public EnemyManager()
        {
            
        }

        public void Update()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].Update();
            }
        }

        public void GenerateEnemies()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                x = Settings.RandomNum(15, 115);
                y = Settings.RandomNum(1, 33);
                while (map.IsFloorHere(x, y) == false || IsAnyoneHere(x, y, 0) == true)
                {
                    x = Settings.RandomNum(15, 115);
                    y = Settings.RandomNum(1, 33);
                }
                if (i == 0)
                {
                    bossSlime = new BossSlime(107, 2, 107, 2, map, this, player, itemManager);
                    enemies[i] = bossSlime;
                }
                else if (i > 0 && i < 26)
                {
                    pixie = new EvilPixie(x, y, x, y, map, this, player, itemManager);
                    enemies[i] = pixie;
                }
                else if (i >= 26 && i < 29)
                {
                    slime = new NormalSlime(x, y, x, y, map, this, player, itemManager);
                    enemies[i] = slime;
                }
                else
                {
                    clone = new EvilClone(x, y, x, y, map, this, player, itemManager);
                    enemies[i] = clone;
                }
            }
        }

        public void SetMap(Map map)
        {
            this.map = map;
        }

        public void SetPlayer(Player player)
        {
            this.player = player;
        }

        public void SetItemManager(ItemManager itemManager)
        {
            this.itemManager = itemManager;
        }

        public void Draw()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].Draw();
            }
        }

        public bool IsAnyoneHere (int targetX, int targetY, int damage)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if (enemies[i] == null)
                {
                    return false;
                }

                if (enemies[i].AmIHere(targetX, targetY, damage) == true)
                {
                    if (damage > 0)
                    {
                        attackedLast = enemies[i];
                    }
                    return true;
                }
            }
            return false;
        }

        public bool IsBossDead()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if (enemies[i] == bossSlime)
                {
                    if (bossSlime.health <= 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
