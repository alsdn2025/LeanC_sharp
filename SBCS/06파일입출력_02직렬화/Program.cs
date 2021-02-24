using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

class Program
{
    [Serializable]
    struct DATA
    {
        public int var1;
        public float var2;
        public string str1;

        [NonSerialized]
        public string str2;

    }

    static void Main(string[] args)
    {   // 직렬화
        // 구조체, 클래스 단위로 읽고 저장!
        // 구조체, 클래스 상위에 [Serializable]을 표기.
        // 필드에만 적용

        ////////////////////////////////////////
        // 구조체의 내용을 저장하고 읽어보자.///
        ////////////////////////////////////////

        DATA[] Data1 = new DATA[2];

        Data1[0].var1 = 1;
        Data1[0].var2 = 0.5f;
        Data1[0].str1 = "Test1";
        Data1[1].var1 = 2;
        Data1[1].var2 = 1.5f;
        Data1[1].str1 = "Test2";

        using (FileStream fs1 = new FileStream("test.dat", FileMode.Create))
        {
            BinaryFormatter bf1 = new BinaryFormatter();
            // Binary포매터 생성!
            // Format : 구성, 서식을 만들다. 체재를 갖추다. 
            bf1.Serialize(fs1, Data1);
            // fs1-> test파일에, Data1의 구성을 저장(복사)한다.
        }

        /////////////////////////////////////////////////////
        // 이번엔 반대로 파일을 읽어 구조체 안에 저장해보자.

        DATA[] ResultData;

        using (FileStream fs2 = new FileStream("test.dat", FileMode.Open))
        {   // 아까 저장한 test파일을 연다
            BinaryFormatter bf2 = new BinaryFormatter();
            ResultData = (DATA[])bf2.Deserialize(fs2);
            // Deserialize() 는 object타입으로 반환하기 때문에
            // 무조건 형변환을 해주자!
            // ResultData에 fs2->test파일의 내용을 읽고 복사하여 넣는다. 
        }

        for (int i = 0; i < ResultData.Length; i++)
        {
            Console.WriteLine("{0} {1} {2}", ResultData[i].var1, ResultData[i].var2, ResultData[i].str1);
        }

        

        /////////////////////////////////////////////////////////////////
        // 역직렬화에 대해 배워보자. 
        // 직렬화의 대상에서 제외하는 걸 말한다.
        // 필드 앞에 [NonSerialize]를 붙인다. 
        ////////////////////////////////////////////////////////////////

        Data1[0].str2 = "test1";
        Data1[1].str2 = "test2";
        using (FileStream fs3 = new FileStream("test2.dat", FileMode.Create))
        {
            BinaryFormatter bf3 = new BinaryFormatter();
            bf3.Serialize(fs3, Data1);
            // fs3-> test2.dat 파일에 Data1의 내용을 복사한다. 
        }

        using (FileStream fs4 = new FileStream("test2.dat", FileMode.Open))
        {
            BinaryFormatter bf4 = new BinaryFormatter();
            ResultData = (DATA[])bf4.Deserialize(fs4);
            // bf4->fs4->test2.dat의 내용을 ResultData로 내보낸다. 
        }


        for (int i = 0; i < ResultData.Length; i++)
        {
            Console.WriteLine("{0} {1} {2}", ResultData[i].var1, ResultData[i].var2, ResultData[i].str2);
        }  // 위와는 다르게 str2는 복사되지 않는다. 
           // [Npnsirialize] 때문. 

        /////////////////////////////////////////////////////////////////
        // 컬렉션의 직렬화
        // 컬렉션, 제네릭 : 같은 데이터형의 임의의 메모리, 연속적인 메모리를 다룰 수 있도록 하는 클래스. 
        // ArrayList, List<T>
        // 제네릭을 이용한 직렬화 .
        ////////////////////////////////////////////////////////////////

        List<DATA2> ResultList;
        List<DATA2> DataList = new List<DATA2>();
        DataList.Add(new DATA2(7, "test1"));
        DataList.Add(new DATA2(12, "test2"));
        DataList.Add(new DATA2(12, "test2"));
        DataList.Add(new DATA2(12, "test2"));
        DataList.Add(new DATA2(12, "test2"));

        using (FileStream FS = new FileStream("TEST.dat", FileMode.Create))
        {
            BinaryFormatter BF = new BinaryFormatter();
            BF.Serialize(FS, DataList);
            // 방법은 똑같다. 
            // serialize 는 콜렉션, 제네릭, 배열, 구조체 등등 다 가능하다. 
        }

        using (FileStream FS2 = new FileStream("TEST.dat", FileMode.Open))
        {
            BinaryFormatter BF2 = new BinaryFormatter();
            ResultList = (List<DATA2>)BF2.Deserialize(FS2);
            // 역시 형변환하여 result에 넣기. 
        }



        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("{0} {1}", ResultList[i].data, ResultList[i].str);
        }  

        
        Console.ReadKey();

        //**************************************************************
        //*************************************************************
        // 이진 파일, BinaryWriter/Reader + FileStream, 
        // 구조체/클래스의 [serializable] + BinaryFormatter
        // [serializable] + 컬렉션 +BinaryFormatter 은
        // 많이 많이 쓰므로 꼭 기억해두자. 
        //****************************************************************
        //*******************************************************


    }

    // 컬렉션<제네릭> 을 serialize 하기 위한 struct. 
    [Serializable]
    struct DATA2
    {
        public int data;
        public string str;
        
        public DATA2(int _data1, string _str1)
        { // 생성자 고정. 
            data = _data1;
            str = _str1;
        }
    }



}
