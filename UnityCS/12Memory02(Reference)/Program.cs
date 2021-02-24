using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    public int AT = 10;
    public int HP = 100;


    // 함수의 추가 설명
    public void Damage(Monster _Monster)
    {
        HP -= _Monster.AT;
    }
    public void ATT(Monster _Monster)
    {
        _Monster.HP -= AT;
    }
 
}

class Monster
{
    public int AT = 10;
    public int HP = 100;


    // 함수의 추가 설명
    public void Damage(Player _Player)
    {
        HP -= _Player.AT;
    }
    public void ATT(Player _Player)
    {
        _Player.HP -= AT;
    }
}



namespace _12Memory02_Reference_
{
    class Program
    {
        static void Main(string[] args)
        {
            // 클래스가 객체화된 녀석은 
            // 레퍼런스 형이라는 자료형이 되고
            // 여태까지 봐왔던 
            // Int, bool 이런 녀석들은 값형이라고 한다. 

            // 이  값형과 레퍼런스형은 메모리의 위치와 사용법이 다르기 때문에
            // 다르게 동작한다. 


            Monster NewMonster = new Monster();
            Player NewPlayer = new Player();

            // 레퍼런스 -> 생성하는 순간 힙에 들어감. 그보다 더 정확한 표현은↘
            // 레퍼런스 --> 힙에 생성된 어떤 메모리의 위치(레퍼런스)를 가르키는 값. 
            // new를 한다는 게 힙 영역에 넣는다는 뜻


            //값형과 레퍼런스형을 구분할 줄 알아야 함. 
            // 기본 자료형을 선언만 하면 그녀석들은 값형. 
            // 자기가 만든 클래스를 new 클래스명();
            //해서 만든걸을 그 클래스명에 받으면 그건 레퍼런스형. 


            
            NewMonster.ATT(NewPlayer);
            NewPlayer.ATT(NewMonster);

            Console.WriteLine(NewMonster.HP);
            Console.WriteLine(NewPlayer.HP);

            //스택 : 함수의 실행 메모리 영역(그 영역 안에 들어있는 지역변수 할당)
            //힙 : new 클래스명() 만들어진 클래스 객체들의 본체가 있는 영역



            Console.ReadKey();
        }
    }
}
