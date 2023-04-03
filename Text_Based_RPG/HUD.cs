using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class HUD
    {
        Player player;
        EnemyManager enemyManager;

        public HUD ()
        {
            
        }

        public void Update()
        {
            Console.SetCursorPosition(0, 21);
            Console.WriteLine("Player: " + "Ramiel");
            Console.SetCursorPosition(0, 23);
            Console.WriteLine("Health: " + player.health + "/" + player.maxHealth + "   ");
            Console.SetCursorPosition(0, 25);
            Console.WriteLine("Damage: " + player.damage + "   ");

            if (enemyManager.attackedLast != null)
            {
                Console.SetCursorPosition(21, 21);
                Console.WriteLine("Enemy: "/* + enemyManager.attackedLast.name + "   "*/);
                Console.SetCursorPosition(21, 23);
                Console.WriteLine("Health: " + enemyManager.attackedLast.health + "/" + enemyManager.attackedLast.maxHealth + "   ");
                Console.SetCursorPosition(21, 25);
                Console.WriteLine("Damage: " + enemyManager.attackedLast.damage + "   ");
            }
        }

        public void SetPlayer(Player player)
        {
            this.player = player;
        }

        public void SetEnemyManager(EnemyManager enemyManager)
        {
            this.enemyManager = enemyManager;
        }
    }
}
