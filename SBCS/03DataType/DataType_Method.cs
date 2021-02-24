using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DataType_Method
{
    static bool BoolVar;
    public static void BoolMethod()
    {
        // bool형은 true, false (or 0).  그외의 값은 사용 x
        // bool LocalBoolVar ;
        // 정적 필드인 BoolVar는 따로 할당하지 않아도 기본적으로 false가 할당되어있지만
        // 지역 필드인 LocalBoolVar는 그렇지 않으므로 사용하려면 반드시 값을 넣어줘야만 한다. 
        bool LocalBoolVar = true;

        
        Console.WriteLine("{0} {1}", BoolVar, LocalBoolVar);
    }
    
    public static void CharMethod()
    {// char형은 암시적으로 값이 변환됨
     // ushort, int, uint, long, ulong, float, double, decimal

        // 아스키코드값과 유니코드값이 키보드에서는 같도록 만들어놓았다. 
        char CharVar = '7';
        int IntVar = CharVar; // char -> int로 암시적형변환.
     // int IntVar = (int)CharVar와 같음. 
        // char = '7' 인데, 이 7의 유니코드값은 55.

        // 55 + 1 = 56. 고로 IntVar 는 56.  
        IntVar++;
        // IntVar, 즉 56을 다시 char로 변환해주었다.
        // 유니코드값인 56 -> 유니코드문자 '8'로 변환됨. 
        Console.WriteLine("CharVar = {0} IntVar = {1} 유니코드문자 = {2}", CharVar, IntVar, (char)IntVar);

        CharVar = (char)IntVar;
        Console.WriteLine("CharVar = {0}", CharVar);

    }

    public static void ByteMethod()
    {
        // byte의 유효범위 0~255
        // sbyte는 -128  ~ 127

        int Result;
        byte x = 1, y = 2;
        Result = x + y; // byte가 int로 암시적형변환
        Console.WriteLine(Result);

    }

    public static void ShortMethod()
    {
        // short의 범위는 -32768 ~ 32767
        // ushort는 0~65535
        // short의 유효범위 값을 출력해보자. 
       
        Console.WriteLine("short의 범위 : {0} ~ {1}", short.MinValue, short.MaxValue);
        Console.WriteLine("ushort의 범위 : {0} ~ {1}", ushort.MinValue, ushort.MaxValue);
        // short, float, int 등등에 콤마 . 를찍으면 메소드가 나온다 --> 
        // short, float, int 등등이 객체(여기선 struct)로 정의되어있구나. 
        // 저런 것들은 제공이 되니까 외울 필요는 없구나!
    }

    public static void FloatMethod()
    {
        float FloatVar1 = 3.14f;
        // float FloatVar2 = 3.14; 에러. doublic 타입을 float로 
        // 형변환할 수 없다고 한다. 즉 f를 붙여주지 않으면 소수는 double로 인식한다. 
        // 기본적으로 float형 뒤에는 소수점뒤에 f,F 접미사를 표시.
        // 없으면 double형으로 인식한다!

        Console.WriteLine("FlatVar : " + FloatVar1);

    }

    public static void StringMethod()
    {
        // c,c++문자열에는
        // 문자열 끝에 0, \0가 붙는다. (끝을 의미하는 null문자)
        // char Var[4] = "abcd"가 안된다.

        // 그러나 c#의 string형은 그런 걸 신경쓰지 않아도 된다. 

        string StringVar = "Hello" + " World";

        if (StringVar == "Hello World")
        {
            Console.WriteLine(StringVar);
        } // 이런 식으로 + 연산자, == 연산자 등을 사용할 수 있다.
        Console.WriteLine(StringVar[4]);
        // 기존에 char[index]로 문자 하나를 추출해내듯
        // string도 그대로 적용할 수 있다. 


        Console.WriteLine(@"C:\temp\test.txt");
        Console.WriteLine("C:\\temp\\test.txt");
        // 문자열에 \를 포함하는 경우 이렇게 두 가지 방법으로 표현가능하다. 
        // @를 쓰는 경우가 더 많다. 

    }

    public static void VarMethod()
    {
        // 암시적 데이터타입 var. 
        // 대입되는 데이터에 따라 데이터형이 결정된다.
        // 제네릭이랑 비슷하네?
        // var는 null값의 초기화, 매개변수로는 사용 x.
        // 또 클래스 멤버로는 사용 x. local 필드로만 사용 가능.
        // 연속적으로 초기화 할 수 없음. 
        // var m = 10, n= 20; --> 이게 안 됨. 하나씩. 

        var Var1 = 3.14F;
        var Var2 = 10.0f;
        float Sum = Var1 + Var2;
        Console.WriteLine(" {0} {1:f3} {2}", Var1, Var2, Sum);
        // {1:f1} 은 소수점 1번째 자리까지 출력하라는 뜻. 

    }
   
    public static void Nullable()
    {
        // null을 허용하지 않는 데이터형(기본 데이터형)이 null을 허용하게 하는 방법. 
        // 형식은 
        // 데이터형? 변수형;

        int? IntVar = null;
        bool? BoolVar = null;
        string StringVar = null; // 얜 원래 저장 가능. 

        // nullable은 .HasValue  --> true, false 감별
        // .Value --> 읽기 전용(잘 안쓰임)
        // 라는 멤버를 가지고 있다. 

        if(IntVar.HasValue)
        {
            Console.WriteLine("IntVar에 값이 들어있습니다. ");
        }
        else
        {
            Console.WriteLine("IntVar에 값이 없습니다. ");
        }

        Console.WriteLine("null값 : {0} {1}", BoolVar, StringVar);
        // null값이므로 출력되지 않는다. 

    }


}
