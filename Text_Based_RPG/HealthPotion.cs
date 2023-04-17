using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class HealthPotion : Item
    {
        int healValue;

        public HealthPotion(int x, int y, Player player, int effectValue, InventorySystem inventory) : base(x, y, '+', true, "Health-Potion", effectValue, player, inventory)
        {
            this.healValue = effectValue;

        }

        public override void Use()
        {
            if (player.health < player.maxHealth)
            {
                player.health = player.health + healValue;

                if (player.health > player.maxHealth)
                {
                    player.health = player.maxHealth;

                }

                active = false;
            }
        }
    }
}
