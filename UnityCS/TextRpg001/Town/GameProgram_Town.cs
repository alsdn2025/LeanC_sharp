using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TextRpg001
{
    partial class GameProgram
    {
       
        static STARTSELECT Town(Player _Player)
        {
            // shopinven 이라는 인벤토리를 만들어줌. 
            Inven<Item> ShopInven = new Inven<Item>(5, 5);
            ShopInven.AddItem(new Item("철검", 500),1);
            ShopInven.AddItem(new Item("천갑옷", 300),2);
            ShopInven.AddItem(new Item("돌칼", 300),4);
            ShopInven.AddItem(new Item("녹슨 도끼", 350),5);
            ShopInven.AddItem(new Item("빨간 포션", 50),6);
            ShopInven.AddItem(new Item("파란 포션", 30),10);
            ShopInven.AddItem(new Item("뭔가 수상한 지팡이", 50), 13);
            ShopInven.AddItem(new Item("천갑옷", 300), 16);
            ShopInven.AddItem(new Item("돌칼", 300), 20);
            ShopInven.AddItem(new Item("녹슨 도끼", 350), 21);
            ShopInven.AddItem(new Item("빨간 포션", 50), 22);
            ShopInven.AddItem(new Item("파란 포션", 30), 24);
            ShopInven.AddItem(new Item("파란 포션", 30), 25);


            while (true)
            {
                Console.Clear();
                _Player.StatusRender();

                Console.WriteLine("\n마을에서 무엇을 하시겠습니까?");
                Console.WriteLine("1.여관에 들려 체력을 회복한다.");
                Console.WriteLine("2.대장관에 들른다.");
                Console.WriteLine("3.상점에 들른다.");
                Console.WriteLine("4.마을을 나간다.\n");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Inn(_Player);
                        break;
                    case ConsoleKey.D2:
                        break;
                    case ConsoleKey.D3:
                        Shop(_Player, ShopInven);
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine("");
                        Console.WriteLine("마을을 나갑니다.\n");
                        Console.ReadKey();

                        // 함수의 분기.
                        // 함수의 통합. 
                        // 객체를 선언해야 될 때 이 세개가 초반 프로그래밍의 전부.

                        return STARTSELECT.NONESELECT; // 나간다. 
                    default:
                        break;
                }
            }
        }

    }
}
