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
        InventorySystem inventory;

        public HUD ()
        {
            
        }

        public void Update()
        {

            Console.ForegroundColor = ConsoleColor.Gray;
            
            //map border
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("█████████████");
            for (int i = 1; i < 8; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine("█");
                Console.SetCursorPosition(12, i);
                Console.WriteLine("█");
            }
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("█████████████");

            //stat tracker border
            Console.SetCursorPosition(0, 10);
            Console.WriteLine("█████████████████████████████████████████████");
            for (int j = 11; j < 16; j++)
            {
                Console.SetCursorPosition(0, j);
                Console.WriteLine("█                    █                      █");
            }
            Console.SetCursorPosition(0, 16);
            Console.WriteLine("█████████████████████████████████████████████");
            
            //used item tracker
            for (int k = 17; k < 20; k++)
            {
                Console.SetCursorPosition(2, k);
                Console.WriteLine("█                                       █");
            }
            Console.SetCursorPosition(2, 20);
            Console.WriteLine("█████████████████████████████████████████");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(1, 11);
            Console.WriteLine("Player: " + "Ramiel");
            Console.SetCursorPosition(1, 13);
            Console.WriteLine("Health: " + player.health + "/" + player.maxHealth + "   ");
            Console.SetCursorPosition(1, 15);
            Console.WriteLine("Damage: " + player.damage + "   ");

            if (enemyManager.attackedLast != null)
            {
                switch (enemyManager.attackedLast.name)
                {
                    case "Slime":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(22, 11);
                        Console.WriteLine("Enemy: " + enemyManager.attackedLast.name + "     ");
                        Console.SetCursorPosition(22, 13);
                        Console.WriteLine("Health: " + enemyManager.attackedLast.health + "/" + enemyManager.attackedLast.maxHealth + "   ");
                        Console.SetCursorPosition(22, 15);
                        Console.WriteLine("Damage: " + enemyManager.attackedLast.damage + "   ");
                        break;
                    case "Boss Slime":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.SetCursorPosition(22, 11);
                        Console.WriteLine("Enemy: " + enemyManager.attackedLast.name);
                        Console.SetCursorPosition(22, 13);
                        Console.WriteLine("Health: " + enemyManager.attackedLast.health + "/" + enemyManager.attackedLast.maxHealth + "   ");
                        Console.SetCursorPosition(22, 15);
                        Console.WriteLine("Damage: " + enemyManager.attackedLast.damage + "   ");
                        break;
                    case "Evil Pixie":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.SetCursorPosition(22, 11);
                        Console.WriteLine("Enemy: " + enemyManager.attackedLast.name);
                        Console.SetCursorPosition(22, 13);
                        Console.WriteLine("Health: " + enemyManager.attackedLast.health + "/" + enemyManager.attackedLast.maxHealth + "   ");
                        Console.SetCursorPosition(22, 15);
                        Console.WriteLine("Damage: " + enemyManager.attackedLast.damage + "   ");
                        break;
                    case "Evil Clone":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.SetCursorPosition(22, 11);
                        Console.WriteLine("Enemy: " + enemyManager.attackedLast.name);
                        Console.SetCursorPosition(22, 13);
                        Console.WriteLine("Health: " + enemyManager.attackedLast.health + "/" + enemyManager.attackedLast.maxHealth + "   ");
                        Console.SetCursorPosition(22, 15);
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
                        Console.SetCursorPosition(3, 17);
                        Console.WriteLine("Item: " + itemManager.usedLast.name);
                        if (itemManager.notUsed == true)
                        {
                            Console.SetCursorPosition(3, 19);
                            Console.WriteLine("Effect: Your at max health        ");
                        }
                        else if (itemManager.notUsed == false)
                        {
                            Console.SetCursorPosition(3, 19);
                            Console.WriteLine("Effect: You healed " + itemManager.usedLast.effectValue + " health        ");
                        }
                        break;
                    case "Health-Up":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(3, 17);
                        Console.WriteLine("Item: " + itemManager.usedLast.name + "    ");
                        Console.SetCursorPosition(3, 19);
                        Console.WriteLine("Effect: Your health increased by " + itemManager.usedLast.effectValue);
                        break;
                    case "Power-Up":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.SetCursorPosition(3, 17);
                        Console.WriteLine("Item: " + itemManager.usedLast.name + "    ");
                        Console.SetCursorPosition(3, 19);
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

        public void SetInventorySystem(InventorySystem inventory)
        {
            this.inventory = inventory;
        }
    }
}
