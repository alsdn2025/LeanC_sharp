using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Alpha
{
    using out_in_ref;
    class Alp
    {
        OutClass Out = new OutClass();

        OutClass.InnerClass Inner = new OutClass.InnerClass();
    }


    class OutClass
    {
        private static int SOME = 1;
        private int HACK = 2;

        public class InnerClass
        {
            OutClass Out = new OutClass();
            int A = SOME;

        }

        private int Acc = 0;
        public static void Access()
        {
            OutClass Out = new OutClass();
            Out.Acc = 100;
            //this.Acc = 100;
        }

    }

}

namespace out_in_ref
{
    class Beta
    {
        Vector A;
    }

    class Vector
    {
        public enum EE
        {
            A,
            B
        }
        public int x;
        public int y;

        private string secret;

        public void ExposeSecret(Vector _V)
        {
            Console.WriteLine(_V.secret);
        }
     
        public Vector(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }
        public Vector() { }
        
        public String Name;
        
        private void PrivateMethod()
        {
            Console.WriteLine("");
        }
        public void PublicMethod()
        {

        }
        static public void staticPublicMethod()
        {

        }
        internal void internalMethod()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vector.staticPublicMethod();
            Vector V1 = new Vector();
            V1.internalMethod();

            Vector V2 = new Vector();
            V1.ExposeSecret(V2);



            List<Vector> VList = new List<Vector>();
            VList.Add(new Vector(10,20));
            VList.Add(new Vector(30, 60));
            VList.Add(new Vector(40, 50));
            

            Vector V = new Vector(10, 20);
            ReadVector(V.x, V.y);
            InReadVector(V);
            

            Console.ReadKey();
        }

        static void ReadVector(int _x, int _y)
        {
            Console.WriteLine("x : {0} y : {1}", _x, _y);
        }
        static void ReadVector(Vector _V)
        {
            Console.WriteLine("x : {0} y : {1}", _V.x, _V.y);
        }
        static void InReadVector(in Vector _V)
        {
            Console.WriteLine("x : {0} y : {1}", _V.x, _V.y);
        }


        static void InTest(in int a)
        {
            Console.WriteLine(a);
        }




        static void OutTest(out int a, int value)
        {
            //Console.WriteLine(a);
            a = value;
        }

        
    }
}
