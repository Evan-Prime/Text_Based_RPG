using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class HealthUp: Item
    {
        int healthValue;

        public HealthUp(int x, int y, Player player, int healthValue) : base(x, y, '♥', true, player)
        {
            this.healthValue = healthValue;
        }

        public override void PickUpEffect()
        {
            player.health += healthValue;
            active = false;
        }
    }
}
