using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


partial class Unit
{
    protected static Random RandomSeed = new Random(); //랜덤 시드값 

    protected string m_NAME = "None";
    protected int m_AT = RandomSeed.Next(5, 10);
    protected int m_MAXHP = RandomSeed.Next(50, 100);
    protected int m_HP = 50; // 시작부터 HP가 달아있다. 
    protected int m_GOLD = 3000;
    protected int m_SPEED = RandomSeed.Next(5, 10);

    public bool IsDeath() // public
    {
        return m_HP <= 0; //연산자도 함수에 가깝다.
                          // 연산자도 Return값이 있다. 
    }
    
}
