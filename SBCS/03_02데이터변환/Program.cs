using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{ // 변환에 대해 배워보자. 
    static void Main(string[] args)
    {
        // 가장 기본은 
        // 기본데이터형.ToSting. 기본데이터형을 문자열로 변환. 
        // 기본데이터형.Parse() --> 문자열로 바꾼 것을 다시 기본데이터형으로 바꾼다. 
        // Convert.ToInt32() --> 이런 식으로도 가능. 
        // Convert.ToSingle() --> float 

        int Value = 123;
        string Str1 = Value.ToString();
        Console.WriteLine(Str1);

        int Value2 = Convert.ToInt32(Str1);
        Console.WriteLine(Value2);

        string Str2 = "3.14";
        float FloatVar = float.Parse(Str2); // 이 때 Parse()안에 원래 기본데이터형이었던 Str2가 아니라, 
        // 새로운 문자열인 "123"을 넣으면 오류가 발생한다. 
        Console.WriteLine(FloatVar);


        // 신기하당

        /////////////////////////////////////////////////
        // 박싱 : 데이터형을 최상위 Object형으로 변환하여
        // 힙에 저장. 
        
        // IntVar를 Object형으로 자동형변환(업캐스팅)하여 
        // 힙에 저장한다. <-- 중요
        int IntVar1 = 123;
        object obj = IntVar1;

        // 모든 데이터들은 object형을 최상위 클래스로 두고 상속받고 있기 때문에 가능하다.

        ////////////////////////////////////////////////
        // 언박싱 : 힙에 저장된 형식을 다시 원래의 형식으로 변환.

        int IntVar2 = (int)obj;
        // 오예!
        Console.WriteLine(IntVar2);

        // 박싱, 언박싱 과정에서 힙 메모리의 공유가 발생하는지 (포인터같은 참조형인지)
        // 또는 복사가 발생하는 것인지 확인해 보자. 

        int i = 123;
        object o = i;
        i = 456;
        Console.WriteLine("{0} {1} ", i, (int)o );
        // i와 o는 각자 다른 값을 나타내며
        // 복사가 발생한 것이라는 것을 알 수 있다. 
        // 별도의 메모리를 사용하는 것이다. 







        Console.ReadKey();
        
    }
}