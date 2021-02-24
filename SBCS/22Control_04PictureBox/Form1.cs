using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22Control_04PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 픽쳐 1은 속성으로 추가
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // 픽쳐 2는 코딩해서 추가. 
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = Image.FromFile("rrr.png");
        }
    }
}
