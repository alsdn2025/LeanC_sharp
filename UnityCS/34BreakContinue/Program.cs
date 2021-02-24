using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                if( 0 != i%2 || i == 0)
                {
                    // while문에도 가능
                    // 만약 이 문장을 만나면
                    // 반복문의 증감문으로 바로 이동한다. 
                    // while일땐 조건문으로
                    continue;
                }
                Console.WriteLine(i);

            }

            for (int i = 0; i < 100; i++)
            {
                if (i == 50)
                {
                    // while문에도 가능
                    // 만약 이 문장을 만나면
                    // 가장 가까운 반복문에서 탈출
                    break;
                }
                Console.WriteLine(i);

            }

            int[] Test = new int[10];

            Console.WriteLine(Test.Length);


            Console.ReadKey();


        }
    }
}
