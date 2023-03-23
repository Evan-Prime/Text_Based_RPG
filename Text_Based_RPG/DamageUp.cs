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

        public DamageUp(int x, int y, Player player, int damageValue) : base(x, y, '^', true, player)
        {
            this.damageValue = damageValue;
        }

        public override void PickUpEffect()
        {
            player.damage += damageValue;
            active = false;
        }
    }
}
