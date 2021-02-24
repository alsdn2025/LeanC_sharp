using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // 파일입출력 namespace
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24대화상자_02공용대화상자
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Number = 12;
            string Message = "저장저장저장";
            Stream myStream; // 파일 스트림을 하나 만든다. 
            saveFileDialog1.DefaultExt = "dat"; // save파일 기본확장자에 dat을 설정한다. 

            // "데이터(*.dat)은 명시.
            // 실제 필터는  |*.dat 부분.
            saveFileDialog1.Filter = "데이터(*.dat)|*.dat";
            //saveFileDialog1.Filter = "데이터(*.dat)|*.dat|워드(*.doc)|*.doc"; 
           // 일케도 가능

            // 사용자가 대화상자에서 확인을 클릭하면
            // showDialog()는 DialogResult.OK를 리턴한다.
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // saveFileDialog.OpenFile은 자동으로 파일스트림을 만들어 리턴해준다. 이 스트림은 읽기/쓰기 둘다 가능.
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // using을 씀으로서, 바이너리를 쓰고 자동으로 close한다. 
                    // BinaryWriter에 myStream을 연결해준다.
                    using (BinaryWriter bw = new BinaryWriter(myStream))
                    {
                        bw.Write(Number);
                        bw.Write(Message);
                    }
                }
            }
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {// OpneFile도 SaveFile과 유사하다. 

            Stream myStream;
            openFileDialog1.Filter = "데이터(*dat)|*.dat";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // openFileDialog.OpenFile 또한 자동으로 파일스트림을 만들어 리턴해준다. 이 스트림은 읽기 전용이다. 
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    // 이번엔 값을 읽어야 하니 Reader를 사용한다. 
                    using (BinaryReader br = new BinaryReader(myStream))
                    {
                        MessageBox.Show(br.ReadInt32().ToString());
                        MessageBox.Show(br.ReadString());

                        // 만약 .txt파일의 확장자만 .dat으로 바꾼
                        // text.dat 파일을 열 경우, 
                        // 열리긴 하지만, 값을 제대로 읽지 못한다.
                        // br이 바이너리 파일 읽는뇨속이라!

                    }
                }
            }
        }
    }
}
