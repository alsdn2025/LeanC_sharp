using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace 추가공부_ArrayList_제네릭
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList A = new ArrayList();

            A.Add(3);
            A.Add("놈친미");
            A.Add(new MyClass());

            // 자료형에 상관없이 넣을 수 있다. 
            // 심지어 class, struct도. 
            // object로 업캐스팅되어 저장된다.

            int MyInt = 0;
            MyInt = (int)A[0]; // 저장된 자료형은 object형이기 때문에
                               // 이용하려면 형변환을 해주어야 한다. 

            Console.WriteLine(A.Count);
            // 연재 들어있는 원소의 개수를 볼 수 있다. 
            // List의 length와 비슷해보이나, length는 한 번 정해지면 바뀌지 않는 반면 Count는 유동적이다. 

            int[] intint = new int[] { 1, 2, 3 };
            // 보통의 list는 일케 한 번 정하면 메모리 크기를 더 늘릴 수 없다. 
            // IntList[3] 는 없다는 뜻. 하려면 새로 new로 할당해줘야 한다. 
            // 고로 IntList.length도 항상 3으로 같다. 
            Console.WriteLine(intint.Length);




            // 여러 편리한 메소드들을 제공한다. 
            // Add, Insert, Remove 등등.. 
            // ArrayList를 사용하는 이유 중 하나. 매우 편리하다. 
            A.Insert(1,100);
            // [0][1][2] 중 [1]에 100을 넣고, 한 칸씩 뒤로 민다.

            A.Remove("놈친미"); // 지정한 데이터값을 가지고 있는 데이터를 삭제하고, 뒤의 데이터를 한 칸씩 당긴다.
            A.RemoveAt(0); // 지정한 순서의 데이터를 삭제하고, 뒤의 데이터를 한 칸씩 당긴다. 



            ////정리 ArrayList라는 컬렉션은
            // 편하게 데이터타입에 상관하지 않고 데이터의 배열을 만들 수 있다. 
            // 여러가지 편리한 메소드들을 제공해서 효율적이다. 
            // 내부적으론 배열을 이용하지만, linked list의 동작 방식과 유사하다. 
            // 각각의 요소가 다음 연결 요소에 대한 정보를 가지고 있다. 

            /////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////
            // ArrayList와 유사하나, 
            // 형변환 없이 Type을 아예 고정해서 사용하는 컬렉션이 있다.
            // 바로 List<T>. 
            // 제네릭 컬렉션, 일반화 컬렉션 이라고 부른다. 

            // int 만 담을 수 있는 컬렉션 List<int>
            List<int> IntList = new List<int>();
            // Myclass만 담을 수 있는 MyClassList 등등.
            List<MyClass> MyClassList = new List<MyClass>();

            IntList.Add(10); // 당연히 int형만 넣어줘야 한다.
            IntList.Add(20); 
            IntList.Add(30); 
            Console.WriteLine(IntList.GetType());
            // int형으로 저장하고 int형으로 반환한다.
            

            MyClassList.Add(new MyClass());
            MyClassList[0].Member = 10;
            // 편리하군. 

            int sum = 0;
            // foreach는 list와 컬렉션을 나타낼 때 쓰면 매우 편리하다.
            // 따로 index를 지정해줄 필요 없이 알아서 처음부터 하나씩 다음 데이터로 넘어가고, 마지막 데이터를 처리하면 끝난다. 
            // foreach (var item in collection)  <-- 컬렉션용으로 만들어짐.
            foreach (int item in IntList)
            {
                sum += item;
            }







            Console.ReadKey();

        }


    }
    
    class MyClass
    {
        public int Member;

    }
}
