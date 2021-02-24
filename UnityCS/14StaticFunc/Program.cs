using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Player
{
    private int HP = 100;
    private int AT = 10;


    static public void PVP(Player _Left, Player _Right)
    {
        _Left.HP -= _Right.HP;
        _Right.HP -= _Left.HP;
        // Player class의 static에서는 private 사용 가능.
        // static 함수의 장점 : 객체화 x해도 플레이어의 내부는 내부이므로
        // 접근제한 지정자의 영향을 받지 않는다. 

    }

    static public void PVE(Player _Left, Monster _Right)
    {
        
    }

    public void Damage(Player _Other)
    {
        HP -= _Other.HP;
        // 
    }

}

public class Monster
{
    private int HP = 100;
    private int AT = 10;


    static public void PVP(Player _Left, Player _Right)
    {
        // _Left.HP -= _Right.HP; --> 오류.
        // 다른 class의 static에서는 Player의 private 사용 불가. 
    }

    public void Damage()
    {
        HP -= 100;
    }

}



namespace _14StaticFunc
{

    class Program
    {
        //이녀석도 클래스에 속한 정적 함수이다.
        static void Main(string[] args)
            // 어떤 클래스에 존재하는 Main이라는 이름을 가진 정적멤버함수에서부터 c#프로그램이 시작된다. 
        {
            // f12를 누르면 그 클래스로 타고 들어가 볼 수 있다 -> 그 클래스의 세부 내용을 알 수 있게 된다. 
            Console.WriteLine("");
            //Console도 class. 객체화하지 않았는데도WriteLine를 쓰고 있으므로 WriteLine은 정적 멤버 함수!!
            // -> public static void WriteLine(string value);
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();

            //Public인 멤버변수라도 일단 객체를 만들어서 레퍼런스에 받고, .을 이용해서 쓴다. (예: NewP.Dma)

            Player.PVP(NewPlayer1, NewPlayer2);

            // 마찬가지로 그 클래스에 속하지 만!
            // 객체화를 하지 않고도 사용할 수 있는 함수를 정적멤버함수라고 한다. 


            


        }
    }
}
