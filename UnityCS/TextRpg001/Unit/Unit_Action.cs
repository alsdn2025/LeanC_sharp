using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


partial class Unit
{
    // Unit class의 속성을 제외한 Method들을 모아놓음. 

    public int Damage(Unit _AttackedUnit)
    {
        int Damage = m_AT;
        if (_AttackedUnit.m_HP <= m_AT)
        {
            Damage = _AttackedUnit.m_HP;
        }
        return Damage;
    }

    public bool Attack(Unit _AttackedUnit)
    {
        int Dmg = Damage(_AttackedUnit);
        Console.WriteLine(m_NAME + "의 공격!");
        Console.ReadKey();

        _AttackedUnit.m_HP -= Dmg;
        Console.WriteLine(_AttackedUnit.ProNAME + "은 " + Dmg + "의 피해를 입었다!");
        Console.ReadKey();
        if (_AttackedUnit.IsDeath())
        {
            Console.WriteLine(_AttackedUnit.ProNAME + "은 쓰러졌다!\n");
            Console.ReadKey();
            return false;
        }
        return true;

    }

    public void Battle(Unit _LeftUnit, Unit _RightUnit)
    {
        // bool EndSequence = true;
        if (_LeftUnit.ProSPEED == _RightUnit.ProSPEED)
        {
            int BattleSequence = RandomSeed.Next(1, 3);
            if (BattleSequence == 1)
            {
                if (_LeftUnit.Attack(_RightUnit))
                {
                    _RightUnit.Attack(_LeftUnit);
                }
            }
            else if (BattleSequence == 2)
            {
                if (_RightUnit.Attack(_LeftUnit))
                {
                    _LeftUnit.Attack(_RightUnit);
                }
            }

        }
        else if (_LeftUnit.ProSPEED > _RightUnit.ProSPEED)
        {
            //_LeftUnit.Attack(_RightUnit);
            if (_LeftUnit.Attack(_RightUnit))
            {
                _RightUnit.Attack(_LeftUnit);
            }
        }
        else
        {
            //_RightUnit.Attack(_LeftUnit);
            if (_RightUnit.Attack(_LeftUnit))
            {
                _LeftUnit.Attack(_RightUnit);
            }
        }

    }

    public void StatusRender()
    {
        Console.Write("--------------------------------\n");
        Console.Write("이름 : " + m_NAME);
        Console.WriteLine("");
        Console.Write("공격력 : " + m_AT);
        Console.WriteLine("");
        Console.Write("체력 : " + m_HP + " / " + m_MAXHP);
        Console.WriteLine("");
        Console.Write("스피드 : " + m_SPEED);
        Console.WriteLine("");
        Console.Write("골드 : " + m_GOLD);
        Console.WriteLine("");
        Console.Write("--------------------------------\n");
    }

    public int PrintHP()
    {
        Console.WriteLine("");
        Console.Write("체력 : " + m_HP + " / " + m_MAXHP);
        Console.WriteLine("");
        return m_HP;
    }

}
