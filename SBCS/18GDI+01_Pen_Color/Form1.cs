using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _18GDI_01_Pen_Color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private int ARG()
        {
            return 0;
        }
        
        // 블루 컬러의 A,R,G,B를 띄워 보자. 
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            string strBlue_Alpha = "Alpha : " + Color.Blue.A;
            string strBlue_Red = "Red : " + Color.Blue.R;
            string strBlue_Green = "Green : " + Color.Blue.G;
            string strBlue_Blue = "Blue : " + Color.Blue.B;
            e.Graphics.DrawString(strBlue_Alpha, Font, Brushes.Blue, 30, 30);
            e.Graphics.DrawString(strBlue_Red, Font, Brushes.Blue, 30, 50);
            e.Graphics.DrawString(strBlue_Green, Font, Brushes.Blue, 30, 70);
            e.Graphics.DrawString(strBlue_Blue, Font, Brushes.Blue, 30, 90);

            ///////////////////////////////////////////////////////////
            // 나만의 팬을 만들어 사용해보자.  
            ////////////////////////////////////////////

            Color MyColor = Color.FromArgb(100,12, 34, 56); // 사용자 지정형 컬러
            Pen MyPen = new Pen(MyColor);
            // 펜의 너비를 정한다. 
            MyPen.Width = 10.0f;   //  그냥 new Pen(MyColor, 10.0f ) 해도 된다. 
            e.Graphics.DrawLine(MyPen, 100, 200, 200, 200);
            e.Graphics.DrawLine(Pens.Blue, 100, 200, 200, 200);
            // 기본 제공 팬보다 너비가 확실히 넓다. 투명하다. 


            ///////////////////////////////////////////////////////////
            // DashStyle을 써보자
            //////////////////////////////////////////////

            // DashStyle을 통해 선의 모양을 바꿀 수 있다.
            // 점선 / 실선(solid), 섞인 선 등등
            MyPen.DashStyle = DashStyle.DashDot;
            e.Graphics.DrawLine(MyPen, 100, 250, 400, 250);
            MyPen.DashStyle = DashStyle.Dot;
            e.Graphics.DrawLine(MyPen, 100, 270, 400, 270);
            MyPen.DashStyle = DashStyle.Dash;
            e.Graphics.DrawLine(MyPen, 100, 300, 400, 300);
            MyPen.DashStyle = DashStyle.Solid;
            e.Graphics.DrawLine(MyPen, 100, 290, 400, 290);

            /////////////////////////////////////////////////
            // Blush에 대해 배워보자

            SolidBrush MySolidBrush = new SolidBrush(MyColor);
            // 내부가 채워진 도형을 그릴 수 있다. 
            e.Graphics.FillEllipse(MySolidBrush, 170, 30, 180, 180);
            e.Graphics.DrawLine(MyPen, 180, 100, 240, 100);
            e.Graphics.DrawLine(MyPen, 270, 100, 330, 100);


            // Hatch : 하나의 스타일. 전경색과 배경색을 가짐. 사각형 브러쉬.  
            // Plaid : 격자. 
            HatchBrush MyHatchBrush = new HatchBrush(HatchStyle.Plaid, Color.Red, Color.Aquamarine);
            e.Graphics.FillRectangle(MyHatchBrush, 10, 300, 150, 150);



            MyPen.Dispose();
            MySolidBrush.Dispose(); // 강력한 프로그래밍!@!!@@!!@!@!@12
                                    // 크아아아아아아아아아아아아아ㅏ아아아아아아아아아아아아아아아아아아아아아아ㅏ아아아아아아아아아아아아아아아아아아아아아아ㅏ아아아아아아아아아아아아아아아아아아아아아아ㅏ아아아아아아아아아아아아아아아아아아아아아아ㅏ아아아아아아아아아아아아아아아아아아아아아아ㅏ아아아아아아아아아아아아아아아아아아아아아아ㅏ아아아아아아아아아아아아아아아아아아아아아아ㅏ아아아아아아아아아아아아아아아아아아아아아아ㅏ아아아아아아아아아아아아아아아아아아아아아아ㅏ아아아아아아아아아아아아아아아아아아아아아아ㅏ아아아아아아아아아아아아아아아아아아아아아아ㅏ아아아아아아아아아아아아아아아아아아아아아아ㅏ아아아아아아아아아아아아아아아아아아아아아아ㅏ아아아아아아아아아아아아아아아아아아아아아아ㅏ아아아아아아아아아아아아아아아아아아아아아아ㅏ아아아아아아아아아아아아아아아아아아아아아아ㅏ아아아아아아아아아아아아아아아아아아아아아아ㅏ아아아아아아아아아아아아아아아아아아아아아아ㅏ아아아아아아아아아아아아아아아아아아아아아아ㅏ아아아아아아아아아아아아아아아아아아아아아아ㅏ아아아아아아아아아아아아아아아아아아아아아아ㅏ아아아아아아아아아아아아아아아아아아아아아아ㅏ아아아아아아아아아아아아아아아아아아아아아아ㅏ아아아아아아아아아아아아아아아아아아아아아아ㅏ아아아아아아아아아아아아아아아아아아아아아아ㅏ아아아아아아아아아아
                                    // 무질서 속에서 하나의 질서가 보이는 순간, 그것은 아름다움이 된다. 

            
        }
    }
    // 기본적으로 따로 적지 않아도 InitializeComponent() 할 때 Paint가 한 번 되는건가?  -->  ㅇㅇ. 
}
