using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17Mause
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Form1  -- > Form에서 나타나는 이벤트다.
        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click");
        }
        

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Mouse Click");
        }
        //  - 폼도 컨트롤을 상속하므로 폼 위에서 클릭은
        //  Click() -> MouseClick() 둘 다 발생한다.

         /// /// /// // /// ////   ///
        // button1에서 나타나는 이벤트다. 
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("You Push Button");
        }




        // 현재 마우스 좌표를 출력해보자. 
        string strMousePos;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            strMousePos = "X : " + e.X + "Y" + e.Y;
            Invalidate(); // 컨트롤창을 지우고 WM_PAINT를 보낸다. 
        }

        Rectangle Rect;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Rect.X = 10;
            Rect.Y = 9;
            Rect.Width =4 ;
            Rect.Height = 10;
            
            e.Graphics.DrawString(strMousePos, Font, Brushes.DeepPink, 5, 17);
            e.Graphics.DrawRectangle(Pens.Red, Rect);
            e.Graphics.DrawLine(Pens.Black, 10, 10, 15, 10);


            


        }

// ------------------실험 -----------------------------
//	0. DrawLine으로(10,0)과(11,0)을 이은 결과, 픽셀 두 개가 칠해졌다.
//->(전제) DrawLine은 시작점과 끝점을 포함하여 칠한다. 
//	1. DrawLine으로 (10,10)과(15,10)을 이었다. // 전제에 따라 
//	 (10,10) , (11,10), (12,10), (13,10), (14,10), (15,10) 총 6칸이 칠해진다.이 6칸이라는 값은 (칸)(15 - 10 + 1)의 값이다.
//	2. DrawRectangle로 X, Y좌표 (10,9), Width 5를 가진 Rect을 그렸다.
//    결과 : Rect의 가로선은 DrawLine과 길이가 일치했다.

//---------------------결론 -------------------------
//		○ DrawRectangle은 Width가 5임에도 6칸을 칠했다. 고로 DrawRectangle이 그리는 선의 칸 수는 시작점+Width이다.
//		○ 픽셀(그래픽) 상에서 두 점을 잇는 선의 길이는 x2 - x1 +1이 맞으나, DrawRectangle은 시작점+Width만큼 선을 그리므로(픽셀을 칠하므로) , Width는 x2-x1으로 해야한다. 
//		○ Rectangle의 Width는 X2 -X1 이다. 
//또한 마우스 포인터는 맨 끝 검은색 점이 직접 좌표를 가르킨다



    }
}
