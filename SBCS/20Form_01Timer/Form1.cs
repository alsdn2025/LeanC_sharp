using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
// 아직 안배움. reflection
using System.Reflection;
// 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20Form_01Timer
{

    public partial class Form1 : Form
    {
        Random Rand = new Random();

        // 랜덤 색상의 브러시를 리턴하는 메서드. 구글링
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
        // DrawString 안할거면 굳이 필요하진 않다. 

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 100; i++)
            {
                Rand_Brush.Add(PickBrush());

            }
        }

        // 1틱 할 때마다 발생하는 이벤트
        private void timer1_Tick(object sender, EventArgs e)
        {
             Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                // 색도 랜덤으로 설정하고 싶네. 
                // 브러시가 abstract라 리스트.add 로 못넣어줌..
                // 구글링 결과 누군가 만든 PickBrush 메서드를 발견함.
                // 아직 안배운 Reflection개념이 들어가 있다. 
                // e.Graphics.DrawString("★정수빈 병신★", Font, Rand_Brush[Rand.Next(100)], Rand.Next(300), Rand.Next(300));

                // 이번엔 Random Pen을 이용한 사각형. 
                // 멋있다.
                e.Graphics.DrawRectangle(new Pen(Color.FromArgb(Rand.Next(255), Rand.Next(255), Rand.Next(255))), 100 + Rand.Next(100), 100 + Rand.Next(100), Rand.Next(100), Rand.Next(100));




            }
        }
    }
}
