using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // Console.ReadKey()
        // 사용자가 누른 키 하나를 리턴하는 메소드
        // public static, 정적메소드
        // 두 가지 형태로 오버로딩 되어있는데, 
        // ReadKey(), ReadKey(bool intercept)
        // (bool intercept)에 true -> 내가 입력한 값을 화면에 출력하지 않는다. 
        // false --> 출력한다. 

        // ConsoleKeyInfo.Key 
        // 입력한 값의 정보를 받음. 열거형(enum)


        ConsoleKeyInfo KeyInfo;
        do
        {
            KeyInfo = Console.ReadKey(true);
            if (KeyInfo.Key == ConsoleKey.A)
            {
                Console.WriteLine("a(A)가 눌렸다.");
                // 대문자를 입력하든 소문자를 입력하든 출력,
                // key는 대소문자를 구분 x.
                // 왜? 키보드에 대/소문자 구분안대잇으니까!
                // 구분하고 싶다면 
                if(KeyInfo.KeyChar == 'a') //.KeyChar를 이용하면 된다. 입력값을 유니코드문자로 가져오는 함수
                 
                {
                    Console.WriteLine("소문자 a야!");
                }
            }
            
        } while (KeyInfo.Key != ConsoleKey.Escape);

        // Console.ReadLine()
        // 한 줄씩 입력받을 수 있다. 
        // 한 줄을 다 썼다면 enter를 누름으로써 입력한다. 

        int Kor, Math, Eng, Total;
        float Average;

        Console.Write("국어 점수 입력 : ");
        Kor = Convert.ToInt32(Console.ReadLine());
        Console.Write("수학 점수 입력 : ");
        Math = Convert.ToInt32(Console.ReadLine());
        Console.Write("영어 점수 입력 : ");
        Eng = Convert.ToInt32(Console.ReadLine());

        Total = Kor + Math + Eng;
        Average = Total / 3.0f;
        Console.Write("토탈 점수 : {0}\n 평균 : {1}" , Total, Average);




        Console.ReadKey();

        // 잼당
    }
}
