using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate void DeleManjuu(string Message);

class A // 이벤트를 발생시키는 클래스 = 게시자
{
    // DeleManjuu 라는 delegate에 대한 event라고 명시. 
    public event DeleManjuu EventHandler;


    public void PrintMessage(string Message)
    {
        // 이벤트는 해당 이벤트가 선언되어있는 클래스 또는 구조체 안에서만 호출될 수 있다. 
        EventHandler(Message); // 이벤트 호출

    }
}

// 정리 
// class A안의 event DeleManjuu EventHandler -> 이벤트핸들러가 있다고 정의.
// PrintMessage --> 이벤트를 호출하는 기능만을 가진 메서드. 
// 메인에서 A객체의 이벤트핸들러(얘도 필드임)에 B 객체의 메서드 두 개를 연결. 
// 메인에서 A.PrintMessage  -->  EventHandler 호출  --> 이벤트핸들러 필드에 연결된 B 객체의 메서드 두 개를 호출  -->  WriteLine이 두 번 실행됨. 
// 이런 식으로 메서드를 통해 호출되어야만 이벤트는 제 역할을 할 수 있음.

// 이벤트 핸들러를 포함하는 객체(testA) 안의 메서드를 통해!
// 다른 객체 또는 같은 객체의 메서드를 
// 같은 매개 변수를 전달하면서 호출하기 위한 방법이다. 



class B // 이벤트를 받거나 처리하는 클래스 = 구독자
{
    public void PrintA(string Message)
    {
        Console.WriteLine(Message);
    }

    public void PrintB(string Message)
    {
        Console.WriteLine(Message);
    }

}

class Program
{
    static void Main(string[] args)
    {
        // A , B 객체를 만들어준다. 
        A testA = new A();
        B testB = new B();

        // 이벤트에 메서드를 추가 / 삭제 
        // testA.EventHandler += new DeleManjuu(testA.PrintMessage);
        // 객체.이벤트핸들러 += new 델리게이트명(객체.메서드명);
        // 객체.이벤트핸들러 += 객체.메서드; 도 가능.
        // testA.EventHandler += testA.PrintMessage;
        // 일케. 



        // A의 핸들러에 B의 Print메소드 두 개를 넣는다. 
        testA.EventHandler += new DeleManjuu(testB.PrintA);
        testA.EventHandler += new DeleManjuu(testB.PrintB);
        testA.PrintMessage("good!!");
        // --> good이 두 개 출력된다. printA와 printB 둘 다 작동되서. 

        testA.EventHandler -= testB.PrintB; // PrintB 메소드를 뺀다. 
        testA.PrintMessage("hiRu~~"); // huRu는 하나만 출력된다. 
        testA.EventHandler -= testB.PrintA;
        testA.PrintMessage("dd");

        testA.EventHandler += testB.PrintA;
        testA.EventHandler += testB.PrintB;
        testA.PrintMessage("welcome back");




        // delegate는 그냥
        // MyDel(); 이렇게 델리게이트 객체로 바로 연결된 메서드를 사용가능하지만

        // event는
        // A.PrintMessage("") -> 같은 객체의 메서드에 의해 호출되어야만
        // MyEventHandler( _string)  --> B의 메소드 실행
        // 그 안에 연결된 다른 객체나 같은 객체의 메서드를 사용할 수 있다. 
        // 같은 객체의 메서드에서 이벤트핸들러 호출 -> 이벤트핸들러에 연결된 다른 메서드 호출. 





        Console.ReadKey();
        

    }

}
