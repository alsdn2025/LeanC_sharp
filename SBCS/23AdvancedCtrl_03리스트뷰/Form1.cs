using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23AdvancedCtrl_03리스트뷰
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int C_ = int.Parse(textBox1.Text);
            int C_Plus = int.Parse(textBox2.Text);
            int C_Sharp = int.Parse(textBox3.Text);
            int Total = C_ + C_Plus + C_Sharp;
            float Average = Total / 3.0f;

            // new ListViewItem - 안에 new string[] 으로 배열 항목을 채워넣어 ListVieWitem을 만들고, 
            // 만든 아이템을 Add로 listView1.Items에 넣는다.
            // new ListViewItem에 처음 넣어지는 string C_은 아이템이,나머지 뒤의 strinf들은 서브아이템이 된다. 
            listView1.Items.Add(new ListViewItem(new string[]{
                C_.ToString(),
                C_Plus.ToString(),
                C_Sharp.ToString(),
                Total.ToString(),
                Average.ToString("F1")
            }));

            // insert로 삽입 가능. 그러나
            // listView는 링크트리스트 형태로, 데이터가 쭉 이어져야 한다. 
            // 즉, 데이터가 1,2,3 있는데 10번째에 넣어라! 는 안됨.
            listView1.Items.Insert(3, new ListViewItem( new string[] { C_.ToString(), "fff", "ggg" }));

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int C_ = int.Parse(textBox1.Text);
            int C_Plus = int.Parse(textBox2.Text);
            int C_Sharp = int.Parse(textBox3.Text);
            int Total = C_ + C_Plus + C_Sharp;
            float Average = Total / 3.0f;


            // 아래 두 코드는 같은 기능을 한다.
            // 즉, 아이템을 생성함과 동시에, 그 아이템은 
            // 서브아이템[0]가 된다.
            // 거기에 서브아이템을 추가하면 [1]부터 추가된다. 
            // 즉, 아이템을 만들고, 처음 추가하는 서브아이템은
            // 서브아이템[0] 가 아니라 서브아이템[1] 이다.
            listView1.SelectedItems[0].SubItems[0].Text = textBox1.Text;
            listView1.SelectedItems[0].Text = textBox2.Text;
            //////////////////////////////////////

            listView1.SelectedItems[0].SubItems[1].Text = textBox2.Text;
            listView1.SelectedItems[0].SubItems[2].Text = textBox3.Text;
            listView1.SelectedItems[0].SubItems[3].Text = Total.ToString();
            listView1.SelectedItems[0].SubItems[4].Text = Average.ToString();

            // 만약 내가 아이템을 만들 때 서브아이템을 3개 만들었다면, 서브아이템은 4개다.
            // 그런데 서브아이템[4](즉, 5번째) 에 텍스트를 넣으려고 하면 오류가 난다.
            // 서브 아이템은 무한한 빈 칸이 아니라, 시스템에서 할당하는 하나 하나의 데이터 메모리라는 걸 명심하자. 

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ↓ 첫 번째 아이템을 삭제.
            //listView1.Items.RemoveAt(0);
            // ↓ 현재 선택된 아이템을 삭제
            // (여러개 선택시 선택된 아이템들 중 첫 번째만 삭제)
            listView1.SelectedItems[0].Remove();
            // ↓ 리스트의 모든 아이템 삭제
            //listView1.Items.Clear();
        }
    }
}
