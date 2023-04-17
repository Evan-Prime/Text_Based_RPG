using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class DamageUp: Item
    {
        int damageValue;

        public DamageUp(int x, int y, Player player, int effectValue) : base(x, y, '^', true, "Power-Up", effectValue, player)
        {
            this.damageValue = effectValue;
        }

        public override void Use()
        {
            player.damage += damageValue;
            active = false;
        }
    }
}
