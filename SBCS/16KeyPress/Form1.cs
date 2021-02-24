using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16KeyPress
{
    public partial class Form1 : Form
    {

        String strMessage; // 문자열을 모으기 위한 필드

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            strMessage += e.KeyChar; // e에 입력된 문자를
                                     // KeyChar의 속성이 문자의 대소문자                      를 구분하여
                                     // 아스키 값으로 리턴.
                                     // string형에 +=을 할 경우, 연산자 오버로딩으로 인해
                                     // 문자열을 계속 붙일 수 있다!

            

            Invalidate();   //  이 메서드를 실행함으로서, 내부적으로 WM_Paint라는 메세지가 발생하고, 이를 감지하여 이벤트핸들러를 호출하고, 연결된 Form1_Paint라는 메서드가 호출된다. 
            
        }


        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            MessageBox.Show(strMessage);  //////////////////////
            /////////////////////////////// 이 메세지박스를 통해 알 수 있듯, 입력된 문자에 추가로 입력한 문자를 그리는 게 아니라,아예 새로 지웠다가 strMessage를 다시 띄우는 기능이다.
            // 지우는 게 안보일만큼 처리속도가 빨라서 그냥 추가로 띄우는 걸로 보일 뿐.
            // Invalidate()는 컨트롤창을 지우고 다시 Paint하는 메서드이다. 


            e.Graphics.DrawString(strMessage, Font, Brushes.Black, 10, 10); // (10,10) 에 문자열을 그린다. 
        }



       
        /// ///////////////////////////////
        private void Form1_DoubleClick(object sender, EventArgs e)
        {
        }
        // Paint함수를 하나 더 만들어서 다른 내용을 붙일 순 없는거?
        // 
    }
}
