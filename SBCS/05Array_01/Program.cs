using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Array_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array_name;
            // 참조형이므로 배열명[5] 등으로 정해놓을 필요가 ㅇ벗다!
            array_name = new int[] { 1, 2, 3 };
            array_name = new int[3] { 1, 2, 3 };
            // 두 가지 방법. 
            // 아래는 크기를 고정시켜놓았기 때문에, 4번째 값을 넣을 수 없다.
            int[] yeah = { 1, 2, 3 };
            // c#에선 이런 기능도 제공. 알아서 메모리 생성해서 알아서 넣어 준다. 
            foreach (var item in yeah)
            {
                Console.WriteLine("{0}", item);
            }

            /////////////////////////////////////////////
            // 이차원 배열, 다차원 배열을 배워보자!! 크아악!!!!!!
            // 행, 열, 면은 콤마(,)로 구분 /////////////////////////
            // 선언 형식
            // 데이터형[,] 배열명;
            // 데이터형[,,] 배열명;
            int[,] IntArray_1 = new int[2, 2];
            int[,,] IntArray_2 = new int[2, 2, 2];

            int[,] IntArray_3 = new int[,] { { 1, 2 }, { 2, 3 } }; // [2,2]
            int[,,] IntAray_4 = new int[,,] { {{ 1, 2 }, { 3, 4 }}, {{ 5, 6 }, { 7, 8 }} }; // [2,2,2]

            int[,] IntArray_5 = { { 1, 2 }, { 3, 4 }, { 5, 6 } }; // [3,2]
            int[,,] IntArray_6= { {{ 1, 2 }, { 3, 4 }, { 5, 6 }}, // [2,3,2
                {{ 7, 8 }, { 9, 10 }, { 11, 12 }} };
            //////////////////////////////////////////////////////

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(IntArray_5[i, j] + " ");
                }
                Console.WriteLine("");
            }
            


            Console.ReadKey();

        }
    }
}
