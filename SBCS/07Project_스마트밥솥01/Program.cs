using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

// SetCursorPosition 을 이제야 이해할 수 있었다. 
// 콘솔 창 전체를 지우고 다시 쓸 필요 없이, 위치정보를 이용해
// 덮어 씌우면 된다. 편리하다. 



class Program
{
    class RiceCookerMenu
    {
        int TmpSelect = 0;
        string[] Menu = { "  밥넣기 ", "  쌀통  ", "  물통  ", "  취사  " }; // 0, 1, 2, 3

        public int Select_Menu(int x, int y) // x,y  어디에 인터페이스를 위치?
        {
            while (true)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(" -메뉴- ");
                // 메뉴를 콘솔에 출력해야 한다. 
                // 현재 선택되어있는 메뉴는 background를 다르게 설정한다.
                for (int i = 0; i < 4; i++)
                {
                    if(i == TmpSelect)
                    { Console.BackgroundColor = ConsoleColor.Red; }
                    Console.SetCursorPosition(x,y+i+1); // 위치 선정
                    Console.WriteLine(Menu[i]);
                    Console.BackgroundColor = ConsoleColor.Black;
                }


                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.DownArrow:
                        if (OverCheck(ConsoleKey.DownArrow))
                        { TmpSelect++; }
                        break;
                    case ConsoleKey.UpArrow:
                        if (OverCheck(ConsoleKey.UpArrow))
                        { TmpSelect--; }
                        break;
                    case ConsoleKey.Enter:
                        return TmpSelect;
                    default:
                        break;

                }
            }
           
        }

        public string GetMenu()
        {
            return Menu[TmpSelect];
        }

        public bool OverCheck(ConsoleKey _Key)
        {
            switch(_Key)
            {
                case ConsoleKey.DownArrow:
                    if (TmpSelect + 1 >= 4)
                        return false;
                    break;
                case ConsoleKey.UpArrow:
                    if (TmpSelect - 1 < 0)
                        return false;
                    break;
                default:
                    break;
            }

            return true;
        }

        public void RiceHeight(int x, int y, int Amount)
        {
            int Height = Amount / 1000;
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < 18; i++)
            {
                Console.SetCursorPosition(x, 2 + i);
                Console.Write("                     ");
            }
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(x, 19 - i);
                Console.Write(" ⊙ ⊙ ⊙ ⊙ ⊙ ⊙ ⊙");
            }
        }

        public void WaterHeight(int x, int y, int Amount)
        {
            int Height = Amount / 1000;
            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < 18; i++)
            {
                Console.SetCursorPosition(x+1, 2 + i);
                Console.Write("                    ");
            }

            Console.BackgroundColor = ConsoleColor.Blue;
            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(x+1, 19 - i);
                Console.Write("                    ");
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void RiceOfWaterBox(int x, int y)
        {
            int Height = 20;
            Console.SetCursorPosition(x, y);
            Console.Write("┌─────────────────────┐");
            for (int i = 0; i < Height-1; i++)
            {
                Console.SetCursorPosition(x, y + 1 + i);
                Console.Write("│                     │");
            }
            Console.SetCursorPosition(x, y+ 20);
            Console.Write("└─────────────────────┘");
        }

        public void RiceCookerBox(int x, int y)
        {
            int Height = 20;
            Console.SetCursorPosition(x, y);
            Console.Write("┌───────────────────────────────┐");
            for (int i = 1; i < Height; i++)
            {
                Console.SetCursorPosition(x, y + i);
                Console.Write("│                               │");
            }
            Console.SetCursorPosition(x, y+20);
            Console.Write("└───────────────────────────────┘");
        }

        public void RiceCooker_PutIn(int x, int y, bool cook)
        {
            int Height = 5;
            Console.SetCursorPosition(x, y);
            if (cook == true) {
                Thread.Sleep(5000);
                Console.BackgroundColor = ConsoleColor.Red; }
            else
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            for (int i = 1; i < Height; i++)
            {
                Console.SetCursorPosition(x, y+i);
                for (int j = 1; j < 10; j++)
                {
                    Console.Write("⊙");

                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
            
        }

    }

    static void Main(string[] args)
    {
        Console.SetWindowSize(99, 36);
        RiceCookerMenu RiceCooker = new RiceCookerMenu();


        RiceCooker.RiceOfWaterBox(45, 0);
        RiceCooker.RiceOfWaterBox(67, 0);
        RiceCooker.RiceCookerBox(1, 0);

        while (true)
        {
            
            // 콘솔 창 전체를 지우고 다시 쓸 필요 없이, 위치정보를 이용해
            // 덮어 씌우면 된다. 편리하다. 
            switch (RiceCooker.Select_Menu(90, 30))
            {
                case 0:
                    RiceCooker.RiceCooker_PutIn(5, 5, false);
                    continue;
                case 1:
                    RiceCooker.RiceHeight(46, 2, 5000);
                    continue;
                case 2:
                    RiceCooker.WaterHeight(68, 2, 10000);
                    continue;
                case 3:
                    RiceCooker.RiceCooker_PutIn(5, 5, true);

                    break;
                default:
                    break;
            }

        }

        


        Console.ReadKey();
    }
}