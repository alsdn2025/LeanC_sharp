using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19If
{
    class Program
    {
        //컨트롤 rr 누르면 전부 바꿀 수 있다. 

        static void Main(string[] args)
        {
            int Test= 200;

            if (Test == 10)
            {
                Console.WriteLine("예아");

            }
            else if( 0< Test && Test < 10)
            {

                Console.WriteLine(":D");

            }
            else
            {
                Console.WriteLine(Test);
            }



            Console.ReadKey();
        }
    }
}
