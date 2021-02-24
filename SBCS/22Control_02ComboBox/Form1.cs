using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22Control_02ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // --------------------------------------------
        // 콤보 박스를 써보자.

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {// 선택한 항목의 Text에 따라
            // 콤보박스 자신의 Text가 정해짐을 알 수 있다.
            textBox1.Text = Convert.ToString( comboBox1.SelectedIndex );
            textBox2.Text = comboBox1.Text;
        }

        // --------------------------------------------
        // 리스트 박스를 써보자

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(listBox1.SelectedIndex);
            textBox4.Text = listBox1.Text;
        }

        // 콤보 박스와 유사하나, Items 컬렉션을 통해 유동적으로 리스트를
        // 더하거나 삭제할 수 있다. 
        // 더 가변적인 항목을 다룰 때 사용한다. 
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox5.Text);
            textBox5.Clear();
        }
    }
}
