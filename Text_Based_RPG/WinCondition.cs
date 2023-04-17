using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal static class WinCondition
    {
        public static void Win()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("████████████");
            Console.WriteLine("█ You Win! █");
            Console.WriteLine("████████████");
            Console.WriteLine("");
            Console.WriteLine("Press any key to Exit.");
            Console.ReadKey(true);
        }
    }
}
