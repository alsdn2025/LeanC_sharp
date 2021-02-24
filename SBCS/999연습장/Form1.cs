using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _999연습장
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Graphics gr = CreateGraphics();
            gr.DrawLine(Pens.Red, 10, 10, 300, 300);
            Rectangle MyRec = new Rectangle(10, 10, 200, 200);
            Invalidate(MyRec);
            // Update(); // 만약 Update가 invalidate가 설정한 '지우고그리기' 방식을 다시 예전처럼 '덧그리기'로 바꾸는 메서드라고 한다면,

            gr.DrawLine(Pens.Red, 10, 10, 300, 300);
            // Update()를 호출 한 뒤, 다시 선을 그리고, 다시 Paint를 호출했을 때, 
            // 선과 선이 덧그려질까? 
            
            // 애초에 Paint에 '덧그리기'라는 방식이 존재하는가? 
            // 존재하지 않을 것 같다. 

            // Update()를 호출한 뒤 새로 라인을 그려주지 않으면 붉은선이 다시 생기지 않는 걸로 보아 Update는 지워진 걸 다시 그리는 메서드는 아니다. 

            // 어쩌면 invalidate를 호출한 순간, 폼은 계속하여 invalidate를 지속적으로 호출하고
            // Update를 호출한 순간부터 invalidate를 그만 호출하는 걸지도 모르겠다. 
            // Update를 호출한 뒤에 선을 그리면 지워지지 않는 걸 보니. 


            //gr.DrawLine(Pens.Green, 10, 10, 300, 300);
            //gr.DrawLine(Pens.Red, 10, 10, 300, 300);
            //gr.DrawLine(Pens.Red, 10, 10, 300, 300);
            // DrawLine했는데 Paint가 호출되어 선을 지워버리는 이유는 무엇일까?
            // 무엇이 Paint를 왜 언제 호출하는 것일까? 
            // invalidate를 호출한 함수가 실행되는 동안 계속 invalidate가 지속적으로 발생하는 걸까? 
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Blue, 300, 10, 10, 300);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics gr = CreateGraphics();
            gr.DrawLine(Pens.Red, 10, 10, 300, 300);
            // 버튼 1을 누르고 버튼 2를 그리면 빨간 선은 멀쩡히 살아있다. 
            // 이는 버튼2클릭 이벤트의 gr이 그린 뒤에는 invalidate가 발생하지 않았음을 의미한다. 
            // 그렇다면 위의 버튼1클릭 이벤트에서는 왜 자꾸 DrawLine한 뒤 invalidate가 발생하는 것일까? 
            // invalidate를 호출한 함수가 실행되는 동안 계속 invalidate가 지속적으로 발생하는 걸까? 

        }
    }
}
