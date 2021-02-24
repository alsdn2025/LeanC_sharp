using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Son Imson = new Son();
        Console.WriteLine(Imson.Field);
        Imson.Print();
        Imson.Override_Print();




        /////////////////////////////////////////////////
        /////////////////////////////////////
        // 만약 하위 클래스 객체를 선언한다고 해도,
        // 참조 변수의 참조형이 상위 클래스라면
        // 같은 이름이어도 상위 클래스의 메서드를 호출한다. 
        Mom Immom = new Son();
        Console.WriteLine(Immom.Field);
        Immom.Print();

        ////////////////////////////////
        // 그러나, 만약 메서드가 override되어있다면
        // override된 메서드를 호출한다!
        Immom.Override_Print();


        // 이게 그냥 재정의하는 것과, override하는 것의 큰 차이점!


        Son test2 = new Son();
        Mom test3 = (Mom)test2; // 이런 식으로 업캐스트하여 참조형에 인스턴스를 넣어줄 수도 있다. 
        test3.Print(); // --> Mom 호출.




        Console.ReadKey();

    }
}

class Mom
{
    public int Field = 10;

    public void Print()
    {
        Console.WriteLine("mom");
    }
    
    virtual public void Override_Print()
    {
        Console.WriteLine("Override_Print - mom");
    }


}

class Son : Mom
{
    // override하지 않고 같은 멤버명으로 다시 쓰는 경우.
    public string Field = "100";

    public void Print()
    {
        Console.WriteLine("son");
    }

    // override 하는 경우
    public override void Override_Print()
    {
        base.Override_Print();
        Console.WriteLine("Override_Print - son");
    }


    // 언뜻 보면 Override하나 그냥 이름을 같이하여 재정의하나
    // 비슷해보이나
    // 차이점이 있다면
    // 1. 이 메서드는 부모로부터 상속받은 메서드의 재정의라는 것을 명시할 수 있다는 것(부모에게도 있으나 재정의했다 - override)
    // 2. 부모의 메서드와 어느 정도 유사한 틀을 가지게 된다는 것
    // (return 형, 매개 변수, 이름.
    // 정도가 되겠다. 
    // 굳이 필요한가? 갑자기 의문이 든다. 

    // 아마 1번 2번 이유때문에 쓰는 것 같긴 하다.
    // 이름이 같은데 갑자기 전혀 다른 메서드가 나오면 질서감이 흐트러지니까. 


    /* 추가로 배웠다!
     * 만약 부모 클래스의 참조형으로 자식 클래스 객체를 받았을 경우
        (예 : Mon test1 = new Son();)
     * 키워드 없이 함수를 호출할 경우, 함수의 이름이 같아도(자식이 override없이 재정의 했어도) 부모의 함수를 호출한다.
     * 그러나 override했을 경우.Override된 자식의 함수를 호출한다!
     * 즉, 상위 클래스에서 하위 클래스를 호출할 수 있다.
     * */
}
