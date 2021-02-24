using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerClass
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }


    class MyClass
    {
        int A = 10;
        int B = 10;

       // int C = A + B;


    }



    class OutClass
    {
        protected static int STATIC = 1;
        protected int non_STATIC = 0;

        static void StaticMethod()
        {
            int A = STATIC;
        }
        void nonStaticMethod() { }
        public class InnerClass
        {
            int C = STATIC;

            public void Method()
            {
                OutClass outclass = new OutClass();
                outclass.nonStaticMethod();
                
            }
        }
    }

    class Out_SonClass : OutClass
    {
        int Test = STATIC;

        public void MyMethod()
        {
            OutClass outclass = new OutClass();
      //      outclass.non_STATIC = 100;
            this.non_STATIC = 100;
            
        }
        

    }
    class Inner_SonClass : OutClass.InnerClass
    {
     //   int Test2 = STATIC;
 //       int Test3 = OutClass.STATIC;
    }



    class Parent
    {
        private int privateInt = 0;
        protected int protectedInt = 10;
        public int publicint = 100;

        protected static int PROTECTED_STATIC = 1000;

        public void Method()
        {
            Parent parent = new Parent();
            parent.privateInt = 100;
            parent.protectedInt = 100;
            parent.publicint = 100; 
        }

    }

    class Child:Parent
    {
        public void Method()
        {
            Parent parent = new Parent();
        //    parent.protectedInt = 100;
            parent.publicint = 200;

            // 자식 클래스 안에서 부모 클래스 개체의 protected에 접근할 수 없다. 
            // protected : 자식 클래스 개체를 통해서만 접근 가능. 
         //   this.privateInt = 0;
            this.protectedInt = 100;
            this.publicint = 200;
            
            int A = Parent.PROTECTED_STATIC;

        }
    }


}
