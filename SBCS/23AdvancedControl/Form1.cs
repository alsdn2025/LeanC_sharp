using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23AdvancedControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // 텍스트가 100에 도달하는 것에 비해
            // 바가 끝가지 차는게 너무 느리다.
            // 왜?? 
            
            progressBar1.Value++;
            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                progressBar1.Value = 0;
            }
            textBox1.Text = progressBar1.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 80 ;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Interval += 5;
            textBox2.Text = timer1.Interval.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Interval -= 5;
            textBox2.Text = timer1.Interval.ToString();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // 그냥 ToString시, Long 타입으로 출력
            textBox3.Text = dateTimePicker1.Value.ToShortDateString();
        }
    }
}
