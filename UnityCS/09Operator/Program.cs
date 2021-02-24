using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    int HP; 

    void Damage(int _HP)
    {
        HP -= HP;
    }
}


namespace _09Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int Result = 0;
            int Left = 3;
            int Right = 6;

            // 산술연산자에는 * / % 가 먼저 되고 + - 가 된다. 
            // ()연산자는 연산자의 실행순서를 내가 지정할 수 있게 해준다. 
            Result = Left + Right;
            // 대입연산자가 있을 경우 오른쪽을 먼저 읽고 왼쪽에 넣는다. 
            Result = Left - Right;
            Result = Left * Right;
            Result = Left / Right;
            Result = Left % Right;

            // 10 나누기 0은 컴퓨터에서는 제로디비전-> 오류가 뜬다. 
            // 프로그램이 실행도중 터질정도의 오류이므로 주의. 

            // 비교연산자가 있다. 
            // 비교연산자는 논리형으로 리턴이 되는데, 논리형은 bool이라는 녀석으
            // bool은 true or false만 리턴가능하다. 
            bool BResult = true;

            // 참과 거짓이 상수화 -> true, false.. 


            BResult = true && false; // and
            BResult = true || false; // or 둘중에 하나만 true면 true
            BResult = true ^ false;  // xor 둘다 true, 둘다 false면 false. 두 개가 다르다면 true. 
            BResult = !true; // true면 false 
            BResult = !false; // false면 true

            BResult = !(1 > 2);

            Console.WriteLine(BResult);
            // ()안이 FALSE임으로 BResult 는 true. 

            BResult = false^false;
            Console.WriteLine(BResult);
            // 둘 다 false임으로 false

            BResult = true ^ true;
            Console.WriteLine(BResult);
            // 둘 다 true임으로 false

            BResult = true ^ false;
            Console.WriteLine(BResult);
            // 둘이 다르므로 true. 





            Console.WriteLine("뭔가 마음이 안정되네 \n");

            Console.WriteLine("음..");
            Console.ReadKey();


        }
    }
}
