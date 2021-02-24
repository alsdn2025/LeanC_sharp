using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


struct StructData // ctrl + shift + u -> 대문자.
{
    //클래스와 비슷한데 안되는 것이 있다. 
    // int a = 0; --> 오류. 
    // = 0 이 안된다. --> 리터럴 초기화가 안된다. =100도 안됨.

    public int a;
    public int b;

    //왜냐, =0이 기본이기 때문에.

    public void Func()
    {
        a = 100;
        b = 200;
    }


}


namespace _21Struct
{
    class Program
    {
        static void Test(StructData _Data)
        {
            _Data.a = 1000;
            
        }
        // 위와 아래는 같다. 
        static void TestNumber(int _Number)
        {
            _Number = 1000;

        }

        static void Main(string[] args)
        {
            int Numb = 100; // 값형. 이 numb는 스택에 있음.  고로 함수가 종료되는 순간 스택에 있던 값형 자체도 사라지므로 선언된 함수 내에서만 사용 가능. 저 위의 Test함수에서는 사용할 수 없음!!!!
            // 그런데, 레퍼런스 즉 참조형은 자체는 힙 영역에 있으며, 함수 안에선 그것의 주소를 가르킬 뿐. 

            StructData NewData = new StructData();
            // 이게 왜 안돼??
            // 아 정말.. 이런것도 안되고.. 
            // --> 이런 마음가짐 x. 마치 한글 문법보고 마음에 안든다고 하는 것과 같은 것. 



            NewData.a = 10;
            NewData.b = 20;

            // 참조형(레퍼런스)과 값형이 있다. 
            // 

            Test(NewData);

            // 테스트 결과로 알 수 있듯, struct는 레퍼런스가 아닌 값형이다!!!
            // 고로 값이 바뀌지 않는다. struct는 스택에 있다!
            // 구조체 struct는 값형이다

            //くっそお！！！！
            


            Console.ReadKey();

        }
    }
}
