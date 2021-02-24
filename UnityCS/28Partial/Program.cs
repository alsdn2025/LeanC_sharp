using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _28Partial;

namespace _28Partial
{
    class Program
    {
        static void Main(string[] args)
        {
            _28Partial.Player NewPlayer = new _28Partial.Player();
            // 귀찮아! using 쓰자!

            Player NewPlayer2 = new Player();
            // 일케 된다.
            // 즉 using은 위의 _28Particial을 생략하겠다는 뜻이다. 

            NewPlayer.Damage();

        }
    }
}
