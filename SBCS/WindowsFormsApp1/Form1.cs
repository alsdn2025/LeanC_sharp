using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            domainUpDown1.SelectedIndex = 0;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = hScrollBar1.Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            hScrollBar1.Value = Convert.ToInt16(textBox1.Text);
        }

        /// //////////////////////////////////////////////
        /// // 트랙바 //////
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = trackBar1.Value.ToString();
        }
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = trackBar1.Value.ToString();

        }

        // 업다운 컨트롤
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = (int)numericUpDown1.Value;

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            textBox3.Text = domainUpDown1.SelectedIndex.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
