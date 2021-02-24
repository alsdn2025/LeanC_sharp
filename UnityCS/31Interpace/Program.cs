using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 사용자 정의 자료형인데 , 
interface QUEST_NPC
{
    // int A = 0;
    // Interface는 필드를 가질 수 없다. 
    // 메소드만 가능하다!!

    // 함수의 형태만 물려줄 수 있는 문법이다. 

    void Talk(QUEST_NPC _OtherUnit);
    // 함수의 내용을 쓸 수 없다. 
    // 접근제한지정자도 쓸 수 없다. 


}

class Unit
{
    protected int AT;
    protected int HP;

    public void Dmg(Unit _OtherUnit)
    {

    }

}

// 인터페이스는 함수구현을 강제할 수 있다. 
// 즉, interface를 받았으면 무조건 interface의 함수를
// 써야한다. 
// class같은게 아니다. 상속같은게 아니다. 
// 그저 조건을 붙인다고 생각하면 될 것 같다. 
// 얘는 무조건 ~~는 있어야 하는 애다. 라는 것. 
class Player : Unit , QUEST_NPC
{
    public void Talk()
    {

    } // 얘 혼자만 있어선 안됨

    public void Talk(QUEST_NPC _OtherUnit)
        // 일케 인터페이스와 동일한 구조의 함수가 있어야 한다. 
    {
         
    }
}

class NPC : Unit , QUEST_NPC
{
    public void Talk(QUEST_NPC _OtherUnit)
    {

    }
}



namespace _31Interface
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
