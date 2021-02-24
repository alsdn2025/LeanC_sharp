using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Player
{
    int AT = 10;
    static int StaticAT = 100;
    
    // 자료형을 선언했다면 이는 그 자료형과 관련된 함수라고 
    // 명시하는 것. 
    public int ProAT // static 도 가능. 
    {
        // 함수와 비슷하나, 어떤 멤버변수나 자료형 하나만 목표로 하는. 
        // 프로퍼티의 get 함수는 무조건 int를 리턴한다고 보고
        get
        {
            return AT;
        }

        // set은 무조건 int 하나가 들어온다고 생각한다. 
        // 그런 외부 값들을 프로퍼티에서는
        // value라고 기호로 정의해 놨다. 
        set
        {
            AT = value;
            // value는 넣어주는 값. 
        }
    }

    public static int StaticProAT
    {
        get
        {
            return StaticAT;
        }

        set
        {
            StaticAT = value;
        }
    }

    public int TestAT
    {
        get; set;
    } 
    // 자동구현 프로퍼티. 필드(멤버변수)에 값을 넣거나 하는게 아니라
    // 임시적으로 Private 필드를 하나 만들고 그걸로 get, set하는 것 .


}


namespace _26Property
{

    class Program
    {
        // CTRL + SPACE -> 자동완성.
        // CTRL + SHIFT + U -> 대문자로
            
  
        static void Main(string[] args)
        {
            Player.StaticProAT = 200;

            Player NewPlayer = new Player();

            NewPlayer.ProAT = 100; // SET
            int TmpAT = NewPlayer.ProAT; // GET
                                         // 일케 씀. 함수가 아니라 
                                         // 마치 public 멤버변수(필드)처럼 사용한다.

            NewPlayer.TestAT = 5000;
            TmpAT = NewPlayer.TestAT;

            Console.WriteLine(NewPlayer.TestAT);
            Console.WriteLine(NewPlayer.ProAT);
            Console.ReadKey();


            Console.WriteLine(Player.StaticProAT);


            Console.ReadKey();


        }
    }
} // Property --> 특정 필드의 get/set을 위한 함수. 
