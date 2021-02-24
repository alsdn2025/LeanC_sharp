using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Unit
{

    // protected virtual int Test = 1;
    // 이런 뇨속은 안됨. 즉 필드는 x. 
    // 메소드는 가능. 
    // so 오버라이딩의 정식명칭은 '메소드 오버라이딩'
    protected string Name = "";
    protected int AT = 5;
    protected int HP = 100;
    protected int LV = 1;
    // 업캐스팅
    // 첫번째
    // 상속의 개념을 지키기 위해서 -> 코드 재활용성

    /*
    public static virtual void Test()
    {
        // 안 됨. this가 없어서. 
    }
    */


    // 이 문법의 핵심은 자식이 만약 GetAT를 재구현했다면
    // 자식의 GetAT를 호출해주세요. 라는 것. 
    // 이걸 오버라이딩 -> virtual
    // 다형성(동적바인딩)의 핵심 문법 중 하나. 
    // virtual의 뜻 :  자식에서 만약 나의 같은 이름의 함수나 프로퍼티를 재구현(override)했다면 
    // 자식이 재구현한 같은 이름이의 함수나 프로퍼티를 실행해주세요
    protected virtual int GetAT()
    { // 부모가 protected -> 자식도 protected
        Console.WriteLine(Name + "의 getat");
        return AT;
    }

    protected virtual int GetAT(int _VALUE)
    { // 물론 오버로딩도 가능
        Console.WriteLine(Name + "의 getat");
        return AT;
    }

    // 프로퍼티도 virtual 가능
    public virtual int ProAT
    {
        get
        {
            return AT;
        }
    }

    public void Damage(Unit _OtherUnit)
    {
        // 각자 플레이어면 플레이어의 것. 
        // _OtherUnit.AT;

        int AT = _OtherUnit.GetAT();
        HP = +_OtherUnit.AT;
        Console.WriteLine(Name+"이 "+_OtherUnit.Name+"에게서" + AT + "만큼의 데미지를 입었습니다");
    }

}

class Player : Unit
{
    int ItemAT = 5; // 기본 at + 아이템 at 가 진짜 공격력. 

    public Player()
    {
        Name = "플레이어";

    }

    public Player(string _Name)
    {
        Name = _Name;

    }

    // 나는 부모님의 getat를 재구현했다
    // --> override
    protected override int GetAT()
    {
        Console.WriteLine(Name + "의 getat");
        return AT + ItemAT;
    }

    protected override int GetAT(int _VALUE)
    {
        Console.WriteLine(Name + "의 getat");
        return AT;
    }


}

class Monster : Unit
{
    public Monster()
    {
        Name = "몬스터";
    }
    public Monster(string _Name)
    {
        Name = _Name;
    }

    protected override int GetAT()
    {
        return AT + LV;

    }
}

namespace _30OverWriting
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player("크악악");
            Monster NewMonster = new Monster("원숭이") ;

            NewPlayer.Damage(NewMonster);
            NewMonster.Damage(NewPlayer);

            Console.ReadKey();

        }
    }
}
