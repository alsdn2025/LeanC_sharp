using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms; // 여기 안에 Application 있듬

namespace _14WindowProgamming
{
    // 자동생성코드.
    // 운용프로그램이 실제로 작동하도록 해준다. 
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>  
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // 보통은 메모리를 과용하지 않기 위해 false. 
            Application.Run(new Form1()); // Form1을 run하고 나면 Main()이 끝나서 프로그램이 종료된다. 
        }
    }
}
