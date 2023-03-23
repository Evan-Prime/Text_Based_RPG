using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class EnemyManager
    {
        Enemy[] enemies;
        public EvilClone clone;
        public EvilPixie pixie;
        public NormalSlime slime;

        public EnemyManager()
        {
            clone = new EvilClone(19, 19, 19, 19);
            pixie = new EvilPixie(6, 16, 6, 16);
            slime = new NormalSlime(54, 18, 54, 18);
            enemies = new Enemy[3] {clone, pixie, slime};
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
                if (enemies[i].AmIHere(targetX, targetY, damage) == true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
