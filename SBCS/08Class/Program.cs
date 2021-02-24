using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;
// 컬렉션을 사용하기 위해!!

namespace _08Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Date test = new Date(); // 분명 배열로 선언하지 않았다. 근데
            for (int i = 0; i < 5; i++)
            {
                test[i] = i; // 이렇게 사용이 가능하다 --> 인덱서가 있구나. 
                Console.WriteLine(test[i]);
                // 인덱서가 자동으로 get, set 하여 number2의 값을 저장 복사해주는구나. !!!! 그렇군. 
            }


            CCC test2 = new CCC();  // test2[] 라고 하지 않았음에도
            for (int i = 0; i < 10; i++)
            {
                // test2[] 형식을 사용했다.
                // 아. 인덱서가 있구나!
                // 꽤나 편리하다. 
                test2[i] = i.ToString();
            }

            test2.Print();



            Console.ReadKey();
        }
    }

    /// ArrayList에서 indexer를 사용해보자. 
    /// 인덱서 : 클래스의 멤버 중에서 배열/ 컬렉션 등을
    /// Property 기능으로 사용할 수 있도록 하기 위한 것. 
    /// Property + Array = indexer!
    class CCC
    {
        private ArrayList MyList = new ArrayList(); 
        public string this[int index]   // 인덱서
        {
            get
            {
                if (index >= 0 && index < MyList.Count)
                    // ArrayList의 값은 object임으로 string으로 형변환. 
                    return (string)MyList[index];
                else
                    return null;
            }

            set
            {
                if (index >= 0 && index < MyList.Count)
                    MyList[index] = value;
                else if (index == MyList.Count)
                    MyList.Add(value);
            }
        }

        public void Print()
        {
            foreach (string m in MyList)
            {
                Console.WriteLine(m);
            }
        }


    }

    // internal이 생략. 
    class Date
    {
        private int number;
        private string name;

        private int[] number2 = new int[5];

        // c#에서는 m_식으로는 보통 사용하지 않고
        // 필드는 소문자로, Property는 맨앞을 대문자로 하는 식으로 구별한다. 
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // 인덱서를 써보자.
        public int this[int index]
        {
            get { return number2[index]; }
            set { number2[index] = value; }

        }

        

        // 소멸자. 그러나 가비지컬렉터에서 알아서 하기 때문에 쓸 필요는 없다. 
        ~Date()
        {

        }


    }
}
