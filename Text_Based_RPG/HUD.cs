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
        ItemManager itemManager;

        public HUD ()
        {
            
        }

        public void Update()
        {

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.SetCursorPosition(0, 22);
            Console.WriteLine("█████████████████████████████████████████████      █████████████████████████████████████████");
            Console.SetCursorPosition(0, 23);
            Console.WriteLine("█                    █                      █      █                                       █");
            Console.SetCursorPosition(0, 24);
            Console.WriteLine("█                    █                      █      █                                       █");
            Console.SetCursorPosition(0, 25);
            Console.WriteLine("█                    █                      █      █                                       █");
            Console.SetCursorPosition(0, 26);
            Console.WriteLine("█                    █                      █      █                                       █");
            Console.SetCursorPosition(0, 27);
            Console.WriteLine("█                    █                      █      █                                       █");
            Console.SetCursorPosition(0, 28);
            Console.WriteLine("█████████████████████████████████████████████      █████████████████████████████████████████");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(1, 23);
            Console.WriteLine("Player: " + "Ramiel");
            Console.SetCursorPosition(1, 25);
            Console.WriteLine("Health: " + player.health + "/" + player.maxHealth + "   ");
            Console.SetCursorPosition(1, 27);
            Console.WriteLine("Damage: " + player.damage + "   ");

            if (enemyManager.attackedLast != null)
            {
                switch (enemyManager.attackedLast.name)
                {
                    case "Slime":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(22, 23);
                        Console.WriteLine("Enemy: " + enemyManager.attackedLast.name + "     ");
                        Console.SetCursorPosition(22, 25);
                        Console.WriteLine("Health: " + enemyManager.attackedLast.health + "/" + enemyManager.attackedLast.maxHealth + "   ");
                        Console.SetCursorPosition(22, 27);
                        Console.WriteLine("Damage: " + enemyManager.attackedLast.damage + "   ");
                        break;
                    case "Boss Slime":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.SetCursorPosition(22, 23);
                        Console.WriteLine("Enemy: " + enemyManager.attackedLast.name);
                        Console.SetCursorPosition(22, 25);
                        Console.WriteLine("Health: " + enemyManager.attackedLast.health + "/" + enemyManager.attackedLast.maxHealth + "   ");
                        Console.SetCursorPosition(22, 27);
                        Console.WriteLine("Damage: " + enemyManager.attackedLast.damage + "   ");
                        break;
                    case "Evil Pixie":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.SetCursorPosition(22, 23);
                        Console.WriteLine("Enemy: " + enemyManager.attackedLast.name);
                        Console.SetCursorPosition(22, 25);
                        Console.WriteLine("Health: " + enemyManager.attackedLast.health + "/" + enemyManager.attackedLast.maxHealth + "   ");
                        Console.SetCursorPosition(22, 27);
                        Console.WriteLine("Damage: " + enemyManager.attackedLast.damage + "   ");
                        break;
                    case "Evil Clone":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(22, 23);
                        Console.WriteLine("Enemy: " + enemyManager.attackedLast.name);
                        Console.SetCursorPosition(22, 25);
                        Console.WriteLine("Health: " + enemyManager.attackedLast.health + "/" + enemyManager.attackedLast.maxHealth + "   ");
                        Console.SetCursorPosition(22, 27);
                        Console.WriteLine("Damage: " + enemyManager.attackedLast.damage + "   ");
                        break;
                }
            }

            if (itemManager.usedLast != null)
            {
                switch (itemManager.usedLast.name)
                {
                    case "Health-Potion":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(52, 23);
                        Console.WriteLine("Item: " + itemManager.usedLast.name);
                        if (itemManager.notUsed == true)
                        {
                            Console.SetCursorPosition(52, 25);
                            Console.WriteLine("Effect: Your at max health        ");
                        }
                        else if (itemManager.notUsed == false)
                        {
                            Console.SetCursorPosition(52, 25);
                            Console.WriteLine("Effect: You healed " + itemManager.usedLast.effectValue + " health        ");
                        }
                        break;
                    case "Health-Up":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(52, 23);
                        Console.WriteLine("Item: " + itemManager.usedLast.name + "    ");
                        Console.SetCursorPosition(52, 25);
                        Console.WriteLine("Effect: Your health increased by " + itemManager.usedLast.effectValue);
                        break;
                    case "Power-Up":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.SetCursorPosition(52, 23);
                        Console.WriteLine("Item: " + itemManager.usedLast.name + "    ");
                        Console.SetCursorPosition(52, 25);
                        Console.WriteLine("Effect: Your damage increased by " + itemManager.usedLast.effectValue);
                        break;
                }
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
        public void SetItemManager(ItemManager itemManager)
        {
            this.itemManager = itemManager;
        }
    }
}
