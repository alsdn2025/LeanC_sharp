using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Diagnostics; // Process class를 사용

namespace Adobe_bok_dol
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {// 굳이 Dialog를 이용할 필요는 없다.
         // Dialog는 어떤 데이터를 읽고 어디에 데이터를 저장할지
         // 사용자에게 보여주는 용도인데, 
         // 오히려 이 프로그램에선 내부적으로 알아서 읽고 생성하는 방향성이 사용자편의성면에서 더 낫다. 

            /////////////////////////////////////////
            // 프로세스를 먼저 kill 한다.
            // Adobe Genuine Software integrity Service
            // Adobe Genuine Software Service

            // Process.GetProcessesByName함수가 특정 이름을 가진 모든 프로세스 리소스에 연결한다.
 
            Process[] Pros = Process.GetProcesses();
            IEnumerable<Process> Clone = Pros.OrderBy(p=>p.ProcessName);
            // Adobe application
            Process[] App = Process.GetProcessesByName("AdobeGCClient");
            // Adobe Genuine Software Service
            Process[] Service = Process.GetProcessesByName("AGMService");
            // Adobe Genuine Software Intergrity Service
            Process[] Intergrity_Service = Process.GetProcessesByName("AGSService");
            


            foreach (Process Process_item in App)
            {
                Process_item.Kill();
            }
            foreach (Process Process_item in Intergrity_Service)
            {
                Process_item.Kill();
            }
            foreach (Process Process_item in Service)
            {
                Process_item.Kill();
            }
            
            // 이 짧은 코드가 과연 실행이 잘 될까?
            
            //////////////////////////////////////

            // 파일스트림을 만든다. 
            // 이 파일스트림은 For_Reading.txt 파일을 연결하며, FileMode는 Open, 읽기 전용이다. 
            //FileStream fs = new FileStream(@"D:\C#proj\SBCS\Adobe_bok_dol\bin\Debug\For_Reading.txt", FileMode.Open, FileAccess.Read);    
            // 폴더의 주소가 바뀔 경우를 대비하여 고정주소 대신 Application.StartupPath를 이용했다.
            FileStream fs = new FileStream(string.Format("{0}\\For_Reading.txt",Application.StartupPath), FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            // 읽은 텍스트를string[]에 저장
            string[] File_Name;
            File_Name = (sr.ReadToEnd()).Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            //,StringSplitOptions.RemoveEmptyEntries 는 공백인 string""을 없애줌. 
            // 여기선 없어도 되지만 알고있는게 좋겠다. 


            sr.Close();
            fs.Close();
            

            /////////// 읽어서 파일이름을 File_Name에 저장했으니 
            /////////// 이제 실제 파일을 만들자.

            StringBuilder sb = new StringBuilder();

            foreach (var fake_FileName in File_Name)
            {   // sb에 경로를 포함한 파일이름을 넣고, 파일스트림(fs)로 해당 파일을 만든다. 
                // 그 뒤 sb와 fs를 cleart한다. 
                string test = fake_FileName;
                sb.AppendFormat(@"C:\Program Files (x86)\Common Files\Adobe\AdobeGCClient\{0}", fake_FileName);  // 아래 두 개를 합친 것, Format 메서드를 이용. 
                //sb.Append(@"C:\Program Files (x86)\Common Files\Adobe\AdobeGCClient\");
                //sb.Append(fake_FileName);

                sb.Remove(sb.Length - 1, 1); // fake_FileName에 자동으로 붙는 마지막 \r 을 제거
                fs = new FileStream(sb.ToString(), FileMode.Create);
                fs.Close();
                sb.Clear();
            }


            MessageBox.Show("Done.");
            button1.Enabled = false;
        }
    }
}
