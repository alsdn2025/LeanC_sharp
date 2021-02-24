using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 나는 아이템을 담아두는 인벤토리를 만들고 싶다. 
// 나는 인벤토리를 만드는데, 
// 인벤토리가 최대 몇개를 담을 수 있는지부터
// 정해야 한다고 생각한다. 
// 이때 숫자가 두 개 필요한데, 
// 가로로 [][][][][][][][][] 이것보단
// [][][]
// [][][]
// [][][] <-- 이게 나을테니까. (x,y)가 필요해.
// 그럼 인벤토리 칸은 x*y개구나. 

enum INPUT_DIRECTION
{
    LEFT,
    RIGHT,
    UP,
    DOWN
}
    

class Inven
{
    // 숙제 : 만들어라. --> 만듦. 
    int SelectIndex = 0;

    Item[] ArrItem;
    int ItemX;
    int ItemY;
    int TmpSlot = 0;

    // 인벤토리를 new하려면 int x와 y를 넣어주는 방법밖에 없게 만드는 것. 
    // 인벤토리를 만들 때 오류가 아니 않도록.
    // 잘못 쓰기도 힘들게 만들어라. 
    public Inven(int _X, int _Y) //생성자
    { // 초보프로그래머가 가장 주의해야할 것.
      // 방어코드는 선택이 아니다. 
      // 예) switch문의 default
      // 프로그램이 오작동하지 않게 체크해주는 코드. 

      if(0 >= _X)
        {
            _X = 1;
        }
      if(0 >= _Y)
        {
            _Y = 1;
        }

        ItemX = _X;
        ItemY = _Y;
        ArrItem = new Item[_X * _Y];
        
    }

    public void Render()
    {
        Console.Clear();

        for (int i = 0; i < ArrItem.Length; i++)
        {
            if ((i != 0) && (0 == i % ItemX))
            {
                Console.WriteLine(""); // x값 개수만큼 나오면 줄바꿈.

            }
            
            if(SelectIndex == i)
            {
                Console.Write("▣");

            }

            else if (null == ArrItem[i])
            // 인벤토리가 비었니?
            {
                Console.Write("□");
            }
            else
            {
                Console.Write("■");
            }
            // 자꾸 최적화니 효율을 따지지 말자. 일단은. 

        }

        Console.WriteLine("\n");
        Console.WriteLine("\n" + (SelectIndex+1));

        if (ArrItem[SelectIndex] == null)
        {
            Console.WriteLine("이름 : ");
            Console.WriteLine("가격 : ");
        }
        else
        {
            Console.WriteLine("이름 : " + ArrItem[SelectIndex].ProName);
            Console.WriteLine("가격 : " + ArrItem[SelectIndex].ProGold);

        }

        /*
        for (int i = 0; i < ArrItem.Length; i++)
        {
            if (ArrItem[i] != null)
            {
                Console.WriteLine((i + 1) + ". " + ArrItem[i].ProName);
            }
            else
            {
                Console.WriteLine(i + 1 + ". 비어있음");
            }
        }
        */

    }

    public void AddItem(Item _Item)
    {
        for (int i = 0; i < ArrItem.Length; i++)
        {
            if (null == ArrItem[i])
            {
                TmpSlot = i;
                break;
            }
        }
        ArrItem[TmpSlot] = _Item;
        
    }

    public void AddItem(Item _Item, int _Order)
    {
        if(_Order > ArrItem.Length)
        {
            Console.WriteLine(_Order + "번슬롯이 없습니다. \n");
            Console.ReadKey();
            return;

        }

        if(ArrItem[_Order - 1] != null)
        {
            Console.WriteLine(_Order+"번슬롯이 차있습니다.");
            Console.ReadKey();
            return;
        }

        ArrItem[_Order-1] = _Item;
    }

    public void SelectMoveLeft()
    {
        if (OverCheck(SelectIndex, INPUT_DIRECTION.LEFT)) { return; }
        SelectIndex--;
    }
    public void SelectMoveRight()
    {
        if (OverCheck(SelectIndex, INPUT_DIRECTION.RIGHT)) { return; }
        SelectIndex++;
    }
    public void SelectMoveUP()
    {
        if (OverCheck(SelectIndex, INPUT_DIRECTION.UP)) { return; }
        SelectIndex -= ItemX;
    }
    public void SelectMoveDown()
    {
        if(OverCheck(SelectIndex , INPUT_DIRECTION.DOWN)) { return; }
        SelectIndex += ItemX;
    }
    
    public bool OverCheck(int _SelectIndex , INPUT_DIRECTION _Direction)
    {
        switch (_Direction)
        {
            case INPUT_DIRECTION.LEFT:
                {
                    if(_SelectIndex - 1 < 0) { return true; }
                    break;
                }
            case INPUT_DIRECTION.RIGHT:
                {
                    if (_SelectIndex +1 >= ArrItem.Length) { return true; }
                    break;
                }
            case INPUT_DIRECTION.UP:
                {
                    if (_SelectIndex - ItemX < 0) { return true; }
                    break;
                }
            case INPUT_DIRECTION.DOWN:
                {
                    if (_SelectIndex + ItemX > ArrItem.Length) { return true; }
                    break;
                }
            default:
                break;
        }
        return false;
    }
    

    public void Select()
    {
        switch(Console.ReadKey().Key)
        {
            case ConsoleKey.LeftArrow :
                SelectMoveLeft();
                break;
            case ConsoleKey.RightArrow:
                SelectMoveRight();
                break;
            case ConsoleKey.UpArrow:
                SelectMoveUP();
                break;
            case ConsoleKey.DownArrow:
                SelectMoveDown();
                break;
            default:
                break;
        }
    }

}
