using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25폼분할
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.LightPink, 10, 10, 30, 30);
            e.Graphics.DrawLine(Pens.LightPink, 100, 100, 300, 300);
            e.Graphics.DrawLine(Pens.LightPink, 10, 150, 350, 305);
            e.Graphics.DrawLine(Pens.LightPink, 10, 120, 310, 230);
            MessageBox.Show("dd");
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
