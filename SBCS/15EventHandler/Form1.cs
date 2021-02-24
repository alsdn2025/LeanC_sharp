using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15EventHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("Hello", Font, Brushes.Black, 100, 100 );
            // Control에 있는 Font를 그대로 쓰고, 
            // System.Drawing에 있는 Brushes를 사용
            // 좌표 100,100에 Hello를 그려라!. 

            e.Graphics.DrawLine(Pens.Red, 10,10,200,10);
            // (10,10) 점과 (200,10)점을 잇는 선
            e.Graphics.DrawEllipse(Pens.Black, 10, 20, 30, 40);
            // 왼쪽 위 (10,20)점으로부터 너비 30, 높이 40인
            // 타원을 그림
            e.Graphics.DrawRectangle(Pens.Black, 130, 20, 100, 100); // (130,20)부터 가로100,세로 100인 사각형을 그림

        }

        // 이제 시작이다!
    }
}
