using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Unit
{
    protected int AT;
    protected string NAME = "";

    public Unit()
    {
        int a = 0;
    }

    public void SetName(string _Name)
    {
        NAME = _Name;
    }


}

class Player : Unit
{
    // 생성자라고 한다. 인자가 없는 함수.
    // 특징 : 리턴값이 없다. 
    // 생성자란 클래스 객체가 만들어질때 한 번 실행되는 함수.
    public Player()
        // 눈에 보이지 않지만 만들지 않아도 이 함수는 만들어져있다
        // 무조건 자신의 클래스의 메모리를 리턴해주는 함수이다. 
        // 고로 int void 같은 리턴값 x, 인자 x인 것. 
        // 접근제한 지정자는 있다. -> Player를 만들수조차 없게 할 수도 있다. 
    {

        AT = 100;
        // Unit에 있는 멤버변수 AT를 쓸 수 있다.
        // 객체가 만들어질 때, Player영역보다 Unit이 먼저 만들어지기 때문에. 
        
        int Number = 0;
    }
}

class Monster : Unit
{

    private static Random RanmdomSeed = new Random(); //랜덤 시드값 

    public static string RandomString()
    {
        int MonsterNameLength = RanmdomSeed.Next(1, 6);
        const string strPool = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; //문자 생성 풀 
        char[] chRandom = new char[MonsterNameLength];
        for (int i = 0; i < MonsterNameLength; i++)
        {
            chRandom[i] = strPool[RanmdomSeed.Next(strPool.Length)];
        }
        string strRet = new String(chRandom); // char to string

        return strRet;

    }

    public string GetRandomName()
    {
        string TmpName = "";
        //int NameLength = RanmdomSeed.Next(1, 10);

        string[] Status = { "강한", "에이스", "특별한", "희귀한", "평범한", "졸린눈의", "매서운", "나태한", "격정의", "나약한" };
        string[] Traditional = { "부가티", "엘론소", "마이바흐", "로드란", "케르스", "알라그라", "리오", "알파", "쉬폰", "타이란트" };
        string[] Spices = { "슬라임", "원숭이", "골렘", "여우", "타이거", "놈친미", "늑대", "오크", "고블린", "드래곤" };
        // string[] Decimal = { "1", "2", "3", "7", "0" };
        //string[] SpecialChar = { "야호", "차두리", "강한", "exe", "SSS" };

        //Random NameMode = new Random();
        //Random NameIndex = new Random();

        TmpName += Status[RanmdomSeed.Next(0, Status.Length)];

        TmpName += Traditional[RanmdomSeed.Next(0, Traditional.Length)];

        TmpName += Spices[RanmdomSeed.Next(0, Spices.Length)];
       
        /*
        while (TmpName.Length < NameLength)
        {
         TmpName += Traditional[NameIndex.Next(0,Traditional.Length)];

            switch (NameMode.Next(0, 4))
            {
                case 0:
                    TmpName += Traditional[NameIndex.Next(0,        Traditional.Length)];
                    break;
                case 1:
                    TmpName += Traditional[NameIndex.Next(0,    Traditional.Length)];
                    break;
                case 2:
                    TmpName += Traditional[NameIndex.Next(0,    Traditional.Length)];
                    break;
                case 3:
                    TmpName += Traditional[NameIndex.Next(0, Traditional.Length)];
                    break;
                default:
                    break;
        }
        */
        return TmpName;
    }

    public Monster()
    {
        SetName(GetRandomName());
        Console.WriteLine(NAME);
        Console.ReadKey();
    }


}

namespace _24ClassConstructer
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();

            Monster NewMonster1 = new Monster();
            Monster NewMonster2 = new Monster();
            Monster NewMonster3 = new Monster();
            Monster NewMonster4 = new Monster();
            Monster NewMonster5 = new Monster();

            Monster NewMonster6 = new Monster();
            Monster NewMonster7 = new Monster();
            Monster NewMonster8 = new Monster();
            Monster NewMonster9 = new Monster();
            Monster NewMonster10 = new Monster();

        }
    }
}
