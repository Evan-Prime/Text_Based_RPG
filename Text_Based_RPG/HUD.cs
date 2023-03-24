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

        public HUD (Player player, EnemyManager enemyManager)
        {
            this.player = player;
            this.enemyManager = enemyManager;
        }

        public void Update()
        {
            Console.SetCursorPosition(0, 21);
            Console.WriteLine("Player:");
            Console.WriteLine();
            Console.WriteLine("Health: " + player.health + "/" + player.maxHealth);
            Console.WriteLine();
            Console.WriteLine("Damage: " + player.damage);
            Console.WriteLine();
            Console.WriteLine("Enemy:");
            Console.WriteLine();
            if (enemyManager.attackedLast != null)
            {
                Console.WriteLine("Health: " + enemyManager.attackedLast.health + "/" + enemyManager.attackedLast.maxHealth + " ");
                Console.WriteLine();
                Console.WriteLine("Damage: " + enemyManager.attackedLast.damage + " ");
            }
        }
    }
}
