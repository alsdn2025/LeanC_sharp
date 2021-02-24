using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25폼분할_스크롤
{

    public partial class Form1 : Form
    {
        Image myImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            myImage = Image.FromFile("test.png");
            // 스크롤의 최소 사이즈를 설정한다.
            // 이렇게만 해주면 스크롤이 출현한다. 
            this.AutoScrollMinSize = myImage.Size;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // ScrollPosition은 스크롤이 움직이면 움직인 만큼의 음의 값을 가진다.
            //  만약) 하단 스크롤의 위치가 -100이라면, 
            // Graphics는 이미지를 -100,0에 출력하고
            // 우리가 보는 영역인 클라이언트 영역은 (0,0)에서부터 보이기 때문에
            // (-100,0)에서 (0,0)까지의 음수부분은 마치 잘린 것처럼 보이지 않게 되는 것이다. 
             
            e.Graphics.DrawImage(myImage, AutoScrollPosition.X, AutoScrollPosition.Y);
            
        }
    }
}
