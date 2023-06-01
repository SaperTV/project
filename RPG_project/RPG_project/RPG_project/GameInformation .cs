using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class GameInformation
    {
        public static void informations(int[] charcer, int round)
        {
            Console.WriteLine($"------------------- round - {round} -------------------");
            Console.WriteLine($"HP {charcer[0]} ATACK {charcer[1]} MANA {charcer[2]}  GOLD {charcer[3]}");
            Console.WriteLine($"1 - Let's go | 2 - Spels |3 - Shop |");
            Thread.Sleep(900);
        }
    }
}
