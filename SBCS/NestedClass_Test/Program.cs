using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// C#에선 이너클래스가 다른 이너클래스에 full-access할 수 없다.
// 물론 enclosing 클래스도 이너클래스에 full-access할 수 없다. 
// 이너클래스에서 enclosing 클래스로의 full-accss는 허용된다. 

// Java와는 다르게 C#에서는 static Class가 허용된다. 
// Java에서는 Nested static class만 허용된다. 


namespace NestedClass_Test
{
    


    class EnclosingClass
    {
        private String privateField = "Im EnclosingClass";


        class Inner1
        {
            private String privateField = "Im Inner1";
           
        }

        class Inner2
        {
            private String privateField = "Im Inner2";
            public void ExchangeField(Inner1 inner1)
            {

            }
        }

        public void Method()
        {
            Inner1 inner1 = new Inner1();
            // inner1.privateField = "배고프다";

        }



        static void Main(string[] args)
        { 
        }
    }
}
