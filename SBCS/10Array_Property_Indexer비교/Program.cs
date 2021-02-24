using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace _10Array_Property_Indexer비교
{
    class Program
    {
        static void Main(string[] args)
        {

            ////////////고정 배열 
            int[] array = new int[5];
            array[0] = 1;
            // 이미 초기화한 array에 
            // array = {1,2,3,4,5} 이렇게는 안되네.
            // 그럼 {1,2,3,4,5} 가 int[] 형식은 아니라는 거네.
            // {}는 배열으로 취급되는건 아니구나. 

            int[] Array = new int[] { 1, 2, 3, 4 };
            int[,] Array_2D = new int[1, 3] { { 1, 2, 3 } };
            int[,,] Array_3D = new int[2, 3, 2]
                {
                    {{ 1,2 },{ 3,4 },{ 5,6 }},
                    {{ 7,8 },{ 9,10 },{ 11,12 }}
                };
            

            //////////// 가변 배열
            int[][] Array_Variable = new int[][]
            {
                new int []{1,2,3,4},
                new int []{2,3,4},
                new int []{5,6,7,8,9}
            };
            // ■■■■
            // ■■■   
            // ■■■■■    사용자 임의의 모양으로 배열을 만들 수 있음.
            
            Array_3D[1, 2, 1] = 10;
            Array_Variable[1][0] = 10;
            // 고정 배열과 가변 배열은 사용할 때 형식의 차이가 있음에 주의
            // [,,] / [][]

            A test = new A();

            // private인 number에 접근하기 위해 property를 사용한다.
            test.Number = 10;
            Console.WriteLine(test.Number);

            // test가 []로 선언되지 않았음에도
            // test[3]을 사용한다. --> indexer로 test의 클래스인 A안의 
            // 필드인 arrayL이라는 컬렉션을 사용할 수 있도록 인덱서가 
            // 기능하고 있군!
            test[3] = "12345";
            

            // 3이 출력된다.
            // 아래 인덱서-set에서 _index, 즉 3이 arrayL의 Count 보다 작았으므로, 그냥 arrayL.Add(3)이 되어버렸기 때문에.
            Console.WriteLine(test[0]);


            Console.WriteLine(test[3]);


            Console.ReadKey();
           
        }

        class A
        {
            int number;
            ArrayList arrayL = new ArrayList();
            
            // 속성 property
            public int Number 
            {
                get { return number; }
                set { number = value; }
            }


            // 인덱서 indexer
            public string this[int _index]
            {
                // ArrayList의 값은 object임으로 형변환해준다. 
                get { return (arrayL[_index]).ToString(); }

                set
                {
                    if (_index >= 0 && _index < arrayL.Count)
                    {
                        arrayL[_index] = value;
                    }
                    else
                        arrayL.Add(_index);
                }
            }


        }

        class B
        {

        }



    }
}
