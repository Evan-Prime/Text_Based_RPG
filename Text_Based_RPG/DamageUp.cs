using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class DamageUp: Item
    {
        InventorySystem inventory;
        int damageValue;

        public DamageUp(int x, int y, Player player, int effectValue, InventorySystem inventory) : base(x, y, '^', true, "Power-Up", effectValue, player, inventory)
        {
            this.damageValue = effectValue;
            this.inventory = inventory;
        }

        public override void Use()
        {
            inventory.InventorySet(2, 1);
            player.damage += damageValue;
            active = false;
        }
    }
}
