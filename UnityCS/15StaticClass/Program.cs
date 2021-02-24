using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    static void Main(string[] args)
    {
        // 함수의 위치는 문법적으로 어디에 있는 상관 x
        // 어디에 있는 거기서 프로그램이 시작될 뿐.
        Console.WriteLine("Console.WriteLine은 정적멤버함수에용");

        Console.ReadKey();

    }
    
}

static class StClass
    // 정적 클래스란
    // 정적 멤버 변수와
    // 정적 멤버 함수만을 가질 수 있는 클래스이다.
{
    // int a = 0; -> 선언만 해도 오류, 
    static int a = 0;
    // --> 오류 x. 


}


namespace _15StaticClass
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
        }
        */
    }
}
