using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static int[] CreateArray1(int _Size)
    {
        int[] Array1 = new int[_Size]; // 실제 객체(배열) 생성
        for (int i = 0; i < Array1.Length; i++)
        {
            Array1[i] = i;
        }
        return Array1; // 주소값 전달. 
    }

    static int[,] CreateArray2(int _Row , int _Col)
    {
        int index = 0;
        int[,] Array2 = new int[_Row, _Col];
        for (int i = 0; i < _Row; i++)
        {
            for (int j = 0; j < _Col; j++)
            {
                Array2[i, j] = index++;
            }
        }
        return Array2; // Array2의 주소가 아니라, 실제 unt[,]형 객체의 주소를 전달
    }


    static void Main(string[] args)
    {

        int[] nArray1;
        int[,] nArray2;

        nArray1 = CreateArray1(5);
        nArray2 = CreateArray2(2,3);


        for (int i = 0; i < nArray1.Length; i++)
        {
            Console.Write(nArray1[i]);
        }
        Console.WriteLine();
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(nArray2[i,j]);
            }
        }

        Console.WriteLine();

        Console.ReadKey();


    }
}

