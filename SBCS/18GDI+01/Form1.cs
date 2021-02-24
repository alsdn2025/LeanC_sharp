using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18GDI_01
{

    public partial class Form1 : Form
    {
        // ++ 랜덤 색을 저장하는 컬렉션
        List<Pen> Rand_Pen = new List<Pen>();

        // 클릭시마다 원을 그리는 프로그램
        Point[] ptCircle;
        int nCount;
        Random randSeed = new Random();
        
        public Form1()
        {
            InitializeComponent();

            ptCircle = new Point[100]; //
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            /*
            // 랜덤 색을 대입해주기 위한 switch문
            switch (randSeed.Next(5, 10))
            {
                case 5: Rand_Pen.Add(new Pen(Color.Black));
                    break;
                case 6:
                    Rand_Pen.Add(new Pen(Color.Blue));
                    break;
                case 7:
                    Rand_Pen.Add(new Pen(Color.Violet));
                    break;
                case 8:
                    Rand_Pen.Add(new Pen(Color.Red));
                    break;
                case 9:
                    Rand_Pen.Add(new Pen(Color.DarkCyan));
                    break;
                default:
                    break;
            }
            */// <---------------------- 필요없어짐

            Rand_Pen.Add(new Pen(Color.FromArgb(randSeed.Next(255), randSeed.Next(255), randSeed.Next(255))));

            // Point 배열에 마우스 커서의 X,Y 값 저장.
            ptCircle[nCount].X = e.X;
            ptCircle[nCount].Y = e.Y;
            nCount++;
            Invalidate();

        }

        Pen RandomPen = new Pen(Color.Black);
        int RandomNumber;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("◎w◎",Font,Brushes.Black,30,30);
            // 만약 PaintEventArgs e 를 받지 못하는 함수의 경우
            // 이 함수는 아니지만
            // 여튼 이렇게 CreateGraphics로 참조변수를 만들어 쓴다. 
            // e.Graphics 대신 g를 쓰면 됨. 
            Graphics g = CreateGraphics();
            for (int i = 0; i < nCount; i++)
            {
                for (int j = 0; j < 3; j++) // 원 세개씩 할래
                {
                    RandomNumber = randSeed.Next(10, 30);
                    g.DrawEllipse(Rand_Pen[i], ptCircle[i].X - RandomNumber, ptCircle[i].Y - RandomNumber, RandomNumber * 2, RandomNumber * 2);
                }
            }
            g.Dispose(); // 단, 그래픽 참조변수를 만들었을 경우 dispose해주자. 
          
        }
        // 기포같당. 
        // 시간에 따라 자동으로 랜덤 색/ 랜덤 크기 가진 원 생성하는 프로그램도 만들 수 있겠다. 
        // 원 대신 텍스트를 띄워도 괜찮을듯. 


    }
}
