using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG_project
{
    internal class Monsters
    {
        public static int[] genrateMonster()
        {
            Random rnd = new Random();
            int[] monsterStatystic = new int[4];
            for (int i = 0; i < monsterStatystic.Length; i++)
            {
                monsterStatystic[i] = rnd.Next(10,20);
            }
            return monsterStatystic;
        }
        public static int[] faight(int[] player)
        {
            Console.WriteLine("MONSTER");
            int[] monster = genrateMonster();
            while (monster[0] > 0)
            {
                player[0] -= monster[1];
                monster[0] -= player[1];
                if (player[0] <= 0)
                {
                    Console.WriteLine("R.I.P.");
                    break;

                }
                else if (monster[0] > 0)
                {
                    Thread.Sleep(900);
                    Console.WriteLine($"Fight - player HP {player[0]} you take {monster[1]} DMG = monster {monster[0]} you deal {player[1]} DMG");
                }
                else
                    Console.WriteLine($"Fight - player HP {player[0]} you take {monster[1]} DMG");
                    Console.WriteLine("Congratulations you killed the monster!!!");
                    break;
            }
            player[3] += monster[3];
            return player;
        }
    }
}
