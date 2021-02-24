using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24대화상자_오류
{
    public partial class Form1 : Form
    {
        int Red;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Red.ToString());
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Red++;
            e.Graphics.DrawString(Red.ToString(), Font, Brushes.Black, 10, 10);
        }
    }
}
