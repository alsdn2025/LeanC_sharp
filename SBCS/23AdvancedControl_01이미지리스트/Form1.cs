using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23AdvancedControl_01이미지리스트
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // imageList에 이미 있는 메서드인 Draw를 이용한다. 
            // 그림을 그리는 주도권을 Graphics가 아닌,imageList가 가진다. 
          imageList1.Draw(e.Graphics, 0, 0, 0);
            imageList1.Draw(e.Graphics, 0, 100, 1);
            imageList1.Draw(e.Graphics, 0, 200, 2);
        }
    }
}
