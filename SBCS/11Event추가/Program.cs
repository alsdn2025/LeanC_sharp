using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Event추가
{
    

    class Program
    {
        public event EventHandler Event1;  // 얘가 이벤트핸들러

        static void Main(string[] args)
        {
            // Program 클래스 객체를 생성한다. 
            Program program = new Program();

            // 객체의 이벤트핸들러에 Program_Event1 메서드를 연결한다.
            program.Event1 = Program_Event1;

            // 객체의 EventStart라는 메서드가 이벤트핸들러를 호출한다.
            // = EventStart라는 이벤트를 발생시켜서, 내부적으로 EventStart라는 이벤트에 가입된 이벤트핸들러 Event1을 동작시킴. 
            // 이벤트핸들러는 자신에게 연결된 Program_Event1 메서드를 호출한다.
            program.EventStart();

            // 핸들러 = 넘겨주는 사람. 

            Console.ReadKey();

        }


        private static void Program_Event1(object sender, EventArgs e)
        {

            Console.WriteLine("이벤트가 발생하였습니다.");
        }

        private void EventStart()  // EventStar라는 이벤트
        {
            Console.WriteLine("이벤트를 발생시킵니다.");
            Event1(this, EventArgs.Empty);  // 이벤트는 이벤트핸들러를 호출한다. 
        }
        
        //  EventStart가 실행(이벤트가 발생) -
        //  EventStart가 발생하자 내부적으로 이를 감지하여
        //  EventStart에 가입된 이벤트인 Event1을 동작시킴 ->
        //  Event1이라는 이벤트핸들러는 자신에게 연결된 메서드를 호출함.
        



    }
}
