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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(1, 23);
            Console.WriteLine("Player: " + "Ramiel");
            Console.SetCursorPosition(1, 25);
            Console.WriteLine("Health: " + player.health + "/" + player.maxHealth + "   ");
            Console.SetCursorPosition(1, 27);
            Console.WriteLine("Damage: " + player.damage + "   ");

            if (enemyManager.attackedLast != null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(22, 23);
                Console.WriteLine("Enemy: "+ enemyManager.attackedLast.name + "     ");
                Console.SetCursorPosition(22, 25);
                Console.WriteLine("Health: " + enemyManager.attackedLast.health + "/" + enemyManager.attackedLast.maxHealth + "   ");
                Console.SetCursorPosition(22, 27);
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
