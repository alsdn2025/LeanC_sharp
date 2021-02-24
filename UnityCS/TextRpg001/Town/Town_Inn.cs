using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpg001
{
    partial class GameProgram
    {
        static void Inn(Player _Player)
        {
            Console.WriteLine("\n여관에 도착했다.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("여관주인 : 한 숨 푹 자는데 300골드야. 자고 갈래? ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("1. 예");
            Console.WriteLine("2. 싫어!");
            Console.WriteLine("");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    if (_Player.PlayerCostGold(100))
                    {
                        _Player.PlayerHealing(20);
                        Console.WriteLine("\n푹 자니 개운해졌어!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("--------------------------------------------------");
                        Console.WriteLine("여관주인 : 너 돈 없잖아. 다음에 다시 와. ");
                        Console.WriteLine("--------------------------------------------------");
                        Console.ReadKey();
                        break;
                    }
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("여관주인 : 그래 그럼. 다음에 봐. ");
                    Console.WriteLine("--------------------------------------------------");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("여관주인 : 뭐라고?");
                    Console.WriteLine("--------------------------------------------------");
                    Console.ReadKey();
                    break;

            }


        }


    }
}
