using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22Control00_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
            checkBox3.Checked = true;

        }

        // 체크박스 1은 사용자가 건드리지 못하도록 Enable = false.
        // 체크박스 2,3가 모두 체크되면 박스1을 Checked.
        // 둘 중 하나가 체크되면 박스 1을 Intermidiate
        // 둘 다 체크되지 않으면 박스 1을 Unchecked한다. 
        // 체크/언체크 에선 checkBox.Checked 속성을 이용하고
        // 체크/중립/언체크 를 이용할땐 checkBox.CheckState를 이용한다. 
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked == true && checkBox3.Checked == true)
            {   checkBox1.CheckState = CheckState.Checked; }
            else if(checkBox2.Checked == true || checkBox3.Checked == true)
            {   checkBox1.CheckState = CheckState.Indeterminate; }
            else 
            { checkBox1.CheckState = CheckState.Unchecked; }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true && checkBox3.Checked == true)
            { checkBox1.CheckState = CheckState.Checked; }
            else if (checkBox2.Checked == true || checkBox3.Checked == true)
            { checkBox1.CheckState = CheckState.Indeterminate; }
            else
            { checkBox1.CheckState = CheckState.Unchecked; }
        }

        // CheckBox.CheckState가 intermidiate가 되어도
        // CheckBox.Checked는 true가 된다!

        // CheckedChanged 와 CheckStateChanged도 다르다.
        // CheckedChanged는 말 그대로 Checked 가 바뀌면 발생
        // CheckStateChanged는 CheckState가 바뀌면 발생한다.
        // 이들의 차이점을 알고 있어야 한다.

        // 아래 메서드는 Checked가 바뀌면 발생하는 CheckedChanged 이나,
        // 함수의 내용이 CheckState가 Checked일때 실행되는 if문이므로
        // 결국 아무런 기능을 하지 못한다.
        // CheckedChanged는 CheckState가 Indeterminate 로 바뀔 때(즉 Checked 가 true로 바뀔 때) 호출되기 때문에. 
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.CheckState == CheckState.Checked)
            {
                MessageBox.Show("checkBox1_CheckedChanged?");
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                MessageBox.Show("checkBox1_CheckStateChanged?");
            }
        }

        // Enter는 그 컨트롤을 클릭했을 때, 즉
        // 다른 컨트롤을 만지마다 해당 컨트롤을 포커싱했을때 발생하는 이벤트이다. 
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
            MessageBox.Show("groupBox1_Enter");
            
        }

        RadioButton SelectRadioButton;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // 라디오버튼 참조변수에 sender, 즉 이 이벤트를 발생시키는 오브젝트인 라디오버튼1을 넣어준다. 
            SelectRadioButton = (RadioButton)sender;
        }


        // if문이 작동했다
        // 즉, 위의 함수에서 object sender는 radiobutton1이다.
        // 밑의 함수의 object는? button2겠지. 
        // object의 정체를 이제야 알겠다. 
        private void button2_Click(object sender, EventArgs e)
        {
            if(SelectRadioButton == radioButton1)
            {
                
                MessageBox.Show("radioButton1 is Selected");
            }
        }
    }
}
