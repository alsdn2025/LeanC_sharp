using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 기본 자료형 = 이미있는 것들. 

// 사용자정의 자료형. 
// class / struct / enum 3총사. 
// 참조형 / 값형 / 값형 사용자 정의. 


enum ITEMTYPE
    // 보통 어떤 상태를 표현하는 것 중
    // 나만의 것을 가지고 싶을 때 사용한다. 
    // 다른언어에선 정수형 상수라고 하는데- . C#에서는 아니다☆
    // 열거형이라고 불리며 사용법
{
    EQUIP,
    POTION,
    QUEST,
    NONESELECT

}

class Item
{
    // class로 일일이 만드는 건 매우 번거롭다. 
    // 보통은 멤버변수로 해결. 
    // int ItemType = 0;
    // 0이면 뭐고, 1이면 뭐고.. 이렇게. 
    // 근데 이러면.. 가독성이 떨어짐. 1이 뭔데?? 이런 식으로. 

    public ITEMTYPE ItemType = ITEMTYPE.EQUIP;

    // so 이런식으로 만든다. 
    // 또한 오류의 가능성을 줄여주기도 한다. 
    // int itemtype = x 로 할경우, x에 무슨 값이든 들어갈 수 있지만
    // 열거형으로 만들면 지정된 수 밖의 수를 넣으면 못들어가게 막는다.

    ITEMTYPE type = ITEMTYPE.POTION;

    
public void PotionTypeSet()
    {
        ItemType = ITEMTYPE.POTION;
    }

}



namespace _22Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Item NewItem = new Item();
            NewItem.ItemType = ITEMTYPE.POTION;
            NewItem.PotionTypeSet();
            
            Console.WriteLine(NewItem.ItemType);

            NewItem.ItemType = ITEMTYPE.EQUIP;
            Console.WriteLine(NewItem.ItemType);
            
            Console.ReadKey();

            ITEMTYPE type = ITEMTYPE.POTION;



            switch (type)
            {
                case ITEMTYPE.EQUIP:
                    break;
                case ITEMTYPE.POTION:
                    break;
                case ITEMTYPE.QUEST:
                    break;
                default:
                    break;
            }
            // switch를 쓰고 doubld tap ->
            // ()안을 type으로 
            // 엔터 두 번 -> 자동화. 

        }
    }
}
