using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02기본구조
{
    class Program // c#은 하나 이상의 클래스 정의가 필수.
    {
        static void Main(string[] args) // CLR가 실행되는 첫 부분.
            // 꼭 있어야 함. 
            // 객체가 없어도 실행되어야 하기 때문에 static
            // voic로 해도 되고, int로 해도 되고. 다른것도 가능.
            // Main()안에 인자를 넣을 수도 있다. 
        {
            System.Console.WriteLine();
            // system이란 namespace안의 Console이란 클래스 안의
            // WriteLine() 이라는 static(정적) 메소드. 
            Console.WriteLine();
            // using을 씀으로서 system.을 생략한다. 
            // write(), writeline() 둘 다 수많은 오버로딩을 이용하여 만들어진 메소드이다. 

            Console.Write(3.14f);
            Console.WriteLine();

            Console.WriteLine("{0} {1} {0}", 123, 123.45);
            // {순서} , 실제출력할 인수
            Console.WriteLine("{0:C} {1:P} {0:X}", 123, 123.45);
            // C : 통화(원)  P : 퍼센트  X : 16진수화



            Console.ReadKey();

        }
    }
}
