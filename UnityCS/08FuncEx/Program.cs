using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    // 접근제한 지정자를 입력하지 않으면 디폴트로 private. 

    private int LV;
    public int AT;
    private int HP;

    // 속성들은 외부에서 접근하지 못하는게 일반적으로 좋다. 
    // 공격력은 그 자체로 의미가 있지만, 그 의미가 명확해지지 않는다.

    public void SetHP(int _HP)
    {
        HP = _HP;
    }
    
    //함수는 선언과 내용으로 나뉘게 되는데, 

    //void(리턴값) Func(이름 혹은 식별자) () 인자값
    public void Damage(int _Dmg)
        //_Dmg를 외부에서 입력받아서 플레이어에게 전달해주겠다. 
    {
        HP = HP - _Dmg;
    }

    public int DamageToHPReturn(int _Dmg)
    {
        HP = HP - _Dmg;
        return HP;
    }
    public void Damage(int _Dmg, int _SubDmg)

    // 인자는 여러개가 될 수도 있다.  
    {

        HP = HP - _Dmg;
        HP = HP - _SubDmg;
    }

    //함수란 보통 클래스 외부와의 소통을 위해서 만든다.
    public void LVUP()
    {
        LV += 1;
        HP += 100;
        AT += 300;
    }

    // 플레이어의 레벨을 알고싶다. 
    // 인자값이 아니라 리턴값을 사용해본다. 
    // 리턴값은 객체가 자신의 상태를 외부에 알려주는 용도로 사용된다. 
    // 외부에 알려주고나면 함수가 끝난다. 
    // return 이라는 문장을 사용하면 아래에 얼마나 많은 함수가 있든 거기서 끝난다.

    public int GetLV()
    {
        return LV;
    }

}


namespace _08FuncEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            NewPlayer.SetHP(1000);

            NewPlayer.LVUP();

            NewPlayer.Damage(10);
            NewPlayer.Damage(20,5);

            NewPlayer.GetLV();

            Console.WriteLine(NewPlayer.GetLV());
            Console.WriteLine(NewPlayer.DamageToHPReturn(10));


            int a;


        }
    }
}
