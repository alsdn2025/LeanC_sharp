// 이 프로그램에서 가장 중요한 코드들이라고 봄. 
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

class Inven<ItemType> // 사실 지금은 제네릭으로 ItemType을 받을 필요 x.
    // 아직 item의 여러 타입을 만들지 않았으니까. 
    // 하지만 나중에 가면 몬스터아이템, 캐쉬아이템, 레어아이템 등등등
    // 매우 여러 아이템 종류를 구현해야 될 것. 
    // 그럴 때 쓰일 것이다. 
    // 여기서 생기는 궁금증.
    // 만약 cashitem이 item의 자식 클래스라고 하자. 
    // 그럼 여러 ItemType중에, 부모인 Item을 넣으라고 표시한 곳에
    // 자식인 CashItem을 넣어도 될까? 되겠지? 업캐스팅이니까?
{

    public enum INVEN_INPUT
    {
        LEFT,
        RIGHT,
        UP,
        DOWN,

        CONTINUE,
        SELECT,
        CHANGE,
        OUT,

        NONE
    }

    // 숙제 : 만들어라. --> 만듦. 
    int SelectIndex = 0;

    Item[] ArrItem;
    int ItemX;
    int ItemY;
    int TmpSlot = 0;
    int ItemCount = 0;
    

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

        Console.WriteLine("\n" + (SelectIndex+1) +".");
        Console.WriteLine("");
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
        if (ItemCount >= ArrItem.Length)
        {
            Console.WriteLine("인벤토리가 가득 찼습니다.");
            Console.ReadKey();
            return;
        }
        for (int i = 0; i < ArrItem.Length; i++)
        { // 인벤토리가 꽉 차면 막히는 기능을 넣자. 
            if (null == ArrItem[i])
            {
                TmpSlot = i;
                break;
            }
        }
        ArrItem[TmpSlot] = _Item;
        ItemCount++;
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
        ItemCount++;
    }

    public void DeleteItem(int _Index)
    {// 인벤토리에 있는 아이템을 없애는 메소드.

        ArrItem[_Index] = null;
        ItemCount--;
    }

    public Item GetItem(int _ItemIndex)
    {
        return ArrItem[_ItemIndex];

    }
    public int GetSelectIndex()
    {
        return SelectIndex;
    }
    
    static public void ExchangeItem(Inven<ItemType> _Costomer, Inven<ItemType> _Seller, int _ItemIndex)// 일단 GOLD 없이. 
    { // 인자값과 반환값으로밖에 메소드끼리 소통하지 못한다는게 아쉽다. 
        
        _Costomer.AddItem(_Seller.GetItem(_ItemIndex));
        _ItemIndex = 10;
        _Seller.DeleteItem(_ItemIndex);
        

    }

    public void InputMoveLeft()
    {
        if (OverCheck(SelectIndex, INVEN_INPUT.LEFT)) { return; }
        SelectIndex--;
    }
    public void InputMoveRight()
    {
        if (OverCheck(SelectIndex, INVEN_INPUT.RIGHT)) { return; }
        SelectIndex++;
    }
    public void InputMoveUp()
    {
        if (OverCheck(SelectIndex, INVEN_INPUT.UP)) { return; }
        SelectIndex -= ItemX;
    }
    public void InputMoveDown()
    {
        if(OverCheck(SelectIndex , INVEN_INPUT.DOWN)) { return; }
        SelectIndex += ItemX;
    }
    
    public bool OverCheck(int _SelectIndex , INVEN_INPUT _Direction)
    {
        switch (_Direction)
        {
            case INVEN_INPUT.LEFT:
                {
                    if(_SelectIndex - 1 < 0) { return true; }
                    break;
                }
            case INVEN_INPUT.RIGHT:
                {
                    if (_SelectIndex +1 >= ArrItem.Length) { return true; }
                    break;
                }
            case INVEN_INPUT.UP:
                {
                    if (_SelectIndex - ItemX < 0) { return true; }
                    break;
                }
            case INVEN_INPUT.DOWN:
                {
                    if (_SelectIndex + ItemX >= ArrItem.Length) { return true; }
                    break;
                }
            default:
                break;
        }
        return false;
    }
    
    public void SelectIndex_Initialization()
    {
        SelectIndex = 0;
    }
    
    public INVEN_INPUT Input()
    {
        switch(Console.ReadKey().Key)
        {
            case ConsoleKey.LeftArrow :
                InputMoveLeft();
                break;
            case ConsoleKey.RightArrow:
                InputMoveRight();
                break;
            case ConsoleKey.UpArrow:
                InputMoveUp();
                break;
            case ConsoleKey.DownArrow:
                InputMoveDown();
                break;
            case ConsoleKey.Enter:
                {
                    return INVEN_INPUT.SELECT;
                }
            case ConsoleKey.Spacebar:
                {
                    return INVEN_INPUT.CHANGE;
                }
            case ConsoleKey.Escape:
                {
                    return INVEN_INPUT.OUT;
                }
            default:
                break;
        }
        return INVEN_INPUT.CONTINUE;
    }

}
