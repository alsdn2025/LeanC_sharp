using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13Interface
{
    // Alphabet이란 인터페이스. 
    interface IAlphabet
    {
        void Print();
    }

    // A에 상속시킨다. A는 무조건 인터페이스에 명시된 Print()를 구현해야 한다.
    class A : IAlphabet
    {
        public void Print()
        {
            Console.WriteLine("알파벳입니다.");
        }
    }

    class B: A, IAlphabet
    {
         // A와 알파벳을 상속한 B. 
         // 부모 클래스인 A에서 이미 인터페이스를 구현해 놓았으므로
         // B에서 다시 구현할 필요는 없다.         
    }

    interface IUpperAlphabat
    {

    }

    class C:B , IUpperAlphabat, IAlphabet
    {
        // 인터페이스는 여러 개 상속받을 수 있다. 
        // C의 부모클래스의 부모클래스인 A에서 이미 인터페이스를 구현해놨기에
        // C에서 다시 구현할 필요는 없다. 
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            // 인터페이스로 레퍼런스의 타입을 정해놓을 수 있다. 
            // 이렇게 하면 레퍼런스는 인터페이스를 상속받은 객체라면 모두 객체로 가질 수 있다. 
            IAlphabet Alphabet = new A();
            var Alphabet2 = new C();

            


            Console.ReadKey();
        }
    }
}
