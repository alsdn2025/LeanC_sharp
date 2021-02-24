using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




delegate void MyDelegate(string str1);
// 내가 호출하려는 함수의return형은 void형이고, 매개변수는 string이다. 
// 매개 변수명(str1)은 딱히 상관 x. delegate의 이름도 마음대로. 


delegate void Multi_Deligate();

class A
{
    public void Print(string str)
    {
        Console.WriteLine(str);
    }
    
    // 멀티캐스트용 메소드 A와  B
    public void PrintA()
    {
        Console.WriteLine("PrintA");
    }

    public void PrintB()
    {
        Console.WriteLine("PrintB");
    }

}


class Program
{
    static void Main(string[] args)
    {
        ///////////////////////////////////
        // deligate ///////////////////////
        //////////////////////////////////
        A test = new A();
        MyDelegate DelMethod1 = new MyDelegate(test.Print);
        DelMethod1("Its Method1 !");
        // 첫 번째 방법

        MyDelegate DelMethod2 = test.Print;
        // 두 번째 방법
        DelMethod2("Its Method2 !");
        // 두 가지 방법 모두 알고 있어야 한다.  


        DelMethod2 = DelMethod1;
        // 일케도 가능하다. 



        /////////////////////////////////
        // multicate deligate /////////////
        ///////////////////////////////////

        MulticastDelegate What = DelMethod1;
        // MulticastDelegate <- 이건 언제쓰는거? 
        // Delegate 클래스에서 상속받은 자식클래스인데..
        // 어따 쓰는 친군지..
        // 검색해보니 +=, -=를 사용하여 델리게이트에 메서드를 추가 제거할 때
        // 내부적으로 .NET MulticastDelegate클래스에서 이 메서드들의 리스트를 관리한다고 한다. 
        // 내가 직접 여기서 사용하진 않겠구나. 
        // 사실 실제 만드는 delegate의 내부 타입은 모두 MulticastDelegate인 것.  




        Multi_Deligate Multi_Del = test.PrintA;

        Multi_Del += test.PrintB;
        
        //////////////////////////////////////////////////////////////
        Multi_Del += delegate () { Console.WriteLine("아아 테스트"); };
        // 익명 메소드. 델리게이트를 이용해서, 메소드명이 없는 메소드를 만들어 호출할 수도 있다. 
        /////////////////////////////////////////////////////////////



        Multi_Del();
        
        

        Console.ReadKey();

    }
}

