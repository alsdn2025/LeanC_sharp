using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _17Mause사각형
{
    public partial class Form1 : Form
    {
        string strMousePos;


        // 사각형 구조체 타입 Rectangle
        Rectangle rectMouse;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            string str = "left : " + rectMouse.X;
            str += " top :" + rectMouse.Y;
            str += " right : " + rectMouse.Right;  // Right : x값 + width
            str += "bottom : " + rectMouse.Bottom;  // bottom : y값 + height
            e.Graphics.DrawRectangle(Pens.Violet, rectMouse);


            // e.Graphics.DrawString(str, Font, Brushes.Blue, 20, 20);
            // e.Graphics.DrawString(rectMouse.ToString(),Font,Brushes.Black,50,50);
            e.Graphics.DrawString(strMousePos, Font, Brushes.DeepPink,rectMouse.Right, rectMouse.Bottom);
        }

        // MouseDown으로 하나 MouseClick으로 하나 큰 차이점 x.
        // but MouseEventArgs를 받아야 하므로 그냥 Click()은 안됨. 
        // ?? 차이가 있나봄.

        //private void Form1_MouseClick(object sender, MouseEventArgs e)
        //{
        //    rectMouse.X = e.X;
        //    rectMouse.Y = e.Y;
        //    rectMouse.Width = 0;
        //    rectMouse.Height = 0;
        //    Invalidate();
        //}                

        
        // Click : 버튼을 눌렀다 떼는 것.
        // Down : 버튼이 눌리는 것. 
        // 완~~전 다르다!!
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            rectMouse.X = e.X;
            rectMouse.Y = e.Y;
            rectMouse.Width = 0;
            rectMouse.Height = 0;
            Invalidate();
            
        }
        

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

            strMousePos = "X : " + e.X + " Y : " + e.Y;

            // MouseMove했는데, Left버튼이 눌려있는 중이다.  ->  드래그중이다. 
            if (e.Button == MouseButtons.Left) 
            {
                rectMouse.Width = Math.Abs(e.X - rectMouse.X)  ;
                rectMouse.Height = Math.Abs( e.Y - rectMouse.Y); 
                Invalidate();
                 
            }

            // ----------------- 참고 -------------------------
            // Rectangle의 Width는 x2 - x1 +1 인가 x2 - x1인가? 
            // 답 : x2 - x1. 17Mouse프로젝트의 Form1.cs 참조. 
        }
    }
}
