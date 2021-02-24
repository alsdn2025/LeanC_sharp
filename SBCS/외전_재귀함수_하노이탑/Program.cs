using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 외전_재귀함수_하노이탑
{
    class Program
    {

        void hanoi_tower(int n, char 처음, char 중간, char 끝)
        {
            if(n == 1)
            {
                Console.WriteLine("{0} : {1} -> {2} ",n, 처음, 끝);
            } 
            else
            {
                hanoi_tower(n - 1, 처음, 끝, 중간);
                Console.WriteLine("{0} : {1} -> {2} ", n, 처음, 끝);
                hanoi_tower(n - 1, 중간, 처음, 끝);
            }

        }

        static void Main(string[] args)
        {
            char 처음 = 'A';
            char 중간 = 'B';
            char 끝 = 'C';
            Program P = new Program();
            P.hanoi_tower(4, 처음, 중간, 끝);

            Console.ReadKey();
        }
    }
}
// 이해는 가는데
// 이걸 어케 만들었노