using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _333Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ExceptionTest("C://WrongPath//");
            }
            catch(IOException e)
            {
                Debug.WriteLine("catch in Main");
                Debug.WriteLine(e.Message);
                Debug.WriteLine(e.StackTrace);
            }
            Console.ReadKey();
        }

        static public void ExceptionTest(String path)
        {
            try
            {
                FileStream fileStream = new FileStream(path, FileMode.Open);
                StreamWriter sw = new StreamWriter(fileStream);
                sw.Write(1);
            }catch(IOException e)
            {
                Debug.WriteLine("catch IOException");
                // 예외 호출자로 던져버리기~
                throw;
            }
        }

    }

    public sealed class UserNotFoundException : Exception
    {
        public UserNotFoundException(String message)
            :base(message)
        {

        }
    }
}
