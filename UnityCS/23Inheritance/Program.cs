using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 상속 방법은
// 클래스의 공통되는 멤버변수와 멤버함수를 걷어내는 것부터 시작한다. 

// 새로운 클래스에 그 모든 멤버변수와 함수를 넣는다, 
// 상속시킨다. 


class Unit
{
    // public  - 전부공개 / protected - 자식에게 공개 / private - 흥 

    protected int AT = 10;
    protected int HP = 100;

    public void Damage(Unit _FightUnit)
    {
        // 나는 유닛이지만
        // 플레이어의 기능을 쓰고싶어!
        // -> 다운캐스팅. 
        // 그러나, 다운캐스팅은 최대한 지양(피하라).
        // 잘못하면 실수로 플레이어를 몬스터 변경할 수도 있게된다. 

        this.HP -= _FightUnit.AT;


    }

}


class Player : Unit // 이걸 내려준다 --> 상속시킨다고 말함. 
    // c#에서 클래스상속이란 오직 하나만 가능하다. 
    // 하나의 클래스는 하나의 클래스에게서만 상속받을 수 있다. 
{
    int LV = 1;

    void Heal()
    {
        HP += 10;
    }

    public void TestDownCasting(Player _Player)
    {
        Console.WriteLine("IS THIS WORKS?");
    }

}

class Monster : Unit
{
    int Exp = 0;

}

namespace _23Inheritance
{

    // 상속이란 
    // 코드 재활용성을 향상시키기 위해서
    // (똑같은 코드 두 번 치기 싫어서)
    // (사실 함수도 그런 역할이지)
    // 어떤 계열이 있느냐를 파악하는 감. 


    class Program
    {
        static void Main(string[] args)
        {

            // int I_Numb = string S_String; --> 안됨.
            // int 와 string의 메모리 구조는 전혀 다르다. 

            Unit NewUnit = new Unit();
            Player NewPlayer = new Player();
            Monster NewMonster = new Monster();

            Unit UnitTest = NewPlayer;
            // NewPlayer = NewUnit;
            // 부모에게 자식을 넣는 건 가능 --> 부모가 가진 건 자식도 가지고 있으니까. 
            // 반대는 불가능 --> 자식이 가진 것중에 부모에게 없는 것도 존재하니까. 


            // 플레이어의 부분을 모두다 포기하겠다.
            // --> 업캐스팅.
            // 자식이 부모형이 되는 것. 
            // 부모형에 자식을 넣는 것. 
            // 그러므로서 자식의 능력은 버린다.
            // 다운캐스킹

            
            NewPlayer.Damage(NewMonster);

            // Damage(Unit _Unit) <--Unit 형을 넣는 자리에
            // 자식인 NewMonster를 넣어도 함수는 정상작동한다. 
            // 자식인 NewMonster가 Unit형으로 업캐스팅 되기 때문에!

            NewMonster.Damage(NewPlayer);
            // 마찬가지

            // NewPlayer.TestDownCasting(UnitTest);
            // --> 오류. 부모형인 UnitTest를 자식형인 Player로 
            // 다운캐스팅은 자동으로 되지 않기 때문에!

            // 
            // Unit UnitTest = NewPlayer;
            // 이런 식으로 넣든,
            // NewPlayer.Damage(NewMonster);
            // 이런 식으로 넣든 둘 다 개념은 같으며 둘 다 다운캐스팅!

        }
    }
}
