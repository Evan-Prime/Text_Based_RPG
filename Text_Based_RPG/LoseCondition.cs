using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Based_RPG
{
    internal static class LoseCondition
    {
        public static void Lose()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("███████████████");
            Console.WriteLine("█ You Lose ;( █");
            Console.WriteLine("███████████████");
            Console.WriteLine("");
            Console.WriteLine("Press any key to Exit.");
            Console.ReadKey(true);
        }
    }
}
