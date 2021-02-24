using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{


    public enum DMGTYPE
    {
        ATT,
        FIRE,
        ICE
    }

    int AttDef = 5; // 물리방어
    int FireDef = 5; // 불 방어
    int IceDef = 5; // 물방어

    public void Damage(int _Damage)
    {

    }
    // 이름이 같지만, 인자값이 다르다
    // 간단하게 말해, 컴퓨터는 위는 Damageint로, 아래는 
    // Damageintint로 인식한다
    // 이게 함수오버로딩.
    public void Damage(int _Dmg, int _Type)
    {
        switch (_Type)
        {
            default:
                break;
        }
    }

    public Player()
    {

    }
    // 생성자로 오버로딩이 됩니다. 
    public Player(int _HP)

    {
    }

}


namespace _29OverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

        }
    }
}
