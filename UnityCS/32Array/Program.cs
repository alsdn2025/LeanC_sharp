using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32Array
{
    class Item
    {
        public string Name;
        public int AT;
        public int LV;
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 배열은 기본자료형에 속하는 자료형이다. 

            int[] ArrInt = new int[10];
            // [0][0][0][0][0]...

            // Arrint는 int의 배열형(int의 집합)
            // Arrint[0]은 무슨자료형인가?
            // -> int형.

            // C#에서는 모든 자료형은 클래스 혹은 구조체에 가깝다. 
            // 그 말은 즉슨, 멤버 변수와 멤버 함수가 있다는 것.


            // 배열 : 
            // 여러개가 모여서 연속되어있다. 
            // 접근방법 : 그 모여있는 자료들에 접근하는 법.

            

            for (int i = 0; i < ArrInt.Length/*-->property 라는 걸 알 수 있다.+get만 있구나.*/; i++)
            {
                ArrInt[i] = i;
                Console.WriteLine(ArrInt[i]);
                Console.WriteLine("ArrInt["+ i + "]는 " + ArrInt[i]);

            }

            Console.ReadKey();

            Item[] ArrItem = new Item[10];
            // 이 녀석은 referance형이므로 
            // 이렇게 한다고 객체가 10개 생긴 건 아니다!
            // Item이라는 참조형을 '담을 수 있는 공간'이 10개 생겼다는 뜻.
            // 착각하지 말라! new Item() -> 이게 실제 객체를 만드는 것. 
            // new Item[100]; --> 이건 아이템을 100개 담을 수 있는 '공간'을 만든다는 것!

            Item NewItem = new Item();
            Item NewItem2 = NewItem;
            // 하나의 아이템 객체를 NewItem과 NewItem2 두 개가 가르키고 있는 것.
            // NewItem은 실제 객체의 주소를 가르키고 있을 뿐. 
            // 즉 주소값이 들어있을 뿐. 
            // NewItem2에 NewItem에 들어있는 주소를 넣어주라는 뜻. 



            for (int i = 0; i < ArrItem.Length; i++)
            {
                ArrItem[i] = new Item();
                // 이렇게 해야 그 공간에 객체를 만들어 실제로 담는 것!

            }

            ArrItem[0].Name = "철검";
            ArrItem[1].Name = "녹슨 도끼";
            ArrItem[2].Name = "천 갑옷";
            ArrItem[3].Name = "피붙은 단도";

            for (int i = 0; i < ArrItem.Length; i++)
            {


            }




        }
    }
}
