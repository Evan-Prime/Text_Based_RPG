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
            InputManager.IsGameRunning(false, true);
            Console.Clear();
            Console.WriteLine("███████████████");
            Console.WriteLine("█ You Lose ;( █");
            Console.WriteLine("███████████████");
            Console.WriteLine("");
            Console.WriteLine("Press the Esc key to Exit.");
            Console.ReadKey(true);
        }
    }
}
