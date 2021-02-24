using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Media;

class Program
{
    static void Main(string[] args)
    {
        // 임의의 위치로 문자열을 출력해주는 프로그램을 짜보자
        Console.SetWindowSize(100, 40);
        Random rand = new Random();
        // 랜덤 객체. 

        ConsoleColor[] Color =
        {
            ConsoleColor.Blue , ConsoleColor.Cyan,
            ConsoleColor.Red , ConsoleColor.Yellow,
            ConsoleColor.Magenta, ConsoleColor.Green
        };
        // 열거형 배열 Color 는 [0] = blue, [1] = cyan... 을 가진다.


        while (true)
        {
            Console.Clear();
            for (int i = 0; i < 30; i++)
            {
                Console.ForegroundColor = Color[rand.Next(6)];
                //Console.BackgroundColor = Color[rand.Next(6)];
                Console.SetCursorPosition(rand.Next(100), rand.Next(40));
                // 커서 위치를 현재로부터 (rand.Next(100)) 열만큼, rand.Next(40)행만큼 옮긴다. 
                Console.Write("야호");
            }
            Thread.Sleep(100); // 0.1초 대기한다.
        }
        // 이건 좀 재밌네. . .!!!!

        // 사운드출력
        // using System.Media








        Console.ReadKey();


    }
}
