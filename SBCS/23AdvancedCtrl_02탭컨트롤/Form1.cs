using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23AdvancedCtrl_02탭컨트롤
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // 코드는 전체 폼 안에서 원래 쓰듯 쓰면 되고,
        // 사용자의 인터페이스는 분리되어있어 편리하다.

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Page 1!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "hahaha";
            textBox2.Text = "Page 2!";

        }
    }
}
