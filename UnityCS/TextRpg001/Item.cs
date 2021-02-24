using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CashItem : Item
{
    private int Cash = 0;

    public CashItem(string _Name, int _Gold, int _Cash) : base(_Name, _Gold) // base(n,g) : 부모의 생성자에 n,g를 넣어라. 
    {
        this.Cash = _Cash;

    }
}

class Item
{
    protected string m_Name;
    protected int m_Gold;

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

    // 자식을 가지려면 무조건 ()인 생성자가 필요한가? -->NO
    // 1. ()인 생성자 (디폴트생성자)를 만드는 방법도 있지만
    // 2. base 를 이용하여 부모 생성자에 인자를 넣어주는 방법도 있다. 
    // ++ 자식이 만들어질 때 부모에 있는 private도 같이 만들어지나 접근을 못하는 것이며, 부모의 생성자가 먼저 호출 된 후 자식의 생성자가 호출된다. 
    // 이 때 부모 생성자의 필요한 조건을 메워주는 게（埋める）---> base.
    // 또 하나 배웠다. 

}

