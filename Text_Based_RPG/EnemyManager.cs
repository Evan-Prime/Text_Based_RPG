using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class EnemyManager
    {
        Enemy[] enemies = new Enemy[3];
        
        public EnemyManager(Enemy[] enemies)
        {
            this.enemies = enemies;
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
