using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // 가변 배열
        // 형식 : 데이터형[][] 배열명;
        int[][] MyArray = new int[3][];
        // 행이 먼저 생성. [3]
        // 각 행에 붙여질 열을 생성할 수 있음.
        MyArray[0] = new int[2];
        MyArray[1] = new int[3];
        MyArray[2] = new int[4];
        // □□              0,0  0,1
        // □□□            1,0  1,1  1,2
        // □□□□          2,0  2,1  2,2  2,3
        // 이런 모양.

        // 사용 예 2
        int[][] MyArray2 = new int[3][];
        MyArray2[0] = new int[2] { 99, 2 };
        MyArray2[1] = new int[3] { 3, 4, 5 };
        MyArray2[2] = new int[] { 6, 7, 8, 9 }; // 일케도 가능
                                                // 값도 넣어줌. 

        // 사용 예3
        int[][] MyArray3 = new int[][]
        {
            new int[] {1,2,3,4},           //□□□□     (0,0)(0,1)(0,2),(0,3)
            new int[] {5,6,7,8,9},         //□□□□□   (1,0)(1,1)(1,2)(1,3)(1,4)
            new int[] {10,11,12,13,14},    //□□□□□   (2,0)(2,1)(2,2)(1,3)(1,4)
            new int[] {15,16,17}           //□□□       (3,0)(3,1)(3,2)
        };
        // 각자 선호하는 대로 사용한다. 

        // 사용 예4
        int[][] MyArray4 =
        {
            new int[] {1,2,3,4},
            new int[] {5,6,7,8,9},
            new int[] {10,11,12,13,14},
            new int[] {15,16,17}
        };
        // 점점 짧고 편해진다. 

        for (int i = 0; i < MyArray4.Length; i++)
        {
            for (int j = 0; j < MyArray4[i].Length; j++)
            {
                Console.Write(MyArray4[i][j] + " ");
                if (MyArray4[i][j] < 10) { Console.Write(" "); }
            }
            Console.WriteLine();
        }

        int[][] Test = new int[1][];


        /*
        int[][][] MyArray5 = new int[][][]
        {
            new int[][] {{1,2}, { 3, 4 }},
            new int[][] {{1,2}}

        };
        */// 이건 왜 안될까? 추론. 
        // new int[] {1,2,3,4} : new 로 int[]라는 참조형을 만들어서, 
        // 힙에 만든 {1}{2}{3}{4} 라는 연속된 메모리의 주소를 할당. 
        // new int[]를 여러개 하여 그런 주소를 여러개 모아
        // 그 주소의 {}{}{} 연속된 메모리의 주소를 MyArray4에게 할당. 

        // new int[][] {{1,2}, { 3, 4 }}
        // new 로 int[][]라는 참조형을 만듦. 
        // 힙에 {1}{2} 하나, {3}{4} 하나 총 두 개의 연속된메모리 주소를 만듦.
        // 이 두 개의 메모리 주소를 int[][]에 전달? 안됨.
        // 하나의 메모리 주소를 중간에서 연결해 줄 참조형이 필요. 
        // 왜? int[][]는 int[]형의 주소를 저장하니까. 
        // 힙에 만들어진 실제 {1}{2}의 주소는 int[]가 저장하고, 그 int[]의
        // 주소의 연속체를 받아야만 하니까. 

        int[] Test1 = { 1, 2 };
        int[] Test2 = { 1, 2 };
        int[] Test3 = { 1, 2 };
        int[] Test4 = { 1, 2 };

        int[][][] MyArray5 = new int[][][]
        {
            new int[][] {Test1,Test2},
            new int[][] {Test3,Test4},

            new int[][] {new int[]{1,2}, new int[]{3,4} }

        };

        // 증명. 
        // 재믹다. 

        // 크아아아악 재밌다!!!!!!!!!
        ////////////////////////////////////////////////////////////////
        
        int[] IntArray = { 1, 2, 3, 4 };

        goto Found;
        Found: Console.WriteLine("");
        
        //

        Console.ReadKey();

        
    }

}
