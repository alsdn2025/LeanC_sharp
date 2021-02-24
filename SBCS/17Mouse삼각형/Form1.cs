using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17Mouse삼각형
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        string strMousePos;
        // 마우스 좌표를 출력해보자. 
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            strMousePos = "X : " + e.X + " Y" + e.Y;
            Invalidate(); // 컨트롤창을 지우고 WM_PAINT를 보낸다. 
        }
        

        // --------------------------------------------------------- //
        // 마우스를 3번 클릭할 때마다 삼각형을 출력하는 코드를 짜보자
        

        // Point라는 자료형을 가진 컬렉션
        // Ponint는 x,y값을 저장하는 구조체. 
        List<Point> ListPoint = new List<Point>();

      

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // 현재 마우스가 가르키는 좌표를 띄워보자. //
            e.Graphics.DrawString(strMousePos, Font, Brushes.DeepPink, 30, 30);
            
            // 내가 DoubleClick하여 저장한 좌표로 삼각형을 그려보자. ///
            if (ListPoint.Count == 3)
            {
                e.Graphics.DrawLine(Pens.Black, ListPoint[0], ListPoint[1]);
                e.Graphics.DrawLine(Pens.Black, ListPoint[1], ListPoint[2]);
                e.Graphics.DrawLine(Pens.Black, ListPoint[0], ListPoint[2]);
            }
            // 내가 DoubleClick하여 저장한 좌표를 띄워보자. ///////////
            foreach (var item in ListPoint)
            {
                // List<Point>를 string으로 어케 바꿀까. 
                // ToString 기능이 있넹
                e.Graphics.DrawString(item.ToString().ToString(), Font, Brushes.BlueViolet, (float)item.X, (float)item.Y);

                // 이제 string을 조금 바꿀 수 없을까?
                // 번호를 붙이고 싶다. index 순서에 맞게.
                // foreach가 아니라 for를 써야하나?  그래야 할 듯.
                // 그냥 이대로 두자. 어려운건 아니지만, 그냥 foreach를 그대로 쓰는게 코드가 더 깔끔할 것 같다. 
            }
        }


        // DoubleClick시 좌표를 ListPoint에 저장한다. 
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(ListPoint.Count < 3)
            {
                ListPoint.Add(new Point(e.X, e.Y));
            }
            else
            {
                // Point가 3개 이상이면
                // 선입된 Point를 삭제하고 새로운 Point를 마지막에 붙인다. 
                // 선입선출
                ListPoint.RemoveAt(0);
                ListPoint.Insert(2, new Point(e.X, e.Y));
            }
        }
    }
}
