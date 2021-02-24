using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRpg001
{
    partial class GameProgram
    {
        static void BattleSpace(Player _Player)
        {
            // 플레이어의 체력이 0라면 return; 한다. 
            if (_Player.IsDeath())
            {
                Console.Clear();
                Console.WriteLine("체력이 없습니다. 마을에서 회복하십시오. ");
                Console.Read();
                return;
            }
            Monster NewMonster = new Monster();
            Console.Clear();
            Console.WriteLine(NewMonster.ProNAME + "이(가) 나타났다!");
            Console.ReadKey();
            
            bool EndSequence = true;
            while (EndSequence)
            {
                Console.Clear();
                _Player.StatusRender();
                NewMonster.StatusRender();
                Console.ReadKey();
                // 둘 중 누군가 죽을때까지 싸우게 만들어보세요.
                // 한 쪽이 죽으면 마을로 자동이동. 
                // 가장 단순한 부분부터 만들어가라. 
                // 가장 기본적인 것이 되면 그다음부터 추가. 

                Console.WriteLine("1.싸운다");
                Console.WriteLine("2.도망친다");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        _Player.Battle(_Player, NewMonster);
                        if (_Player.IsDeath())
                        {
                            Console.WriteLine("\n눈앞이 깜깜해졌다...\n");
                            Console.ReadKey();
                            EndSequence = false;
                        }
                        else if (NewMonster.IsDeath())
                        {
                            Console.WriteLine(NewMonster.ProNAME + "을 물리쳤다!\n");
                            Console.ReadKey();
                            EndSequence = false;
                        }
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine("\n성공적으로 도망쳤다!");
                        EndSequence = false;
                        break;

                    default:
                        break;

                }


            }

        }

    }
}
