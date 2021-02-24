using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int left = 10;
            int right = 20;

            switch(left)
            {
                // case Var : 변수는 안됨. 
                // 오로지 상수와만 비교할 수 있다. 
                case 0:
                case 1:
                    Console.WriteLine("left is 0 or 1" );
                    break;
                    // 이렇게 겹쳐서 쓸 수도 있다.
                case 100:
                    Console.WriteLine("left is " + left);
                    break;
               
                
                default: // else의 역할을 한다.
                    Console.WriteLine("예아");
                    break;
            }

        }
    }
}
