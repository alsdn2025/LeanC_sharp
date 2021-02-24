using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    public int AT = 0;
}

namespace _38Reference01
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player(); // 객체 A
            NewPlayer.AT = 50;

            NewPlayer = new Player(); // 객체 B
            // NewPlayer는 A를 가르키다가, B를 가르키게 되었다. 
            // 객체 A는 못 찾는다. c#에서는 자동으로 delete된다. 
            // 

        }
    }
}
