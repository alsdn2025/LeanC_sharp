using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        ///////////////////////
        // foreach /////////////
        /////////////////////
        // 처음부터 끝까지 순차적으로 값을 반복하여 읽는 역할
        // --> 읽기전용.
        int[] Array1 = { 1, 2, 3, 4 };
        foreach(int nValue in Array1) // nValue는 읽기 전용
        {
            Console.WriteLine(nValue);
            // nValue = 10;  -> 이런 식으로 값 할당 못함!!! 읽기 전용
        }
        //////////////////////////


        ///////////////////
        // 점프문
        // goto, continue, return, break 등
        ///////////////////////////////
        // goto에 대해서 배워보자//////
        /////////////////////////////
        string Coffe_Size = "Medium";
        int Cost = 0;
        switch (Coffe_Size)
        {
            case "Small":
                Cost += 25;
                break;
            case "Medium":
                Cost += 25;
                goto case "Small";  // goto : 주로 switch문에서
                                    // 다른 case로 넘어갈 때 사용한다!
            default:
                break;
        }
        Console.WriteLine("Size : {0} Price : {1} cents", Coffe_Size, Cost);


        /////////////////
        // 예외 처리문 //
        ////////////////
        // ★★★★★ c#에서 매우 중요
        // 예외란? -> 런타임시에 발생할 수 있는 오류!
        // 예외 처리 방법
        // if ~ else
        // try ~ catch문 사용. 
        // try{ // 예외가 발생할 수 있는 코드 } 
        // catch(예외처리객체 e}
        // { // 코드로 예외처리 } 
        // 예외처리객체는 System.Exception 파생 객체만 사용 가능하다. 
        // System.Exception 파생 객체 : OverFlowException, FormatException..등
        // IndexOutOfRanghException -> 인덱스 최하가 0인데 -1등이 들어왔을때
        int[] IntArray = { 1, 2, 3 };
        int Test_try; // try/catch문 안에서 초기화
        try
        {   // 이 블록 안에서 에러가 발생할 수 있다. 
            IntArray[3] = 10;
            Test_try = 3;
        }
        catch(IndexOutOfRangeException e) // IndexOut..이란 에러가 발생할 수 있다. 
        {
            Console.WriteLine("배열 인덱스 에러 발생");
            Console.WriteLine(e.ToString()); // e.ToString 어디서 어떤 에러가 발생했는지 출력. 
            IntArray[2] = 10; // [3] 대신 [2]에 넣자. 
        }
        for (int i = 0; i < IntArray.Length; i++)
        {
            Console.Write("{0} ", IntArray[i]);
            //  Console.Write("{0} ", Test_try);
            // try/catch문 안에서 초기화한 변수는 try/catch문밖에서 사용할 수 없다. 
            // try/catch문 안에서 초기화하지 말라! 초기화만 아니면 됨. 
            // 이미 초기화된 변수에 값 대입 등은 가능. 
        }
        ///////////////////////////////////////
        /////////////////////////
        // try ~ finally////////////////
        //////////////////////////////
        // 예외 발생과 상관없이 항상 실행되는 구문!
        // 예외적인 상황이 발생했을 때 finally처리
        try
        {
            Console.WriteLine("try문에서 예외 발생");
            //IntArray[3] = 3;
        } // catch문이 없으므로 에러가 발생한다. 
        finally 
        { // 여기 있는 구문은 에러가 발생해도 실행된다. 
            // 물론 에러가 발생하지 않아도 실행. 
            Console.WriteLine("finally 구문입니다. ");
        }
        
        foreach(var M in IntArray)
        {
            Console.Write("{0}",M);

        }
        /////////////////////////////////////////////////////////
        // throw  ->  일부러 예외 상황을 발생시킨다.////////// 
        /////////////////////////////////////////////////////
        // System.Exception 파생 객체만 사용.
        // try문 이외에서도 사용 가능하다. 
        int result = GetNumber(3);

        /////////////////
        
        Console.ReadKey();

    }
    static int GetNumber(int _Index)
    {
        int[] nums = { 300, 600, 900 };
        if (_Index >= nums.Length)
        {
            throw new IndexOutOfRangeException(); // new를 사용한다.
            // 에러가 발생한다. 에러내용과 위치가 표시된다. 
            // 인위적으로 에러를 발생시키는 용법.
        }

        return nums[_Index];
    }
}

