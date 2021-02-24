using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24대화상자
{
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            if (Owner != null)
            {
                textBox1.Text = ((Form1)Owner).Message;
            }
        }


        //  텍스트 박스[_index]의 텍스트를 return
        public string GetText(int _index)
        {
            List<string> Text = new List<string>();
            Text.Add(textBox1.Text);

            return Text[_index];
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 정상적으로 FormClosing되면 Yes를 DialoghResult 속성에 넣는다.
            DialogResult = DialogResult.Yes;
        }
        
    }
}
