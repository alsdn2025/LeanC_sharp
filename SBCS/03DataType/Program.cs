using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // 문법을 배우기 이전 배워야 하는게 데이터형.
        // 문법을 구성할 수 있게 해주는 본질적인 내용이라서!

        // 데이터형은 CTS에서 정의된 객체이다. 
        // (1강내용 : ⊙ CTS 는 공통데이터형과 형식을 정의한다. )

        // 기본 데이터형- 정수형
        // char : 2byte를 가지며, 이는 UNIcode의 크기와 같다. 
        // byte : 1byte. 
        // sbyte : 음의 부호를 쓸 때 s를 붙인다. 1byte
        // short : 2byte. 
        // ushort : u를 붙이면 -> 양(+). 2byte.
        // int : 4byte. 
        // uint : 양의 int. 4byte. 
        // long : 8byte. 

        // 실수형
        // float 4byte / double 8byte / decimal 16byte. 
        // float 는 System.Single로 되어 있다. 

        // 문자열형  --> c, c++에선 없었던 것. 
        // c, c++은 문자의 집합이므로 Array/포인터를 이용했었으나 
        // c#에선 아예 새로운 데이터형을 만들어 이용한다. 
        // 고로 c, c++ 에서의 strlen()같은 함수도
        // string.Lenth()와 같이 만들어져 있다! 
        // string 

        Console.WriteLine("----------------정수----------------------");
        DataType_Method.BoolMethod();
        DataType_Method.CharMethod();
        DataType_Method.ByteMethod();
        DataType_Method.ShortMethod();
        Console.WriteLine("----------------실수----------------------");
        DataType_Method.FloatMethod();

        Console.WriteLine("----------------문자열--------------------");
        DataType_Method.StringMethod();
        Console.WriteLine("----------------Var----------------------");
        DataType_Method.VarMethod();
        Console.WriteLine("----------------nullable----------------------");
        DataType_Method.Nullable();












        Console.ReadKey();
    }
}
