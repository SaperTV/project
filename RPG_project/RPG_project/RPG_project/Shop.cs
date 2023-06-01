using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_project
{
    public class Shop
    {
        public static int[] shop(int[] character, int MaxHP, int MaxMANA)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("1 - heal 3g \t 2 - UpgradeAtack 10g \t 3 - UpgradeMana 10g \t Press any button to exit ");

            int inp = int.Parse(Console.ReadLine());
            switch (inp)
            {
                case 1:
                    return heal(character, MaxHP);
                case 2:
                    return upAtack(character);
                case 3:
                    return upMana(character);
            }
            Console.WriteLine("You leave the shop");
            return character;
        }
        public static int[] heal(int[] character, int MaxHP)
        {
            Random rnd = new Random();
            int heal = rnd.Next(10,20);
            Console.WriteLine(character[0]);
            if (character[3] >= 3)
            {
                Console.WriteLine("Pay 3 gold");
                character[3] -= 3;
                if (character[0] + heal >= MaxHP)
                {
                    Console.WriteLine("You have max HP");
                    character[0] = MaxHP;
                    return character;
                }
                else 
                {
                    Console.WriteLine($"You were heal at {heal} you have {character[0]}HP");
                    character[0] += heal;
                    return character;
                }
            }
            Console.WriteLine("You have no gold");
            return character;
        }
        public static int[] upAtack(int[] character)
        {
            if (character[3] >= 10)
            {
                Console.WriteLine("Your attack increased by 5 you spend 10 gold");
                character[3] -= 10;
                character[1] += 5;
            }
            else
            {
                Console.WriteLine("You have no gold");
            }
            return character;
        }
        public static int[] upMana(int[] character)
        {
            if (character[3] >= 10)
            {
                Console.WriteLine("Your mana increased by 50 you spend 10 gold");
                character[3] -= 10;
                character[2] += 50;
            }
            else
            {
                Console.WriteLine("You have no gold");
            }
            return character;
        }
    }
}
