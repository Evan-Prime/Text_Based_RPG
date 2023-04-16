using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    abstract class Enemy : GameCharacter
    {
        public int moveAt;
        public int moveCounter;
        public string name;

        protected Player player;
        protected ItemManager itemManager;

        public Enemy (int x, int y, int tempX, int tempY, Map map, EnemyManager enemyManager, Player player, ItemManager itemManager, int health = 10, int maxHealth = 10, int damage = 5, char icon = '☻', int moveAt = 2, string name = "Enemy") : base(x, y, tempX, tempY, health, maxHealth, damage, icon, map, enemyManager)
        {
            moveCounter = 0;
            this.moveAt = moveAt;
            this.name = name;
            this.player = player;
            this.itemManager = itemManager;
        }

        public abstract void Update();

        public bool MoveCheck()
        {
            bool move = false;
            if (moveCounter >= moveAt)
            {
                moveCounter = 0;
                move = true;
            }
            return move;
        }
    }
}
