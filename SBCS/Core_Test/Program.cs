using System;
using System.Collections.Generic;

namespace Core_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> IntegerHashSet = new HashSet<int>();

            ImplementClass classReference = new ImplementClass();
            inter interReference = new ImplementClass();

            interReference.defaultMethod();
            //classReference.defaultMethod(); // error!!

            Childinter childinter = (Childinter)interReference;
            childinter.defaultMethod();

        } 
    }

    class ImplementClass : Childinter
    { 
       /* void inter.defaultMethod() // default 메서드를 Override!
        {
            Console.WriteLine("Override default Method");
        }*/


    }

    interface Childinter : inter
    {
        void inter.defaultMethod()
        {
            Console.WriteLine("Override in child interface!");
        }
    }

    interface inter
    {
        public void defaultMethod()
        {
            Console.WriteLine("interface Default method in C#");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("interface static Method in C#");
        }

    }

    interface inter2
    {
        void defaultMethod()
        {
            Console.WriteLine("interface Default method in C#");
        }

    }

}
