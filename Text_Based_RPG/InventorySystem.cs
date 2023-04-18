using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class InventorySystem
    {
        public string[] name;
        public int[] amount;

        public InventorySystem()
        {
            name = new string[3];
            name[0] = "Health-Potion";
            name[1] = "Health-Up";
            name[2] = "Damage-Up";

            amount = new int[3];
            for (int i = 0; i < amount.Length; i++)
            {
                amount[i] = 0;
            }
        } 

        public void InventorySet(int num, int value)
        {
            amount[num] = amount[num] + value;
        }


    }
}
