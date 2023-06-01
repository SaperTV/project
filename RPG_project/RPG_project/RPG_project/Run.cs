using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class Run
    {
        static void Main(string[] args)
        {
            int[] character = Character.characterClassSelection();
            int round = 0;

            int maxHp = character[0];
            int maxMana = character[2];

            while (Character.isAlive(character))
            {
                GameInformation.informations(character, round);
                string inp = Console.ReadLine().ToLower();
                switch (inp)
                {
                    case "1":
                        Console.WriteLine("Fight");
                        Monsters.faight(character);
                        break;
                    case "2":
                        Console.WriteLine("Spels");
                        Spels.SpelsBook(character, maxHp, maxMana);
                        break;
                    case "3":
                        Shop.shop(character, maxHp, maxMana);
                        Console.WriteLine("Shop");
                        break;
                    default:
                        Console.WriteLine("This command does not exist");
                        break;
                }
                round += 1;
            }
            Console.WriteLine("Thanks for playing");
            Console.ReadKey();
        }
    }
}
