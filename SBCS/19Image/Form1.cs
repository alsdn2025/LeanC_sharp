using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19Image
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(500, 500);
        }
        
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Image 참조변수에 Image타입을 반환하는 FromFile static method로 이미지를 넣는다. 
            Image Imaaage = Image.FromFile("Imaaage.png");
            // e.Graphics를 이용해서 그린다. 
            //e.Graphics.DrawImage(Imaaage, 10, 10);
            

            /////////////////////////////////////////////////
            // BitMap 이용 //  폼의 크기에 따라 이미지 크기도 변경한다
            /////////////////////////////////////
            Bitmap MyBitmap = new Bitmap("Imaaage.png");
            // SetClientSizeCore(MyBitmap.Width, MyBitmap.Height);
            // --> SetClientSizeCore(x,y) : 폼의 크기를 정한다. 
            e.Graphics.DrawImage(MyBitmap, 0, 0, this.Width,this.Height);

        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

    }
}
