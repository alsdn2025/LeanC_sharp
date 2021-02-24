using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 언어는 숨쉬는 것. 
// 프로그래밍에 있어서 
// 기본기라고 생각되는 게 3가지 있다. 
// 디버깅(중단점)
// 문자열 
// 파일입출력. 



namespace _25String01
{


    class Program
    {


        static void Main(string[] args)
        {
            // 동적 기본자료형. 크기가 유동적이다. 
            // 
            char Charactor = 'a';
            string TEST = "";
            // 자료형은 c#에서 만들어 놓은 기본 클래스이다. 

            TEST = 10.ToString();
            // 예이~~~~~~~
            // 으악ㅇㄹㅇㄴㅇㄹㄸㅁㄹㄸㅈㄷㄹ

            Console.WriteLine(TEST);
            Console.ReadKey();




        }
    }
}
