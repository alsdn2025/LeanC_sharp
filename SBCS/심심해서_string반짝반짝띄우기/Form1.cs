using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 심심해서_string반짝반짝띄우기
{
    public partial class Form1 : Form
    {
        Random Rand = new Random();

        private Brush PickBrush()
        {
            // 반환할 result에 Brushes.Transparent를 넣음.
            // Transparent를 : 시스템 정의 Brush 개체를 리턴
            // 즉, 그냥 형식만 넣어줌.
            Brush result = Brushes.Transparent;

            // 타입 객체에 '브러시스' 타입을 넣음.
            // 브러시스 class은 거의 열거형으로 수많은 기본 정의 브러시들을 리턴하는 속성의 집합체임.
            Type brushesType = typeof(Brushes);

            // 속성info배열에 브러시타입의 속성을 전부 넣음. 
            PropertyInfo[] properties = brushesType.GetProperties();

            // result에 랜덤으로 뽑은 '브러시스' 속성을 넣음.
            // 브러시스 속성은 브러시를 리턴하므로 result에
            // 랜덤으로 뽑혀진 브러시가 들어감. 
            int random = Rand.Next(properties.Length);
            result = (Brush)properties[random].GetValue(null, null);

            return result;
        }
        List<Brush> Rand_Brush = new List<Brush>();


        BufferedGraphicsContext BufferContext;
        BufferedGraphics Buffergraphics;


        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 100; i++)
            {
               Rand_Brush.Add(PickBrush());
            }

            BufferContext = BufferedGraphicsManager.Current;
            BufferContext.MaximumBuffer = new Size(500, 500);

            Buffergraphics = BufferContext.Allocate(CreateGraphics(), new Rectangle(0, 0, 500, 500));
            Buffergraphics.Graphics.Clear(Color.White); // 백버퍼를 한 번 clear


        }
        
       

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                Buffergraphics.Graphics.DrawString(textBox1.Text, Font, Rand_Brush[Rand.Next(100)], Rand.Next(500), Rand.Next(500));
            }
            Buffergraphics.Render(e.Graphics);
            Buffergraphics.Graphics.Clear(Color.White);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Start();
            }
            else
                timer1.Stop();
            
        }
    }
}
