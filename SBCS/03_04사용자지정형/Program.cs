using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    // 사용자 지정형엔 struct, enum , class, interface가 있다. 
    static void Main(string[] args)
    {
        MyStruct Struct_1, Struct_2;
        Struct_1.Age = 10;
        Struct_2 = Struct_1;  
        // 구조체에 다른 구조체를 대입할 경우 값이 복사된다. 
        Console.WriteLine(Struct_2.Age);
         
        // 의문
        MyStruct TestStruct = new MyStruct();
        // 일케 하면 MyStruct라는 객체가 만들어지고
        // 그 객체의 값을 TestStruct에 복사하고
        // MyStruct라는 객체는 사라지는 것? 
        // class를 만들 때와는 다르게 
        // TestStruct라는 객체를 만들어 주는건가? 

        /* 답: 
         * 아니다. 
         * 스택에 Mystruct 객체가 만들어지고, 
         * new 에 의해 힙에도 객체가 만들어지고,
         * = 연산자에 의해 TestStruct에 힙에 있는 객체의 주소값을 담는다. 
         * 값을 복사하는 건 아니다. 힙에 있는 객체가 사라지는 것도 아님. 
         */
         // 그럼 스택메모리가 끝나도-- 즉, 함수가 끝나 Test가 사라져도
         // 힙에 있는 객체는 남아있겠구나. 
         // 아닌가? c#이니까 자동으로 소멸시키려나?




        MyClass TestClass = new MyClass(10);

        Console.WriteLine((byte)MYENUM.AAA);
        Console.WriteLine((byte)MYENUM.BBB);
        Console.WriteLine((byte)MYENUM.CCC);

        Console.ReadKey();

    }

    public struct MyStruct
    // 1. 구조체 struct
    // class와 비슷. 그러나 구조체는 값타임, 클래스는 참조 타입. 
    // 또 구조체는 상속을 하지 못한다. 단 인터페이스는 상속.
    {
        // 구조체 내에 선언된 필드 중 const, static만 구조체 내에서 초기화가 가능하다. 
        // 객체가 만들어지지 않아도! 사용할 수 있어야 하니까! 
        // GOOD~
        public const float PI = 3.14F;
        public static int Static_Age = 12;
        public int Age; // 구조체는 일반 필드에 값을 바로 넣어주지 못한다. 

        public MyStruct(int _Input)
        {
            Age = _Input;
        }
        // 참고로 구조체는 인수가 없는 생성자를 사용하지 못한다.
        // public MyStruct() --> 오류.

    }

    enum MYENUM : byte
    {   // 기본은 int형이지만 , char형을 제외한 형식을 지정 가능
        AAA = 5,
        BBB,   // BBB = 6
        CCC = 8
    }

    class MyClass
    {
        public int Age = 12;
        // 클래스는 일반 필드에 값을 바로 넣어줄 수 있다. 
        
        public MyClass(int _Input)
        {
            Age = _Input;
        }

    }

    // class, interface, deligate, Array[], string
    // 모두 참조형

    // ++ 참고
    /*
     * str1 = "abc"
     * str2 = str1;
     * str2 = "def" 라고 했을 때 왜 str1은 여전히 "abc"를 나타내는가?
     * -> string의 경우 대입연산자를 써서 문자열을 넣으면
     * 새롭게 메모리를 할당하고 문자열을 복사하여 가지게 된다.
     * 즉 = 을 사용하면 참조형이 아닌 인스턴스 변수가 된다. 
     * str1은 참조형, "abc"라는 객체의 주소 자신의 메모리에 저장. 
     * str2는 인스턴스. "abc"자체를 자신의 메모리에 저장. 
     */

}