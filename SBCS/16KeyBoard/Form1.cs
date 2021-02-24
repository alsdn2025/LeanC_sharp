using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16KeyBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("KeyDown");


            if(e.KeyCode == Keys.A && e.Shift /*e.KeyCode에는 Alt Control Shift 등이 없으므로 e의 property를 이용한다. */ && e.Control)
            {  // 이런 식으로 동시에 눌리는 키 조합에 대한 이벤트를
               // 설정 가능하다!
                MessageBox.Show("KeyCode + Shift + Control !");
            }

            // switch를 이용해서 입력값을 삼지하는 이벤트 설정
            switch (e.KeyCode)
            {
                case Keys.B:
                    MessageBox.Show("B키");
                    break;
              /*중요*/  case Keys.Control: // Ctrl눌러도 작동 안함. 왜?
                         // e.KeyCode에는 Control에 대한 값이 없으니까!
                         // e.KeyCode == Control이 true가 될 수 없다!
                    MessageBox.Show("컨트롤키"); 
                    break;
                default:
                    break;
            }

            if(e.Modifiers == (Keys.Shift|Keys.Control))
            { // 모디파이어는 e.Alt, e.Control, e,Shift의 합친 버전. 
                MessageBox.Show("Modifiers + Shift + Control!");
            }
            if(e.KeyCode == Keys.C && e.Modifiers == (Keys.Shift|Keys.Alt))
            {
                MessageBox.Show("C + Shift + Alt!");
            }

            // Modifiers 끼리 더할 땐 |를 쓰고(동시에 눌렀음을 표시)
            // 로직과 더할 땐
            // ||과 &&, | 의 기능 차이에 주의. 
            // |는 비트단위 , ||와 &&는 로직단위. 


            //////////////////////////
            // KeyCode, Modifiers를 알아봤으니
            // KeyData에 대해 알아보자
            ///////////////////////////////

            if(e.KeyData == (Keys.D | Keys.Shift ))
            {
                MessageBox.Show("D + Shift!");
            }
            // Modifiers + KeyCode라고 생각하면 편할 듯

           

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("KeyPress");
        }
        // 문자 키가 눌렸을 경우 두 함수 모두 호출되고, 기능 키가 눌렸을 경우 KeyDown만 호출된다. 
        // KeyDown은 KeyEventArgs를, KeyPress는 KeyPressEventArgs를 인자로 받기 때문에. 

    }
}
