using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Unit
{
    // Unit class의 속성들만 모아놓은 cs

    public string ProNAME
    {
        get
        {
            return m_NAME;
        }
        set
        {
            m_NAME = value;
        }
    }
    public int ProAT
    {
        get
        {
            return m_AT;
        }
        set
        {
            m_AT = value;
        }
    }
    public int ProMAXHP
    {
        get
        {
            return m_MAXHP;
        }
        set
        {
            m_MAXHP = value;
        }
    }
    public int ProHP
    {
        get
        {
            return m_HP;
        }
        set
        {
            m_HP = value;
        }
    }
    public int ProGold
    {
        get
        {
            return m_GOLD;
        }
        set
        {
            m_GOLD = value;
        }
    }
    public int ProSPEED
    {
        get
        {
            return m_SPEED;
        }
        set
        {
            m_SPEED = value;
        }
    }

}
