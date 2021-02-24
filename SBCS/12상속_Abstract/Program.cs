using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        C test1 = new C();
        test1.A_Func();
        test1.B_Func();


        Console.ReadKey();

    }

    abstract class A
    {
        // public void Func(); // 안됨. 추상 클래스는 abstract 메서드만 가질 수 있다. 
        int mAT = 10;  // 필드는 가능.
        abstract public void A_Func();
        
    }
    
    abstract class B : A  // 추상 클래스가 추상 클래스를 상속하는 것도 가능하다. 
        // 추상 클래스가 추상 클래스를 상속할 경우, 상위 클래스의 abstract 메서드를 채워넣지 않아도 된다. 어차피 못하니까.
    {
        abstract public void B_Func();
    }

    class C:B
    {
        override public void A_Func()   // abstract메서드를 정의해주기 위해 override 키워드를 또 사용한다. 
        {
            Console.WriteLine("abstract class A에서 선언만 된 함수");
        }
        override public void B_Func()   // abstract메서드를 정의해주기 위해 override 키워드를 또 사용한다. 
        {
            Console.WriteLine("abstract class B에서 선언만 된 함수");
        }

        // 만약 상위 클래스들에서 선언된 abstract method를 구현하지 않을 경우, 오류가 난다. 
    }

    class D:C
    {
        public override void A_Func()
        {
            base.A_Func();
            // C에서 구현한 A_Func()을 오버라이딩할 수 있다. 
            // 마치 virtual처럼
            Console.WriteLine("D에서 다시 오버라이딩");
        }
    }



    /* 정리 : 추상 클래스는 메서드의 형식을 정해놓고
     * 그 형식에 맞게 메서드를 구성해야 하는 경우 사용되며
     * 추상 클래스도 추상 클래스를 상속할 수 있으며
     * 만약 상위 추상 클래스들에서 선언된 메서드를 (추상클래스가아닌)
     * 하위 클래스가 구현하지 않을 경우 오류가 발생한다. 
     * 
     */

}
