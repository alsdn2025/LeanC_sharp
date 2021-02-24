using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19Image_비트맵
{
    public partial class Form1 : Form
    {
        // 필드로 bitmap 선언
        Bitmap bitmap;  

        public Form1()
        {
            InitializeComponent();

            // 메모리에 비트맵 객체를 생성. 
            // 비트맵 크기와 폼 크기를 400,300으로 설정
            bitmap = new Bitmap(400, 300); 
            SetClientSizeCore(400, 300);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics bitmapGraphics = Graphics.FromImage(bitmap);// FromImage는 static 메서드. Graphics 객체에 내가 메모리에 생성한 bitmap 객체를 넣어줌(파일 로딩이랑 같다)
            //bitmapGraphics.Clear(Color.Yellow); // 배경 화면을 Yellow로

            for (int i = 0; i < 100; i++)
            {
                // 이 때 Graphics.Draw는 폼에 그리는 게 아니라, 
                // 내가 생성한 bitmap 객체에 그린다. 
                bitmapGraphics.DrawString("우아아아아악", Font, Brushes.Violet, i*6 +10, i*6 + 10);
                bitmapGraphics.DrawRectangle(Pens.Black, i*10, 10, i*20, 100);
            }
            bitmapGraphics.DrawString("정신나갈거같애~", Font, Brushes.DarkRed, 10, 150);

            // 그러므로 실제로 폼에 이미지를 띄우려면 e.Graphics로 해야한다.
            e.Graphics.DrawImage(bitmap, 0, 0);


        }
        // 정리
        // 필드에 bitmap 참조변수를 선언한다. -> Graphics 참조변수에 Graphics.FromImage(bitamp참조변수)를 이용해 graphics 객체를 넣어준다. --> Graphics참조변수.Draw 메서드로 graphics 객체에 그림을 그린다  --> e.Graphics로 폼에 이미지를 띄운다. 
    }
}
