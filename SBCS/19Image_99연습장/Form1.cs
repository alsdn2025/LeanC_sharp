using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19Image_99연습장
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        Bitmap yep = Properties.Resources.yep;
        Bitmap MadeInHere;
        Font MyFont = new Font("ME",20);

        public Form1()
        {
            InitializeComponent();
            MadeInHere = new Bitmap(100, 100);
            Graphics MadeInHereGraphics = Graphics.FromImage(MadeInHere);
            MadeInHereGraphics.DrawString("⊙", MyFont, Brushes.GreenYellow, MadeInHere.Width/2 - 3, MadeInHere.Height/2 - 3);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        { // 더블클릭시 내가 저장한 이미지인 yep을 랜덤한 크기로 띄운다. 

            Graphics DoubleClikkGraphics = CreateGraphics();
            DoubleClikkGraphics.DrawImage(yep, e.X- (yep.Width/2), e.Y - (yep.Height/2) , rand.Next(20,100),rand.Next(20,100));


            DoubleClikkGraphics.Dispose();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics MouseMoveGraphics = CreateGraphics();
            MouseMoveGraphics.DrawImage(MadeInHere, e.X - 20 , e.Y - 20 , 40, 40);

        }
    }
}
