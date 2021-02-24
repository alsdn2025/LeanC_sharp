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
    public partial class Form1 : Form
    {
        Form2 Modelless_Dlg = null;
        public string Message; 

        public Form1()
        {
            InitializeComponent();
        }

        public void SetTextbox1(string _Text)
        {
            textBox1.Text = _Text;
        }


        // 문제점 : 한 번 모델리스를 닫고 나면, 
        // 삭제된 객체라며 오류가 뜬다. 
        // 닫으면 Form2에서 closed때 자동으로 메모리를 해제하나? 
        // 닫힐 때, 확실히 참조변수에 null 을 넣어주거나
        // 닫아도 객체가 삭제되지 않도록 해야한다.
        //
        // 아마도
        // 참조변수가 가르키던 객체가 삭제될 때
        // 참조변수에는 null이 아니라 삭제된 객체의 옛 주소값이 남아있어서 그런가?
        // 오류가 나는 것 같다. 
        // 실험해보자
        //
        // 맞는 듯.
        // 모델리스가 닫히면 Dispose()된다. 객체는.
        // 참조변수를 통해 객체가 Dispose()라면 -- if문이 작동된다.
        // so 참조하던 객체가 Dispose되더라도, 참조변수는 null이 아니다. 
        // 실제로 Dispose된 뒤에 button2_Click하면 ""가 출력된다..
        // 작동하는 걸로 보아, Dispose되더라도, 메모리는 초기화만 될 뿐 아직 힙에 남아있는 모양이다.


        // os가 창을 제공하고, winform이 form클래스로 창을 래핑한다 
        // Form이 창을 관리해주는 것. 둘은 다른 개체. 
        // 창이 생성되면 Load이벤트가 발생한다. 창이 닫히면 Closed가 발생한다. 
        // 창이 닫혀도, Form 인스턴스는 변수로 계속 참조되고 있다. 
        // 즉, 하위폼이 Closed되도 하위폼이 래핑하던 창이 소멸될 뿐, 
        // 하위폼 자체는 소멸되지 않고 메인폼에서 계속 참조한다. 
        // 참조가 있는 한 GC는 개체를 소멸시키지 않는다. 
        // 따라서 

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Modelless_Dlg == null)
            {
                MessageBox.Show("모델리스 객체를 만듭니다.");
                // 모델리스는 show를 이용한다. 
                Modelless_Dlg = new Form2();
                Modelless_Dlg.Owner = this;
            }
            if(Modelless_Dlg.IsDisposed)
            {
                MessageBox.Show("모델리스 객체를 다시 넣습니다.");
                Modelless_Dlg = new Form2();
                Modelless_Dlg.Owner = this;
            }
            
            Modelless_Dlg.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Modelless_Dlg == null)
            {
                MessageBox.Show("모델리스 객체를 만듭니다.");
                Modelless_Dlg = new Form2();
                Modelless_Dlg.Owner = this;
            }
            Message = textBox2.Text;
            Modelless_Dlg.SetTextbox1(Message);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (Modelless_Dlg.GetTextbox1() == null)
            {
                MessageBox.Show("Modelless_Dlg.GetTextbox1() == null");
            }
            else { MessageBox.Show(Modelless_Dlg.GetTextbox1()); }

        }
    }
}
