using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // 데이터 분리 - split

        string str = "C언어 : 90 C#언어 : 100 컴퓨터구조 : 70 ";
        string[] str_Element = str.Split(new char[] { ' ' });
        // Split이라는 메소드를 사용해보자. 
        // {''} --> 구분자. return되는 타입을 배열으로 반환. 
        // str_Element가 그 배열의 주소값을 받는다. 
        // ' ' , 즉 빈 스페이스가 구분자 역할을 하며, 0부터 시작.
        // 즉 C언어 = 0, : = 1, 90 = 2, C#언어 = 3 ....

        int C언어 = int.Parse(str_Element[2]); // 문자열을 다시 Int로
        int C샵언어 = int.Parse(str_Element[5]);
        int 컴퓨터구조 = int.Parse(str_Element[8]);
        int Total = C언어 + C샵언어 + 컴퓨터구조;
        float average = Total / 3.0f;
        Console.WriteLine("{0} {1} {2} {3} {4}", C언어, C샵언어, 컴퓨터구조, Total, Math.Round(average));

        // 화면으로부터 학생수와 3과목에 대한 점수를 입력 받은 후, 
        // test.txt파일로 저장하는 프로그램을 만들어보자.
        // 단, 각 과목의 점수는 스페이스로 구분한다. 
        // ReadLine()을 활용하자. 
        
        FileStream st = new FileStream("test.txt", FileMode.Create);
        // StreamWriter를 이용해 test.txt에 내용을 저장한다. 
        StreamWriter sw = new StreamWriter(st);
        int nStudentNumber;
        float nAverage;

        Console.WriteLine("학생 수 : ");
        nStudentNumber = int.Parse(Console.ReadLine());
        sw.WriteLine("학생 수 : {0}", nStudentNumber);
        for (int i = 0; i < nStudentNumber; i++)
        {
            Console.WriteLine("{0}번 학생 -----------", i+1);
            Console.WriteLine("국어 : ");
            sw.Write("국어: " + Console.ReadLine() + " ");
            Console.WriteLine("영어 : ");
            sw.Write("영어: " + Console.ReadLine() + " ");
            Console.WriteLine("일본어 : ");
            sw.Write("일본어: " + Console.ReadLine() + " ");
            sw.WriteLine();

        }
        
        sw.Close();

        // FileStream 형 st는 선언될 때 FileMode.Create로 선언되었기 때문에 
        // st2 = new FileStream(st)로 해줄 경우 텍스트를 다시 만든다. 
        // 고로 다른 FileStream형을 다시 만들어줘야 한다. 
        FileStream st2 = new FileStream("test.txt", FileMode.Open, FileAccess.Read);
        StreamReader sr = new StreamReader(st2);
        
        //string[] str_element2 = (sr.ReadLine()).Split(new char[] {' '});
        ////////////////// (sr.ReadLine())의 문장을 char[] 형으로 각각 split해서 = 나눠서 새로운 char[] 객체를 만들어라! 
        ////////////////// ' ' 으로 나눌 곳을 구분해라! 
        ////////////////// 그리고 그걸 string[] 에 넣어라!

        sr.ReadLine(); // 학생 수가 들어간 첫줄 건너뛰기
        // 알 수 있는 점: ReadLine을 할 때마다 한 줄 씩 넘어간다. 
        for (int i = 0; i < nStudentNumber; i++)
        {
            string[] str_element3 = (sr.ReadLine()).Split(new char[] { ' ' });
            
            nAverage = (int.Parse(str_element3[1]) + int.Parse(str_element3[3]) + int.Parse(str_element3[5])) / 3.0F;

            Console.WriteLine("{0} 번 학생 - 국어 : {1}, 영어 : {2}, 일본어 : {3} 평균 : {4:f1} ",i+1, str_element3[1], str_element3[3], str_element3[5], nAverage);

            //nAverage = (int.Parse(str_element2[6 * i + 1]) + int.Parse(str_element2[6 * i + 3]) + int.Parse(str_element2[6 * i + 5])) / 3.0F;

            //Console.WriteLine("{0} 번 학생 - 국어 : {1}, 영어 : {2}, 일본어 : {3} 평균 : {4:f1} ",i+1, str_element2[6 * i + 1], str_element2[6 * i + 3], str_element2[6 * i + 5], nAverage);
        }

        sr.Close();


        




        Console.ReadKey();



    }
}
