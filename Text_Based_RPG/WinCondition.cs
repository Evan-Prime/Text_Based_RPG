﻿using System;
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
            InputManager.IsGameRunning(false, true);
            Console.Clear();
            Console.WriteLine("███████████");
            Console.WriteLine("█ You won █");
            Console.WriteLine("███████████");
            Console.WriteLine("");
            Console.WriteLine("Press any Esc key to Exit");
            Console.ReadKey(true);
        }
    }
}
