using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Monster : Unit
{

    public static string RandomString()
    {
        int MonsterNameLength = RandomSeed.Next(1, 6);
        const string strPool = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; //문자 생성 풀 
        char[] chRandom = new char[MonsterNameLength];
        for (int i = 0; i < MonsterNameLength; i++)
        {
            chRandom[i] = strPool[RandomSeed.Next(strPool.Length)];
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
        string[] Spices = { "슬라임", "원숭이", "골렘", "여우", "타이거", "놈친미", "늑대", "오크", "고블린", "드래곤", "나가" };
        // string[] Decimal = { "1", "2", "3", "7", "0" };
        //string[] SpecialChar = { "야호", "차두리", "강한", "exe", "SSS" };

        //Random NameMode = new Random();
        //Random NameIndex = new Random();

        TmpName += Status[RandomSeed.Next(0, Status.Length)];

        TmpName += Traditional[RandomSeed.Next(0, Traditional.Length)];

        TmpName += Spices[RandomSeed.Next(0, Spices.Length)];

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

    // public Monster(String _Name) --> 인자값을 넣어 만들어줄 수도 있다. 
    public Monster()
    {
        ProNAME = GetRandomName();
        ProMAXHP = RandomSeed.Next(10, 100);
        ProHP = RandomSeed.Next(10, m_MAXHP);
        ProSPEED = RandomSeed.Next(1, 12);
        ProAT = RandomSeed.Next(7, 11);
        ProGold = RandomSeed.Next(100, 1001);
    }

}