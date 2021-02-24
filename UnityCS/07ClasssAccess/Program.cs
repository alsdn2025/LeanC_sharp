using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Player
{
    public int HP; // 외부에도 공개
    protected int MP; // 자식에게만 공개
    private int DEF; // 내부에만 공개

    public void Fight()
    {
        Console.WriteLine("싸운다.");
    }
}



namespace _07ClasssAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            // 객체지향의 캡슐화(은닉화)
            // 를 대표하는 문법이 바로 접근제한 지정자.


            Player NewPlayer = new Player();

            // 만들어진 객체의 내용을 사용하기 위해서는
            // 객체의 이름.을 사용한다. 
            // 접근제한 지정자

            // 클래스를 설계할 때는 잘못쓰기도 힘들게 만들어놔라.
            // 너가 내클래스를 어떻게 이용하든 내 클래스는 잘 돌아갈거야. 

            NewPlayer.HP = 0;
            NewPlayer.Fight();

            int a;


        }
    }
}
