using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    public int AT;
    int HP;

    public void Test(int _Value)
    {
        AT = _Value;

    }
}

namespace _11Memory00_Value_
{
    class Program
    {
        static void Main(string[] args)
        {
            int Value = 50;
            Player NewPlayer = new Player();
            NewPlayer.Test(Value);


            
            Console.WriteLine(NewPlayer.AT);


            Console.ReadKey();

        }
    }
}
