using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO; // Stream을 포함하는 namespace. 

namespace _06파일입출력
{
    class Program
    {
        static void Main(string[] args)
        {

            //////////////////////////////
            // Stream Writer ///////
            ////////////////////////

            /*
            FileStream fs = new FileStream("test.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.Close();

            ///////////////////
            //////using문///////
            ////////////////////
            using(StreamWriter sw = new StreamWriter(new FileStream("text.txt", FileMode.Create)))
            {
              // 여기서 이용
            }

            // 파일 입출력 처리.
            // 한 라인으로 만들 수 있어 편리. 
             */
            int Value = 12;
            float Value2 = 3.14f;



            // new로 만든 FileStream 은,  
            // "text.txt"라는 파일을 생성하기위한 파일스트림 이다. 
            // StreamWriter나 StreamReader는 이런 파일스트림 객체를 통해 파일을 쓰거나 읽는 객체이다. 
            // 이 둘은 스트림 객체가 아니라, 스트림 객체를 이용하는 뇨속들이다. 
            using (StreamWriter sw = new StreamWriter(new FileStream("text.txt", FileMode.Create)))
            {
                sw.WriteLine(Value);
                sw.WriteLine(Value2);
                sw.WriteLine("야호");
            }

            StreamWriter sw2 = new StreamWriter("text.txt");
            sw2.WriteLine(Value);
            sw2.Close();
            // 그냥 StreamWriter로만 생성 --> sw2는 무조건 쓰기용.
            // 간단하게 쓰기/ 읽기 용도로만 쓸 때 사용한다. 


            //////////////////////////////
            // StreamReader ///////
            ////////////////////////

            // 이번에 만드는 파일스트림 fs는 FileMode.Open. 즉, 열기 위한 파일스트림이다. 
            // 또한 이 파일스트림의 Access, 접근 방식은
            // = 이 파일스트림에 접근하는 뇨속들은
            // FileAccess.Read. 즉, 읽기 위한 뇨속들만 접근 가능하다. 
            FileStream fs = new FileStream("text.txt", FileMode.Open, FileAccess.Read);


            // 그래서 읽기 전문가인 StreamReader 객체 sr에 fs를 연결시켜 주었다. 
            // sr은 fs에 접근하여, fs를 통해서 "text.txt."파일을 읽을 수 있다. 
            StreamReader sr = new StreamReader(fs);

            int value = int.Parse(sr.ReadLine()); // 본래 int였다 string이 된 value(12)를, 다시 Parse()로 int형으로 형변환해준다. 
            // open했던 파일을 close 해준다. 
            sr.Close();
            Console.WriteLine("{0}", value);
            /////////////////////////////////////////////////////
            // 간단하게 읽기전용 sr2를 만들어서 읽는 방법도 있다.
            ////////////////////////////////////////////
            StreamReader sr2 = new StreamReader("text.txt");
            Console.WriteLine("{0}", sr2.ReadLine());

            Console.ReadKey();

        }
    }
}
