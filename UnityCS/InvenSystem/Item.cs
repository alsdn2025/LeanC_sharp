using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Item
{
    string m_Name;
    int m_Gold;

    // 시작부터 pro 만들고 보는건 사실 좋은 습관 x.
    public string ProName
    {
        get
        {
            return m_Name;
        }
        set
        {
            m_Name = value;
        }
    }
    public int ProGold
    {
        get
        {
            return m_Gold;
        }
        set
        {
            m_Gold = value;
        }
    }

    //생성자. 고정. 
    public Item(string _Name, int _Gold)
    {
        m_Name = _Name;
        m_Gold = _Gold;
    }

}

