using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class Character
    {
        public static int[] characterClassSelection()
        {
            while (true)
            {
                Console.WriteLine("MAGE - 1 \t WARRIOR - 2 \t TANK - 3");
                string inp = Console.ReadLine();
                if (inp == "1")
                {
                    int[] m = { 50, 50, 300,0};
                    return m;
                }
                else if (inp == "2")
                {
                    int[] w = { 200, 20, 0, 0};
                    return w;
                }
                else if (inp == "3")
                {
                    int[] t = { 350, 15, 0, 10 };
                    return t;
                }
                else
                {
                    Console.WriteLine("This class does not exist");
                }
            }
        }
        public static bool isAlive(int[] character)
        {
            if (character[0] <= 0)
                return false;
            return true;
        }
    }
}
