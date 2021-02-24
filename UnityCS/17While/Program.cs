using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17While
{
    class Program
    {
        // 여기서 while/for --> 불가능.
        // 함수 안에서만 사용 가능. 
        // 함수의 인자값은 메모리화되고 값이 변할 수 있어야되는데
        // while for는 반환하거나 저장하는 기능을 가지지 않기 때문에. 


        static void Main(string[] args)
        {
            bool check = true;

            while (check/*bool값이 들어가면 됨.*/)
            {
                //while이나 for 치고 tap tap 하면 지알아서 나옴.
                Console.WriteLine("");

                check = false;


            }
            // while은 쓸 때 일반적으로 빠져나올 수 있는 조건을 넣고 실행해줘야 한다. 

            // for문의 장점 : 접근성. 
            // 한반에 변수를 선언 후 초기화하고
            // 그걸로 조건을 비교하고 변수를 변화시키는 코드를 담음. 
            int i = 0;
            for (; i < 5; i++)
            {
                // 함수 안에서만 언제든지 for/while문 사용 가능.
                Console.WriteLine(i);
            }



            /*
            int Count = 10;

            do
            {
                Console.WriteLine(Count);
                Count--;


            } while (Count >= 0);
           */


            Console.ReadKey();
        }
    }
}
