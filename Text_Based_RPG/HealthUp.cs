using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class HealthUp: Item
    {
        InventorySystem inventory;
        int healthValue;

        public HealthUp(int x, int y, Player player, int effectValue, InventorySystem inventory) : base(x, y, '♥', true, "Health-Up", effectValue, player, inventory)
        {
            this.healthValue = effectValue;
            this.inventory = inventory;
        }

        public override void Use()
        {
            int formerMaxHealth = player.maxHealth;
            inventory.InventorySet(1, 1);
            player.maxHealth += healthValue;

            if(player.health == formerMaxHealth)
            {
                player.health = player.maxHealth;
            }
            
            active = false;
        }
    }
}
