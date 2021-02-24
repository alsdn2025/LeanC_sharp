using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19Image_03ResourceImage
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            // 이미지 리소스로 등록시켜놓으면 이렇게 
            // 본래 있는 파일(리소스)처럼 사용할 수 있다. 
            SetClientSizeCore(Properties.Resources.Image1.Width, Properties.Resources.Image1.Height);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // 비트맵 참조 객체에 Image1을 참조시킨다.
            // 즉, Image1은 이미 프로그램상 있는 이미지로 취급되있음을 알 수 있다. 
            // 이처럼 bitmap 객체를 만들고 다른 폴더에 있는 이미지를 불러와 객체에 넣어줄 필요 없이
            // 시스템상에 있는 리소스 이미지를 넣어주면 되기에 편리하다. 
            Bitmap bitmap = Properties.Resources.Image1;
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
