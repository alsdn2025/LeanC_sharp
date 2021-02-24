using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22Control_01TextBox
{
    public partial class Form1 : Form
    {
        public void Calculate_Text4()
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                textBox4.Text = "empty";
                return;
            }

            else if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                float result = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text) / 3.0f);

                textBox4.Text = result.ToString("f1"); // "" 에 맞는 포멧 스트링으로 변환. f1 : float인데 소숫점 1자리까지만 표현하는 string.
            }

            else
            {
                textBox4.Text = "invalid Value Exist";
            }
        }

        public Form1()
        {
            InitializeComponent();
            Calculate_Text4();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { textBox1.Text = "100"; }
            else
            {
                textBox1.Text = (Convert.ToInt32(textBox1.Text) + 100).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            { textBox2.Text = "100"; }
            else
            {
                textBox2.Text = (Convert.ToInt32(textBox2.Text) + 100).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            { textBox3.Text = "100"; }
            else
            {
                textBox3.Text = (Convert.ToInt32(textBox3.Text) + 100).ToString();

            }
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Calculate_Text4();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Calculate_Text4();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Calculate_Text4();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";

            // 아예 Text를 지우려면 
            textBox1.Text = null;
            textBox2.Text = "";
            textBox3.Clear();
            // 일케 해주면 된다. 다 똑같음. 
            // 이렇게해주면 텍스트엔 NULL이 아니라 "" 이 들어간다.
            


        }
    }
}
