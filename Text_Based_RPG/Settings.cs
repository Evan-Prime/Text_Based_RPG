using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal static class Settings
    {
        static public Random random = new Random();

        static public int RandomNum(int min, int max)
        {
            return random.Next(min,max);
        }

        static public void CursorVisablityFalse()
        {
            Console.CursorVisible = false;
        }
    }
}
