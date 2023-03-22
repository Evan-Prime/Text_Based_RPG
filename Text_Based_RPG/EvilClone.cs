using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal class EvilClone: Enemy
    {
        public EvilClone (int x, int y, int tempX, int tempY) : base (x, y, tempX, tempY, 10, 5, '☻', 2)
        {

        }
    }
}
