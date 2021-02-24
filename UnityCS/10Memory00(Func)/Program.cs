using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 왜 메모리를 알아야 하느냐?
 * 메모리란 사실 모든 프로그램의 근간이 되는 개념이기 때문이다.
 * 메모리의 구조를 아는 것은 코드의 동작 원리를 아는 것과 같다. 
 
 */

class Player
{
    int HP = 100;
    int AT = 10;

    // 함수의 인자값은 지역변수이다. 
    // int _Dmg의 특징 : 함수가 끝나면 사라진다.
    public int Damage(int _Dmg)
    {
        return _Dmg;

    }

}
// 함수가 실행됐다 -> 메모리의 스택에 올라가서 변수만큼의 메모리를 차지함. --> 함수가 종료되면 차지했던 것만큼 다시 사라짐. 메인도 마찬가지. 메인이 끝나면 메인도 스택에서 빠지고 프로그램이 종료됨. 

namespace _10Memory00_Func_
{
    class Program
    {
        // 객체를 만들었다 -> 메모리를 지불했다. 
        // 좀더 근본적인 내용
        // 단 하나도 공짜가 없다. 

        // ↙요녀석을 메인 함수라고 하는데, 
        static void Main(string[] args)
        // 사실 static을 빼면 함수의 모양을 가지고 있고 함수이다.
        // 이곳을 시작이라고 정해놓은 c#의 규칙일 뿐. 
        // 참고로 함수는 메모리화되지 않는다. 포함하는 변수들은 메모리화됨. 만약 main 함수 안에 int value가 있다 --> main의 크기는 최소한 4바이트 이상.  
        {
            Player NewPlayer = new Player();


            Console.WriteLine("");

            int Value = 0;



            Console.ReadKey();

        }
    }
}
