using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    private int HP = 100;
    private int ATT = 40;

    private static int StTest = 2000;

    public static void Damage(Player _this , int _Dmg)
    {
        // 
        _this.HP -= _Dmg;

    }

    public void Damage(int _Dmg)
    {
        // HP -= _Dmg; 에서
        // c#은 어떻게 이 hp가 플레이어2의 hp라는 걸 알 수 있을까?
        this.HP -= _Dmg;
        // this에 대해 알아보자. 

    }

    public void Heal(/*Player _this, */int _Heal)
    {
        /*_this.*/HP += _Heal;
        this.HP += _Heal;
        HP += _Heal;

        // 세 줄의 내용은 같다. 
        // 멤버함수에서 멤버변수를 불러오기위해 this를 쓴다. 
        // 멤버함수에서 멤버변수를 쓴다면
        // 생략되어있지만 사실this가 생략된 것이다. 
        // this.HP라는 것을 잊으면은 안됨.
        // 섣불리 조금 언어를 배워놓고 
        // 다른 곳에 적용하려고 하지 않는게 좋다. 
        // static에서 왜 hp를 쓸 수 없었을까? 
        // static은 this.가 없다. static멤버함수는 자기 자신이라는 객체를 특정할 수 없다. 
        // static은 객체를 만들지 않고도 사용한다. 
        // 자신이라는 개념 자체가 없어야 한다. 
        

    }

    public static void PVP(Player _Left, Player _Right)
    {
        // HP = 100; --> 못씀.
        // static은 객체가 없어도 쓸 수 있다.
        // 이안에서 어느 특정한 객체에 영향을 받지 않는게 static. 
        // 그런데 HP는 어떤 플레이어의 hp. 즉 어떤 객체의 영향을 받는 수치. 
        StTest = 5;

        // static 변수는 가능. 객체에 영향받지 않는 녀석이기 때문에. 


        _Left.HP = 100;
        
    }
}

namespace _16This
{
    class Program
    {
        static void Main(string[] args)
        {

            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
            Player NewPlayer3 = new Player();

            NewPlayer2.Damage(10);


        }
    }
}
