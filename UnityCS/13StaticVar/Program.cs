using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    public static int PlayerCount = 0;
    // static을 붙이게 되면 정적멤버변수라고 한다.
    // 정적멤버변수는 일반적인 멤버변수와는 다르게
    // 객체화를 하지 않고도 사용할 수 있다. 

    // 객체를 통해서는 쓸 수 없지만, 클래스 안에서는 사용할 수 있다.
    // 어떤 클래스끼리 공유하고 싶은 값에 쓴다. 
    // 예를 들어 현재 존재하는 몬스터들의 수. 
    // 객체를 아무리 만들어도 정적 멤버는 그 객체와의 관련성은 객체 내부에서 사용할 수 있다 뿐이지 객체의 개수만큼 꼭 만들어지는 건 아님, 
    // 즉 모든 객체가 공유하는 하나의 변수가 됨. 
    // 몬스터 분류코드 / 죽은 횟수 등등등. 

    Player.PlayerCount += 1;

    public int AT = 10;
    public int HP = 100;

    public void Setting(int _AT, int _HP)
    {
        AT = _AT;
        HP = _HP;
    }

    public void View()
    {
        Console.WriteLine("AT:"+ AT + " HP:" + HP);
    }

}

class Monster
{
    public static int MonsterDeathCount;

    public void Death()
    {
        MonsterDeathCount += 1;

    }

}

class SidePlayer
{

    // static이 붙지 않은 멤버변수들은 객체 하나하나가 자신의 것을 가진다. 
    // player 1, 2, 3이 있으면 1, 2, 3만의 x,y값이 존재.
    public int X = 0;
    public int y = 0;


    //정적멤버변수는 객체에 귀속 x. 클래스 그 자체에 귀속되며 힙,스택이 아닌 데이터 영역에 메모리가 올라간다. 
    // so player 1, 2, 3 이 있어도 StNumb는 하나다. 

    static public int StNumb;





}

namespace _13StaticVar
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer1 = new Player();
            Player.PlayerCount += 1;
            Console.WriteLine(Player.PlayerCount);
            Player NewPlayer2 = new Player();
            Player.PlayerCount += 1;
            Console.WriteLine(Player.PlayerCount);
            Player NewPlayer3 = new Player();
            Player.PlayerCount += 1;
            Console.WriteLine(Player.PlayerCount);

            // static으로 정의한 정적멤버변수 PlayerCount는 힙도 스택도 아닌 데이터 영역에 존재하게 된다. 
            // 객체들을 통해서 정적멤버변수를 사용할 수 없다. 
            // 예 : NewPlayer.PlayerCount (x)
            // Player.PlayerCount (o)


            NewPlayer1.Setting(10, 100);
            NewPlayer2.Setting(20, 200);
            NewPlayer3.Setting(30, 300);

            NewPlayer1.View();
            NewPlayer2.View();
            NewPlayer3.View();

            Monster NewMonster1 = new Monster();
            Monster NewMonster2 = new Monster();
            Monster NewMonster3 = new Monster();

            NewMonster1.Death();
            NewMonster3.Death();


            Console.WriteLine(Monster.MonsterDeathCount);

            


            Console.ReadKey();


        }
    }
}
