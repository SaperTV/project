using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class Spels
    {
        public static int[] SpelsBook(int[] character, int MaxHP, int MaxMANA)
        {
            Console.WriteLine("1 - heal");
            string inp = Console.ReadLine().ToLower();
            switch (inp)
            {
                case "1":
                    return Heal(character,MaxHP,MaxMANA);
                default:
                    return character;
            }
        }
        public static int[] Heal(int[] character, int MaxHP, int MaxMANA)
        {
            if (character[2] >= 100)
            {
                character[0] = MaxHP;
                character[2] -= 100;
                Console.WriteLine("You have max HP");
                return character;
            }
            else
            {
                Console.WriteLine("You have no mana");
            }
            return character;
        }
    }
}
