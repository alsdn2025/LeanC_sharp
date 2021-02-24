using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 정적 변수와
// 정적 함수만을 내부에 둘 수 있는 static class
static class GTest
{
    // 얘는 메모리화 될 수 없다. 
    // 정적 필드와 메소드만 가지고 있을테니까. 
    // so 생성자도 없다. 


        // 제네릭 함수
        // 멤버함수도 포함
        // 자료형을 변수처럼 사용하고 싶을때. 
        // 즉 자료형을 입력하는 쪽에서 자유롭게 입력할 수 있도록. 
    public static Free ConsolePrint<Free, Free2>(Free _Input, Free2 _Input2)
    {
        Console.WriteLine(_Input);

        // 함수의 식별자에 <다양한 자료형을 대표할 이름>을 넣어줌으로서
        // 그 자료형으로 자유롭게 내용을 쓸 수 있어. 
        // c++의 템플릿. 
        return _Input;
    }

    public static Free ConsolePrint<Free>(Free _Input) // 오버로딩도 가능
    {
        Console.WriteLine(_Input);

        // 함수의 식별자에 <다양한 자료형을 대표할 이름>을 넣어줌으로서
        // 그 자료형으로 자유롭게 내용을 쓸 수 있어. 
        // c++의 템플릿. 
        return _Input;
    }


}


class Cashitem : Item
{
    public Cashitem()
    {

    }

    public Cashitem(int _input) :base(_input)
    {

    }


}


class GameItem : Item
{
    public GameItem()
    {

    }

    public GameItem(int _input) :base(_input)
    {

    }
}


class Item
{
    int Value;

    public Item()
    {

    }

    public Item(int _input)
    {
        Value = _input;
    }

    public int ProItem
    {
        get { return Value; }
        set { Value = value; }
    }

}

//제네릭 클래스
class Inven<T>
{
    T[] ArrInvenItem = new T[10];

    public void ItemIn(int _Index, T _Item)
    {
        
        ArrInvenItem[_Index] = _Item;
    }

    static public  void Test(Item _Item)
    {
        Console.WriteLine(_Item);
    }

    public T GetItem(int _Index)
    {
        return ArrInvenItem[_Index];
    }

}

class Player
{

}

class Program
{
    static void Main(string[] args)
    {


        GTest.ConsolePrint("아아아아");
        GTest.ConsolePrint<int>(3); // <>는 써도대고 안써도댐
        GTest.ConsolePrint(3);
        GTest.ConsolePrint(3.12345f);

        int i = 20;
        string s = "dkdkdk";
        Console.WriteLine(s);
        Console.WriteLine(i); // < - 얘네는 제네릭은 아님. 오버로딩을
                              // 여러개 해놓은 것. 

        

        // 이녀석은 무조건 <> 써줘야 대ㅔ
        Inven<GameItem> NewGameInven = new Inven<GameItem>();
        // 인벤은 인벤인데, <GameItem>을 담는 인벤이다!
        Inven<Cashitem> NewCashInven = new Inven<Cashitem>();
        // 인벤은 인벤인데, <Cashitem>을 담는 인벤이다!


        // 제네릭 클래스를 만드는 이유
        // 예를 들어보자 : Inven이라는 애가 있어. 
        // 얘는 item[] Arritem; 이란 필드를 가지고 있어.
        // 근데 item을 두 가지로 나누고 싶은거야. 
        // Cashitem과 Gameitem으로. 
        // 그럼 Inven에다가 item[] 대신 
        // Cashitem[], Gameitem[] 두 개를 다 만들어놔?
        // 아니면 아예 Inven을 GameInven, CashInven 두 개로 나눠?
        // 두 가지 방법 모두 비효율적이지. 
        // 그 아이템타입 하나 빼면 다 똑같을텐데!
        // 그래서 제네릭을 쓰는거야. 
        // Inven<Item_Type> 이런 식으로. 
        // 그럼 필드는 Item_Type[] ArrItem; 이라하면 되겠지. 

        

        NewCashInven.ItemIn(0,new Cashitem(10));
        Inven<Cashitem>.Test(NewCashInven.GetItem(0));




        // 여기서 생기는 궁금증.
        // 만약 gameitem/cashitem이 item의 자식 클래스라고 하자. 
        // 그럼 부모인 Item을 넣으라고 표시한 곳에
        // 자식인 CashItem을 넣어도 될까? 되겠지? 업캐스팅이니까?

        Inven<Item> NewInven = new Inven<Item>();
        NewInven.ItemIn(0, new GameItem(5));
        Inven<Item>.Test(NewInven.GetItem(0));
        // 대넹. 
        // NewInven.ItemIn(int _number, Item _Item)
        // Item타입을 넣는 곳에 GameItem을 넣어도 작동된다. 
        // 반대는 불가능. 
        // NewCashInven.ItemIn(0, new Item(10));
        // 다운캐스팅이니까. 


        Console.ReadKey();

    }
}
