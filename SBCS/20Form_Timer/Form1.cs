using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20Form_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Width = 500;
            Height = 500;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 폼이 표시되기 전에 메세지박스가 먼저 발생한다.
            // Load는 폼이 처음 표시되기 전에 실행되는 메서드이다.
            MessageBox.Show("Form1_Load");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 메세지박스("텍스트","폼제목". 네/아니오버튼) 을 띄운다.
            if (MessageBox.Show("Exit?", "Form", 
                MessageBoxButtons.YesNo) == DialogResult.No)
            {   //  '아니오' 라면 이벤트를 취소시킨다. 
                // .Cancel : 이벤트를 취소할지 여부.  
                e.Cancel = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Form is Closed. \nBye!");
        }

        // 폼이 생성되기 직전에 호출
        // 폼의 크기나 컨트롤의 위치를 변경했을 때 호출. 
        // layout -> layout -> Form1_Load -> layout 순서로 뜬다. 왜?
        // 위 생성자에서 Width 변경 -> Height 변경 -> 폼 로드 -> 폼 생성 직전 호출 
        // Form_Load 이후 layout 호출. 
        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
            MessageBox.Show("s");
        }

        // 컨트롤의 크기가 변경될 때 호출되어
        // 다시 크기를 정해버림으로서 크기변경을 막는다. 
        private void Form1_Resize(object sender, EventArgs e)
        {
            // object인 sender를 Control로 업캐스팅
            Control control = (Control)sender;
            control.Width = 500;
            control.Height = 500;

            // 혹은

            Width = 500;
            Height = 500;  // 일케해도 된다. 
        }
    }
}
