using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24대화상자
{
    public partial class Form1 : Form
    {
        public string Message;

        public Form1()
        {
            InitializeComponent();
        }
        

        private void 예야ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Form2 클래스의 객체를 참조변수에 넣어준다. 
             Form2 Dlg = new Form2();
            // Dlg.Show() : 폼(컨트롤)을 사용자에게 보여준다. "close" 되지 않아도 원래폼 사용가능하다.
            // showDialog : 폼을 모달형 대화상자로 show한다. "close"되어야 원래 폼으로 돌아올 수 있다.
            if (Dlg.ShowDialog() == DialogResult.Yes)
            {// 만일 DialogResult가 정상종료Yes라면, Dlg의 텍스트를 메인폼에 텍스트로 옮긴다. 
                if (Dlg.GetText(0) != null)
                { textBox1.Text = Dlg.GetText(0); }
            }
            Dlg.Dispose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Dlg = new Form2();
            Dlg.Owner = this;
            Message = textBox2.Text;
            // button1_Click이 끝나면 
            // Form2의 Owner도 null로 돌아간다.
            Dlg.ShowDialog();

            // button1_Click 에서 생성한 Form2 객체와
            // ToolStripMenuItem_Click에서 생성한 객체는 다르다. 
            // 고로 여기서 Form2의 텍스트박스에 값을 넣어둔다 해도,
            // ToolStripMenuItem_Click 에서는 다른 객체를 불러오므로 텍스트박스에 값이 없는 것이다. 
            // 두 함수가 가르키는 객체를 같게 만들기 위해선 지역변수가 아닌, class 안에 필드로 선언해야 한다.
            // 그러면 두 Form이 주고받는 듯한 기능을 구현할 수 있을 듯. 
            // 어케하는지는 알겠다.
            // 근데 그러면 모델리스형이 낫겠다. 

            Dlg.Dispose();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
