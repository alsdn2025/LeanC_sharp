using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 연습장
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Name = "123";

            Console.ReadKey();
            Console.ReadKey();

        }
    }

    abstract class Animal
    {
        protected internal int Hp;
        protected int Ap;
        protected int Dp;
        
        protected abstract void Attack(Animal a);

        protected void Hello()
        {
            Console.WriteLine("Hello");
        }

    }

    sealed class Dog : Animal
    {
        protected internal String Name;



        protected override void Attack(Animal a)
        {
            a.Hp = 10;
        }

    }

    interface Myinterface
    {
        void Func();
    }
}
