﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class HealthUp: Item
    {
        int healthValue;

        public HealthUp(int x, int y, Player player, int effectValue) : base(x, y, '♥', true, "Health-Up", effectValue, player)
        {
            this.healthValue = effectValue;
        }

        public override void Use()
        {
            int formerMaxHealth = player.maxHealth;
            player.maxHealth += healthValue;
            if(player.health == formerMaxHealth)
            {
                player.health = player.maxHealth;
            }
            
            active = false;
        }
    }
}
