using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// 내가 만들었건 만들지 않았건
// 내가 가용할 수 있는 코드를
// 인터페이스라고 한다. 콘솔의 인터페이스, 유니티의 인터페이스... (c#의 interface를 의미하는게 아님)
// 어떻게 설계하는지는 각자의 선택에 따라 다르다. 


class Program
{
    static void Main(string[] args)
    {
        Inven NewInven = new Inven(5,3);

        Item NewItem1 = new Item("철검", 100);
        Item NewItem2 = new Item("천갑옷", 100);
        Item NewItem3 = new Item("바나나", 100);
        //이제 인벤에 아이템을 넣고 싶다. 



        NewInven.AddItem(NewItem1);
        NewInven.AddItem(NewItem2);
        NewInven.AddItem(NewItem3);
        
        NewInven.AddItem(new Item("파란포션", 100), 5);
        // 알아서 처리해줄거라는 생각 자체를 하지 말라. 
        // 방어 코드를 설계!!

        


        while (true)
        {
            // 이런 객체간의 구조를 만들 때 약간 도움이 될만한 규칙들. solid. 
            // SOLID : 객체지향 개발 5대 원리. 
            // 1. 단일책임의 원칙
            // 2. 개방폐쇄
            // 3. 어쩌구 치환
            // 4. 인터페이스 분리 // 이거 말할라고. 
            // 5. 의존성역젼
            // 
            // 인터페이스 분리원칙은 
            // ex) 함수를 잘개 쪼개서 만든다음에
            // 그 잘게 쪼갠 함수들을 조합해서 새 기능을 만들어 내라. 예 : get(), set(), Damage() 등등
            NewInven.Render();
            NewInven.Select();



        }
        


    }
}