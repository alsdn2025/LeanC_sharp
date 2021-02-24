using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace _999연습
{
    public class A // : IDisposable
    {
        public int Alpha = 10;
        

        
    }

    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("test.txt", FileMode.Create);
            fs.Close();
            
            //Console.WriteLine("\n\n"+1234_3333);

            int n = 1;

            string A1 = "AAA";
            string A2 = "AAA";
            bool Is_A1_Same_A2 = (A1 == A2);
            string A3 = A1;
            
            Console.WriteLine(A1.GetHashCode());
            Console.WriteLine(A2.GetHashCode());
            Console.WriteLine(A3.GetHashCode());

            A1 += "BBB";
            Console.WriteLine(A1.GetHashCode());

            string A = "MyValue";
            int hashcode = A.GetHashCode();
            

            StringBuilder sb = new StringBuilder();
            sb.Append("first string");
            Console.WriteLine(sb[3]);
;
            String ABC = "ABC";
            Console.WriteLine(ABC[1]);

            

            Console.ReadKey();
        }
    }

    class Alpha
    {
        static int S = 100;
        int A = 10;
        int B = S;
        //int C = B;  // 필드를 static이 아닌 필드의 값으로 초기화할 수 없다. 

        public readonly int r = 100;

        public Alpha()
        {
            int a = 10;
            int b = a;  // 생성자 안에서는 가능. 
            r = 200;
        }

    }
}
