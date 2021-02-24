using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24대화상자_01모델리스
{
    public partial class Form2 : Form
    {
        string Message = "WWWweasqd";

        public Form2()
        {
            InitializeComponent();
            MessageBox.Show("모델리스 객체가 만들어졌습니다.");
         
        }

        public void SetTextbox1(string _Text)
        {
            textBox1.Text = _Text;
        }

        public string GetTextbox1()
        {
            // return Message;
            return textBox1.Text;
        }

        // 로드는 폼이 처음으로 표시되기 전에만 발생
        // Form2 객체가 생성됐을 때가 아니라, Show했을 때 발생했다. 
        private void Form2_Load(object sender, EventArgs e)
        {
            if(Owner != null)
            {
                textBox1.Text = ((Form1)Owner).Message;
            }
            else { MessageBox.Show("오너가 없습니다."); }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Owner != null)
            {
                ((Form1)Owner).SetTextbox1(textBox1.Text);
            }

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Form2 Closed");
            DialogResult = DialogResult.Yes;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Form2 Closing");
            DialogResult = DialogResult.Yes;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Message =
            textBox1.Text;
            MessageBox.Show("Form2 textBox1_TextChanged");
        }
    }
}
