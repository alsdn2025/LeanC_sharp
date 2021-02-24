using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Inheritance
{
    class A
    {
        int data;
        protected A(int _Data)
        {
            data = _Data;
        }

        public int ProData
        {
            get { return data; }
            set { data = value; }
        }
    }
   
    class B : A
    {
        string Option;
        public B(int _Data, string _Option):base(_Data) // 생성자
            // 오버로딩시 사용하는  : base()
        {
            Option = _Option;
        }

        public string ProOp
        {
            get { return Option; }
            set { Option = value; }
        }

    }


    /// <summary>
    /// ///////////////////
    /// sealed에 대해 알아보자
    /// 

    sealed class SealedClass
    {

    }

    // sealed 가 붙은 class는 아예 상속을 할 수 없다. 
   // class TestClass1 : SealedClass

    class SealedClass2
    {

        // sealed public SealedClass2()
        /////////////// 생성자에 sealed를 붙일 수 없다.

        public int aaa = 10;
        
        /*sealed*/ virtual public void Print()
        {
            // 오버라이딩 되지 않은 메서드에 sealed는 불가능하다. 
            // 즉 최상위 개체의 메서드에 sealed는 불가능하다. 
        }

        public void WWW()
        {

        }

    }
    
    class TestClass2 : SealedClass2
    {
        /*new*/ int aaa = 20;   // 상위 클래스의 aaa를 숨겨버림.
                                // override와 다른 개념?

        public TestClass2()
        {
            aaa = 10;
        }

        // 부모의 Print를 override할 때, sealed를 붙일 수 있다. 
        sealed public override void Print() 
        {
            
        }

        void WWW()  // 그냥 숨기는 것과 override하는 것이 무슨 차이지?
        {

        }

    }

    class TestClass3 : SealedClass2
    {
        // 동등한 관계(같은 부모로부터 상속받은 다른 개체의 관계)
        // 라면 그 class의 override를 막진 못한다. 
        public override void Print()
        {
            Console.WriteLine("");
        }
    }

    class TestClass_lower : TestClass2
    {
        // 이렇게 sealed를 쓴 class의 자식 클래스부터, 
        // sealed가 써진 메소드의 오버라이드가 불가능해진다. 
     //   public override void Print() // 불가능
    //    {

   //     }
    }

    class Parent
    {
        int A;
        public Parent()
        {
            Console.WriteLine("Parent is running");
        }
        public virtual void Method()
        {
            Console.WriteLine("Hi. I'm a parent of my dear son");
        }
        public void ImParent()
        {

        }

    }
    class Child:Parent
    {
        int B;
        public Child()
        {
            Console.WriteLine("Child is running");
        }
        public override void Method()
        {
            Console.WriteLine("Hi루~~");
        }
        public void ImChild()
        {

        }
    }

    class Test
    {
        myEnum myenum;
    }

    enum myEnum
    {
        A,
        B,
        C
    }

    class Person
    {
        
    }
    class Student:Person
    {
        public Student()
        {
            Console.WriteLine("Im a Student");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B test1 = new B(10, "야호");

            Console.WriteLine(test1.ProOp + test1.ProData);

            Test test2 = new Test();


            //Parent parent = new Parent();
            //parent.Method();

            // 부모형의 레퍼런스지만, 아들의 개체를 받았을 경우
            // override된 메서드를 호출한다. 
            //Parent Test = new Child();
            //Test.Method();

            Parent parent = new Child();
            if(parent is Child c)
            {
                Child child = c;
            }

            Console.WriteLine(parent.GetType());
            Console.WriteLine(parent.GetType().FullName);

            Student student = new Student();
            if(student is Person p)
            {
                Person person = p;
            }

            Console.WriteLine("5 % (-3) = "+5 % (-3));



            Console.ReadKey();
            Console.ReadKey();

        }
        

    }

    // 정리
    // class에 sealed를 붙일 수 있다. 
    // 메서드에 sealed를 붙일 수 있으나, 최상위 부모는 x. 
    // 한 번 이상 override한 메서드에만 붙일 수 있으며
    // sealed를 쓴 class의 자식 class만 override 불가. 
    // sealed를 쓴 class와 동등한 관계(같은 부모)일경우 override 가능.

    // 필드에 대해선 추가적인 공부 필요, 특히 virtual 필드
    // virtual은 메서드만 가능한 듯. 

    // 애초에 오버라이드 = 메서드를 대상으로 하는 것. 
    // 상위 클래스의 필드와 같은 이름의 필드를 하위 클래스에서 재정의할 경우, 그냥 상위클래스 필드를 감춰버림. 

    //++ override와 그냥 감추는 것의 차이
    // 만약 부모 클래스의 참조형으로 자식 객체를 받았을 경우
    // Parent test = new Child();
    // 그냥 감춰서 함수를 재정의했을 경우, test.Method()하면 
    // 언제나 부모의 함수를 호출하게 된다. 
    // 그러나 override 했을 경우, test,Method()시 
    // 자식의 함수를 호출한다!

}
