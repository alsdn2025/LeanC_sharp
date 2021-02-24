using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        
        float FloatVar = 100f;
        string StringVar = "문자열";
        string SumString = FloatVar + StringVar;
        // int형/부동소수형 + 문자열 시, 자동으로 문자열로 변환!\
        Console.WriteLine(SumString);


        ///////////////
        // is 연산자 //
        ///////////////
        // 형식 호환을 조사하는 연산자. 
        // A is B
        // 호환이 되면 TRUE, 안되면 FALSE
        // 박싱과 언박싱, 참조 변환에서 사용한다. 
        // 많이 쓰진 않지만, 알고 있어야 한다!
        object ObjectVar = 10;
        int IntVar = 10;
        if (IntVar is float)
            Console.WriteLine("호환됨");
        else
            Console.WriteLine("호환 안됨");
        if (FloatVar is int)
            Console.WriteLine("호환됨");
        else
            Console.WriteLine("호환 안됨");
        if(IntVar is object) // 박싱
            Console.WriteLine("호환됨");
        else
            Console.WriteLine("호환 안됨");
        if (ObjectVar is int) // 언박싱
            Console.WriteLine("호환됨");
        else
            Console.WriteLine("호환 안됨");

        /////////////////////////////////////////////
        // as 연산자 //////////////
        //////////////////////
        // 형변환을 하고, 변환을 조사. 
        // 변환이 되면 변환. 안되면 null 리턴. --> 받는 변수를 nullable형으로 선언해줘야 한다. 예 : int? float? 
        // (int), (float) 등과 비슷한 역할. 
        // 결과형 = 참조형,언박싱,박싱 as 변환형
        string Str1 = "123";
        ObjectVar = Str1;
        string Str2 = ObjectVar as string; // string형은 nullable형.
        Console.WriteLine(Str2);

        A A_Test = new A();
        ObjectVar = A_Test; // ObjectVar는 A형식이 된다. 
        B B_Test = ObjectVar as B;  
        if (B_Test == null)
            Console.WriteLine("형변환 실패");
        else
            Console.WriteLine("형변환 성공");
        // A와 B는 전혀 다르기에 호환 x. 
        // 형변환에 실패한다. 

        /////////////////////////////////////
        // NULL 병합 연산자 : ??////////
        ////////////////////////////
        // C = A ?? B
        // A가 NULL이 아니면 A를 C에 대입
        // A가 NULL이면 B를 C에 대입(즉 b도 null 이면 c에null 대입

        int? x = null;
        int y = x ?? -1; // 만약 y를 Write했는데 -1이 나오면
                         // 아, x는 null 형이구나. 라고 알려주기위해 사용한다. 
        if(y == -1)
        {
            Console.WriteLine("x는 null");
        }

        ///////////////////////////////////////////////////



        Console.ReadKey();

    }

    class A
    {

    }
    class B
    {

    }

}
