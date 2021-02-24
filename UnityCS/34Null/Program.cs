using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    private int mAT;

    public int ProAT
    {
        get { return mAT; }
        set { mAT = value; }
    }

}


namespace _34Null
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer1 = new Player();
            
            // 가르키는것 없이 비워놓겠다. 즉 주소값을 null로 두겠다. 
            // 
            Player NewPlayer2 = null;


            // ↙System.NullReferenceException: 
            // Console.WriteLine(NewPlayer2.ProAT);라고 뜸. 


            // int Test = null; <-오류. 
            // null은 주소값.
            int[] a = new int[10];
            a = null;
            // a[0] = null;

            // a는 주소값. 객체를 가르키는 포인터.  null을 넣을 수 있다. 
            // a[0]은 실제 존재하는 객체. null을 넣을 수 없다.


            Console.ReadKey();
        }
    }
}
