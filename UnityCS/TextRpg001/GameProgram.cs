using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 코드 재활용성. 향상시키기 위한 문법이 
// *상속*이다.
// 즉, 똑같은 코드 두 번 치기 싫어서!
// Player Status다 치고, 복사해서 Monster에도 다 치고 --> 비효율적!

// 에러나 혹은 잘못된 선택에 관한 것도 만든다.
enum STARTSELECT
{
    SELECTTOWN,
    SELECTBATTLE,
    SELECTQUIT,

    NONESELECT
}

// class는 왠만하면 캡슐화. 
// 외부로부터 보호. 즉, public을 남발하진 말자. 


namespace TextRpg001
{
    

    partial class GameProgram
    {
        // 시작을 담당하는 함수.
        // 마을과 사냥터 중 어디로 갈지 선택.
        static STARTSELECT StartSelect() // 둘 중 하나만 return가능
        {

            // 나는 콘솔화면을 모조리 지우는 함수를 찾고싶다.
            // 프로그래머들은 대부분 이성적이고
            // 이름을 직관적으로 짓는다. 
            Console.Clear();
            Console.WriteLine("1. 마을");
            Console.WriteLine("2. 사냥터");
            Console.WriteLine("3. QUIT");
            Console.WriteLine("어디를 가시겠습니까?\n");

            ConsoleKeyInfo KeyInfo = Console.ReadKey();
            
            switch(KeyInfo.Key)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("\n마을로 이동합니다.\n");
                    Console.ReadKey();
                    return STARTSELECT.SELECTTOWN;

                case ConsoleKey.D2:
                    Console.WriteLine("\n사냥터로 이동합니다.\n");
                    Console.ReadKey();
                    return STARTSELECT.SELECTBATTLE;

                case ConsoleKey.D3:
                    Console.WriteLine("\n이야기에서 나갑니다.\n");
                    Console.ReadKey();
                    return STARTSELECT.SELECTQUIT;

                default:
                    Console.WriteLine("\n잘못된 입력입니다.\n");
                    Console.ReadKey();
                    return STARTSELECT.NONESELECT;
            }

            
        }
        
        static void Main(string[] args)
        {
            // 객체지향 프로그래밍이란 결국 클래스로 설계하고 객체로 만들어나가는 것. 

            // 글자로 모든 걸 표현해보자. 
            // 저는 마을과 싸움터로 나눠서
            // 1. 마을로간다 2.싸움터로 간다 일케 하고싶다. 

            Player Player1 = new Player();


            while(true)
            {
                // STARTSELECT SelectCheck = StartSelect();

                switch(StartSelect())
                {
                    case STARTSELECT.SELECTTOWN:
                        Console.Clear();
                        Console.WriteLine("마을에 도착했습니다.");
                        Console.ReadKey();
                        Town(Player1);
                        break;
                    case STARTSELECT.SELECTBATTLE:
                        Console.Clear();
                        Console.WriteLine("사냥터에 도착했습니다.");
                        Console.ReadKey();
                        BattleSpace(Player1);
                        break;
                    case STARTSELECT.SELECTQUIT:
                        Console.Clear();
                        Console.WriteLine("안녕히!");
                        Console.ReadKey();
                        return;
                       
                    case STARTSELECT.NONESELECT:
                        Console.WriteLine("다시 입력해주세요.");
                        Console.ReadKey();
                        break;
                }

            }


        }
    }
}
