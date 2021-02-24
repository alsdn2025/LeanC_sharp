using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _19Image_더블버퍼링
{

    public partial class Form1 : Form
    {
        // 이미 화면에 바로 출력되는 버퍼 하나는 자동으로 존재한다.
        // 우리는 백버퍼를 추가로 만들어 줄 것이다. 

        BufferedGraphicsContext BufferContext;
        BufferedGraphics Buffergraphics;
        Image myImage;

        public Form1()
        {
            InitializeComponent();
            SetClientSizeCore(1000, 800); // 폼 크기는 800,600이다. 

            // 매니져의 static메서드 Current가 Context 객체를 return 해준다.
            // Context 참조변수가 Context객체를 참조한다. 
            BufferContext = BufferedGraphicsManager.Current; 

            // 백버퍼의 최대 사이즈를 정해준다. 
            BufferContext.MaximumBuffer = new Size(800, 600);
            // 컨텍스트의 메서드 Allocate로 BuffedGraphics 객체를 만들어(백버퍼의 실체를 만들어) 리턴한다. 크기는 800,600. 
            // BuffedGraphics참조변수가 객체를 참조한다. . 
            Buffergraphics = BufferContext.Allocate(CreateGraphics(), new Rectangle(0, 0, 1000, 1000));
            Buffergraphics.Graphics.Clear(Color.Blue); // 백버퍼를 한 번 clear
            myImage = Image.FromFile("Sky.png");

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // 좌표를 랜덤하게 백버퍼에 그림을 그린다. 
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                Buffergraphics.Graphics.DrawImage(myImage, rand.Next(0, 700), rand.Next(0, 700));
            }

            // 백버퍼에 저장된 이미지를 graphics 객체에 복사하여 나타낸다. 
            Buffergraphics.Render(e.Graphics);

            // Buffergraphics.Graphics.Clear(Color.Blue);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Invalidate();
        }
    }
}
