using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25폼분할_MDI_다중폼_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 폼1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 MdiChildForm2 = new Form2();
            // 자식 폼에 부모 폼 = this로 설정해준다. 
            MdiChildForm2.MdiParent = this;
            // 자식 폼을 띄운다.
            MdiChildForm2.Show();
        }

        private void 폼2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 MdiChildForm3 = new Form3();
            MdiChildForm3.MdiParent = this;
            MdiChildForm3.Show();
        }
    }
}
