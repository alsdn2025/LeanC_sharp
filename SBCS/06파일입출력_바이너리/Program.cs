using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // BinaryWriter로 써보자
        // BinaryWriter : 기본 이진 형식을 스트림에 쓰는 애들.
        // StreamWriter랑 비슷! 한데 이진형식일 뿐이다. 
        using (BinaryWriter bw = new BinaryWriter(new FileStream("test.dat", FileMode.Create)))
        // FileStream 객체는 "test.dat" 파일에 대한 스트림이며,
        // Create 생성 전용 스트림이다. 
        // BinaryWriter bw에 이 스트림을 연결시킨다. 
        {
            // 그리고 파일에 쓴다.
            bw.Write(12);
            bw.Write(3.14f);
            bw.Write("안녕!!");
            // Binary와 아스키코드값이 맞지 않아 데이터가 깨진 상태로 저장된다. 
        }
        /////////////////////////////////////////////////

        //BinaryReader로 읽어보자

        int var1;
        float var2;
        string str1;

        using (BinaryReader br = new BinaryReader(File.Open("test.dat", FileMode.Open)))
        // 객체를 생성하지 않고도 File.Opne을 사용--> static!
        // File.Open 메서드는 자동으로 파일스트림을 FileMode에 맞게 생성하여준다. 
        // 자동생성된 파일스트림을 통해, 저장된 바이너리 파일을 열어서 그 주소를 br에 전달한다. 
        // br. 을 통해 BinaryReader의 여러 메소드를 사용한다. 
        {
            var1 = br.ReadInt32();
            var2 = br.ReadSingle();
            str1 = br.ReadString();
        }
        Console.WriteLine("{0} {1} {2}", var1, var2, str1);
        // WOW!!
        // 안녕!!!

        // using문을 사용하기 때문에 close()를 사용할 필요가 없다. 

        ////////////////////////////////////////////
        // 구조체를 Binary로 저장하고 읽어보자//////
        ////////////////////////////////////////////

        Data[] DataArray = new Data[2];

        DataArray[0].var1 = 7;
        DataArray[0].var2 = 3.14f;

        DataArray[1].var1 = 12;
        DataArray[1].var2 = 0.5f;

        BinaryWriter bw2 = new BinaryWriter(File.Open("test_Struct.txt", FileMode.Create));
        for (int i = 0; i < DataArray.Length; i++)
        {
            bw2.Write(DataArray[i].var1);
            bw2.Write(DataArray[i].var2);
        }

        bw2.Close();
        // writer로 썼으니 reader로 읽어보자

        int MyVar1;
        float MyVar2;
        BinaryReader br2 = new BinaryReader(File.Open("test_Struct.txt", FileMode.Open));
        while (true) // 일부러 계쏙 돌려보자
        {
            try
            {
                MyVar1 = br2.ReadInt32();
                MyVar2 = br2.ReadSingle();
            }
            catch (EndOfStreamException e) // 돌리다 파일 끝에 도달한 예외가 발생하면
            {
                br2.Close(); // 파일을 닫는다. 

                break;
            }
            Console.WriteLine("{0} {1}", MyVar1, MyVar2);
        }

        // Console.WriteLine("{0} {1}", MyVar1, MyVar2);
        // while, for 안에서 초기화시 밖에서는 할당x로 본다. 
        // 가능하면 초기화는 밖에서 시켜주고 사용할 것!


        Console.ReadKey();


    }
    struct Data
    {
        public int var1;
        public float var2;
    }
}

