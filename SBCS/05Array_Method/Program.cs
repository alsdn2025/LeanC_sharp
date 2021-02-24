using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // 배열은 Array클래스로부터 파생된 객체.
        ////////////////////////////
        // 배열 초기화 메소드///////////
        ////////////////////////////

        // public static void Clear(Array, int index, int length)
        // Array를 index부터 lenth만큼 0으로 초기화하겠다.
        // 이 때, 아래의 nArray1은 int[]형인데 Array형에 넣을 수 있는 이유:
        // int[]형은 결국 Array로부터 파생된 객체이기 때문에. 
        // 일종의 업캐스팅. 

        int[] nArray1 = { 1, 2, 3, 4 ,5 };
        Array.Clear(nArray1, 2, 3); // 2부터 3개를 초기화하겠다. 
                                    // = (3번째)부터 3개를 초기화하겠다. 
        foreach (int m in nArray1)
            Console.Write(m);
        Console.WriteLine();
        
       
        Array.Clear(nArray1, 0, nArray1.Length);
        foreach (int m in nArray1)
            Console.Write(m);
        Console.WriteLine();

        /////////////////////////////////
        // 배열 복사 메소드 ////////
        /////////////////////////////////////

        int[] nArray2 = { 1, 2, 3, 4 };
        int[] nClone = (int[])nArray2.Clone();
        // (int[]) --> 캐스트연산자. why? --> 언박싱 하기 위해!
        // Clone의 return type은 object. object를 int[]로 형변환. 

        nClone[2] = 0;
        foreach (int m in nArray2)
            Console.Write(m);
        Console.WriteLine();
        foreach (int m in nClone)
            Console.Write(m);
        Console.WriteLine();

        string[] Days = { "일", "월", "화" };
        string[] DayClone = (string[])Days.Clone();
        // 마찬가지로 object형을 string[]형으로 형변환!
        foreach (string s in DayClone)
            Console.Write(s);
        Console.WriteLine();
        ///////////////////////////////////////////////////////////////

        // clear(), clone은 둘 다 많이 사용되니 꼭 알아두자. 
        // 배열 끝! 




        Console.ReadKey();

    }
}

