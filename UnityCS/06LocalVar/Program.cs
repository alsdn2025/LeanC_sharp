using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    int Att;
    int Hp;

    void Fight()
    {

        int Damage = 0;
        //선언되는 순간 지역변수는 메모리화되고
        Console.WriteLine("플레이어가 싸운다.");
        
        //끝나면 사라짐
    }
}

//게임에서 쓰기 위해 여기까지 '설계'했다. 


namespace _06LocalVar
{
    // c#은 고지식한 객체지향 언어. 
    // 클래스밖에 모르는 바보!!!
    // 프로그램의 시작조차도 
    // 클래스안에 묶어놔야 한다. 
    class Program
    {
        //시작용 함수가 있는것이고
        static void Main(string[] args)
        {
            int ATT = 0;
            // 함수 안에 있는 녀석들을 지역변수라고 합니다. 
            // 클래스 안에 있으면 멤버변수. 
            ATT = 50;

            // 지역변수 규칙
            // {
            //   내부에서만 사용가능. 예) void Fight()안의 int Damage. 
            // }

            // Console.WriteLine("지역변수에 대해 공부해보자");

            // 객체화라고 하는 굉장히 중요한 작업. 
            // 클래스를 뭐라고 말씀드렸나요?
            // 설계도.  
            Player NewPlayer1 = new Player();
            // Player의 설계도대로 플레이어를 만드는데, 그 이름을 NewPlayer라고 해서, 하나의 설계도를 가지고 객체를 양산할 수 있게 하는 것. 

            Player NewPlayer2 = new Player();

        }
    }
}
