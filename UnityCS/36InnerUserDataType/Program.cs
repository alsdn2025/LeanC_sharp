using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum PLAYERJOB
{ // 다른곳에도 정의될 수있는데, 플레이어만 씀--> 비효율적이네!
    // PLAYER 안에 넣자!
    NOVICE, //초보자
    FIGHTER,
    KNIGHT,
    MAGE,
    ARCHER
}


class Player
{
    public enum PLAYERJOB
    { // 다른곳에도 정의될 수있는데, 플레이어만 씀--> 비효율적이네!
      // PLAYER 안에 넣자!
      
        NOVICE, //초보자
        FIGHTER,
        KNIGHT,
        MAGE,
        ARCHER
    }

    // 플레이어의 직업에 관련된 멤버변수를
    // 직업과 관련된 멤버변수도 있어야 할 것. 
    void ClassChange()
    {

    }
}

class PlayerInven : Inven
{
    public void InheritTest()
    {
        SelectIndex = 100;
    }
}


class OtherClass
{
    public void OtherTest(Inven _Inven)
    {
        _Inven.SelectIndex = 100;
        Inven.TestNumb = 1;
        TestNumb = 1;
    }
}

class Inven
{
    private int SelectIndex = 0;
    private static int TestNumb = 1;

    // 이런 식으로 class 안에 또다른 부록 class를 넣어둘 수도 있다.  --> 이너클래스라고 한다. 
    class InnerInven
    {
        // Inven.SelectIndex = 100;
        // SelectIndex = 100;
        // public void Test2()
        // {
        //    SelectIndex = 100;
        // }
        // 이건 안됨. 설령 SelectIndex가 public이어도 안됨.
        // 왜냐 : 이너클래스는 자식 클래스와 다름. 
        // 자식클래스처럼 부모클래스의 필드를 가지고 있는게 아니다. 
        // InvenSlot이란 클래스에 SelectIndex라는 필드는 없다. 

        public void InnerTest(Inven _inven)
        {
            _inven.SelectIndex = 100;
            Inven.TestNumb = 2;
            TestNumb = 1;
            SelectIndex = 10;

        }
        // 이너클래스는 자식클래스와 비슷한 것 같지만 다르다. 
        // 구조적 차이점 말고 이용할 때 차이점--->
        // 자식클래스는 자신에게도 부모클래스에서 정의된 필드가 있는 것처럼 이용할 수 있는 반면에, 
        // 이너클래스는 가진을 가진 상위클래스의 필드를 가진 것처럼 이용할 수는 없다. 
        // 그러나, 이너클래스는 메소드 안에서 상위클래스의 접근제한지정자를 무시할 수 있다. 
        // 메소드에서 이너클래스는 상위클래스와 동일하게 취급. 
        // + 심화 : 상위 클래스의 정적멤버변수를 마치 자신도 가진 것처럼 이용할 수 있다.  


    }

    public void InnerClassTest()
    {
        InvenSlot NewSlot = new InvenSlot();
    }
    
    // 자신과 밀접히 관련된 자료형들은
    // 자신이 들고있는 게 좋다. 
    public enum INVENDIR
    { // 이러면 어떤 장점이 있는가?
      // 1. 이름이 겹치는데서 자유롭다. 
        ID_LEFT,
        ID_RIGHT,
        ID_UP,
        ID_DOWN
    }

    void SelectMode()
    { // 어느 방향으로 움직이겠느냐?


    }
}


namespace _36InnerUserDataType
{


    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            Player.PLAYERJOB a = Player.PLAYERJOB.ARCHER;


        }
    }
}
