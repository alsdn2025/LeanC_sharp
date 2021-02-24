using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player : Unit
{
    private Inven<Item> PlayerInven = new Inven<Item>(3, 3);

    public Inven<Item> Pro_PlayerInven
    {
        get
        {
            return PlayerInven;
        }
    }
    
    int a = 10; // 인스턴트 필드는 객체에 귀속된다. 
    //int b = a;
    // 아직 객체가 만들어지지 않았다 -> a도 실존하지 않는다. 그저 설계도일 뿐. 그래서 b에 a의값을 넣어라 -> a 자체가 아직 존재하지 않아서 읽지 못한다. 
    //오류

    public Player()
    {
        int c = a; // 가능. 메서드는 객체를 만든 뒤에 사용하게 되므로. 

        ProNAME = "플레이어";
        ProSPEED = RandomSeed.Next(1, 12);
        ProAT = RandomSeed.Next(5, 8);
    }


    static public void Test()
    {
     //   int c = a;
     //   이게 안 되는게 결정적인 힌트.
     //static 메서드 --> 정적.객체에 귀속 x 객체가 없어도 쓸 수 있어야 된다. 
     //그런데 c라는 애를 만들어서 a의값을 넣어라? a라는 애가 아직 안만들어져서 읽지 못함. 
     //인스턴트 필드는 객체에 귀속되므로, 아직 a가 존재하지 않아서 읽지 못하는 것이고,
     //static은 객체가 없어도 작동해야됨으로, 실체 없는 a라는 애의 값을 c에 넣을 수 없는 것. 
    }


    public bool PlayerCostGold(int _Gold)
    {
        if (ProGold < _Gold)
        {
            Console.WriteLine("\n골드가 부족합니다.");
            Console.ReadKey();
            return false;
        }
        ProGold -= _Gold;
        Console.WriteLine("\n골드를 " + _Gold + "만큼 소모했습니다.");
        Console.ReadKey();
        return true;
    }
    
    public void PlayerHealing(int _HealAmount)
    {
        if (m_HP < m_MAXHP)
        {
            if (m_HP + _HealAmount > m_MAXHP)
            {
                _HealAmount = m_MAXHP - m_HP;
            }
            m_HP += _HealAmount;

            Console.Write("\n플레이어의 체력이 " + _HealAmount);
            Console.Write("만큼 회복되었습니다.\n");
            Console.WriteLine("현재 체력 : " + m_HP + " / " + m_MAXHP);
            Console.ReadKey();

        }
        else
        {
            Console.WriteLine("\n최대 체력에 도달해있습니다.");
            Console.WriteLine("더 이상 체력을 회복할 수 없습니다.");
        }
    }

    // 작은 함수는 오히려 많이 만드는게 좋다. 
    // 함수는 비대하지 않을수록 좋다. 
    // 10~5줄짜리 함수를 많이 만들어서 그걸 모아서 또 10~5줄짜리 함수를 만드는게 좋음. 

}
