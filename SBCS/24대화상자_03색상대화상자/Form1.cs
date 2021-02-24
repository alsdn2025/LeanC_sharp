using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24대화상자_03색상대화상자
{
    public partial class Form1 : Form
    {
        // 필드를 만들어놓았다.
        int Red, Green, Blue;

        public Form1()
        {
            InitializeComponent();
            Red = 0;
            Green = 0;
            Blue = 0;
        }
        
        // 왜 Paint가 계속 돌지?? 이유가 뭐지??
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color Color1 = new Color();
            Color1 = Color.FromArgb(Red, Green, Blue);

            string str = "Red : " + Red + " Green : " + Green + " Blue : " + Blue;
            e.Graphics.DrawString(str, Font, Brushes.Black, 10, 10);
            
            e.Graphics.DrawEllipse(new Pen(Color1), 50, 50, 100, 100);

            // Paint 이벤트의 e는 다시 칠해야 할 사각형 영역을 시스템으로부터 전달받는다.
            // 이 프로젝트에서는 클라이언트영역 전체이다. 
            // 고로 계속 폼 전체를 다시 칠하기에 gr의 Eclipse는 보이지 않게 된다. 
            // 또한 invalidate로 Paint를 호출하지 않아도 Paint매서드는 내부에 의해 계속 호출된다. 
            Rectangle testRectangle = new Rectangle();
            testRectangle = e.ClipRectangle;
            testRectangle.X = -1;
            testRectangle.Y = -1;
            e.Graphics.DrawRectangle(Pens.Green, testRectangle);
            // 어쩌면 이 ClipRectangle이 안보이는 이유가, 영역과 일치함으로서 영역 밖에 그려서일지도 모르겠다.
            // 맞네. 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Red.ToString());
            
            

            Color Color1 = Color.Black;
            // 역시 ShowDialog()로 대화상자를 연다.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color1 = colorDialog1.Color;
                // 색상의 ARGB값을 나타내는 struct Color 객체를 만들어, colorDialog1에서 선택된 색상을 넣는다. 
                Red = Color1.R;
                Green = Color1.G;
                Blue = Color1.B;
                Invalidate(new Rectangle(0,0,140,140));
                // 왜 invalidate를 호출하면 
                // 밑의 gr이 작동하지 않지?
                /// 작동하지 않는게 아니라, 작동한 뒤 다시 Paint되어 덮어씌워진다. 
            }


            // 어쩌면, 이 녀석들이 작동되고나서
            // 내가 코드를 친 부분 x, 자동으로 Paint가 호출되어 바로 지워버리기 때문일지도 모른다.(가설 i )
            // 확인해보자
            Graphics gr = CreateGraphics();
            gr.DrawEllipse(new Pen(Color1), 100, 150, 100, 100);
            
            
            // 가설 i를 증명했다. 
            // gr의 버퍼와 e의 버퍼는 다른 것일까? 
            // invalidate()는 클라이언트영역을 다 지우고 Paint를 호출하는 것이라고 했다.
            // 그렇다면 invalidate()가 아니라 시스템상에서 그냥 Paint가 호출되었는데도 클라이언트 영역이 다 지워진 건 왜일까?
            // 시스템상에서 Paint를 호출한 게 아니라, invalidate()를 호출한 것일까? 

            // 위의 invalidate()를 주석처리하면, gr이 원을 그린 후 그림이 덮어씌워지지 않는다. 
            // 어쩌면 내가 invalidate()를 한 번 호출했기에 프로그램 내부에서 계속 invalidate()를 호출하는 거? 


        }
    }
}
