using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class EnemyManager
    {
        Enemy[] enemies = new Enemy[31];
        public EvilClone clone;
        public EvilPixie pixie;
        public NormalSlime slime;
        public BossSlime bossSlime;
        public Enemy attackedLast;
        int x;
        int y;

        public EnemyManager()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                x = Settings.RandomNum(15,115);
                y = Settings.RandomNum(1, 19);
                while (GameManager.map.FloorCheck(x, y) == false || IsAnyoneHere(x, y, 0) == true)
                {
                    x = Settings.RandomNum(15, 115);
                    y = Settings.RandomNum(1, 19);
                }
                if (i == 0)
                {
                    bossSlime = new BossSlime(107, 2, 107, 2);
                    enemies[i] = bossSlime;
                }
                else if (i > 0 && i < 26)
                {
                    pixie = new EvilPixie(x, y, x, y);
                    enemies[i] = pixie;
                }
                else if (i >= 26 && i < 29)
                {
                    slime = new NormalSlime(x, y, x, y);
                    enemies[i] = slime;
                }
                else //if (i >= 29 && i <= 30)
                {
                    clone = new EvilClone(x, y, x, y);
                    enemies[i] = clone;
                }
            }



        }

        public void Update()
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].Update();
            }
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
    }
}
