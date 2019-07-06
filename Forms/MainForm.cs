using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace AlphaBeatsUI
{
    public partial class MainForm : MetroForm
    {
        
        public MainForm()
        {
            InitializeComponent();
            //通过database类获取数据库连接
            //conn = database.dbcon.getConnection();
            
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            SlideForm slide = new SlideForm();
            slide.ShowDialog();
        }


        //给窗口加阴影
        private const int CS_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }

        //开始训练按钮
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (FileInput.Text == "" || FileInput.Text == "选择游戏")
            {
                MessageBox.Show("The path of game is error!");
            }
           

            
            string[] strArr = new string[2];
            string sArguments = @"start.py"; //调用的python的文件名字
            strArr[0] = "2";
            strArr[1] = "3";
            RunPythonScript(sArguments, "-u", strArr);
        }


        //选取游戏
        private void FileInput_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "exe文件(*.exe)|*.exe";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileInput.Text = this.openFileDialog1.FileName;
            }
        }



        //执行Python脚本
        public static void RunPythonScript(string sArgName, string args = "", params string[] teps)
        {
            Process p = new Process();
            // 获得python文件的绝对路径（将文件放在c#的debug文件夹中可以这样操作）
            //string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase + sArgName;
            string path = @"E:\暑期实训\19暑期实训\项目\newAI\OpenAI\demo\" + sArgName;
            //如果配了python.exe，直接写"python.exe",否则使用绝对路径
            p.StartInfo.FileName = @"python.exe";
            string sArguments = path;
            foreach (string sigstr in teps)
            {
                sArguments += " " + sigstr;//传递参数
            }

            p.StartInfo.Arguments = sArguments;

            p.StartInfo.UseShellExecute = false;

            p.StartInfo.RedirectStandardOutput = true;

            p.StartInfo.RedirectStandardInput = true;

            p.StartInfo.RedirectStandardError = true;

            p.StartInfo.CreateNoWindow = true;

            p.Start();
            p.BeginOutputReadLine();

            p.OutputDataReceived += new DataReceivedEventHandler(p_OutputDataReceived);
            Console.ReadLine();
            p.WaitForExit();
        }
        //输出打印的信息
        static void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Data))
            {
                AppendText(e.Data + Environment.NewLine);
            }
        }
        public delegate void AppendTextCallback(string text);
        public static void AppendText(string text)
        {
            Console.WriteLine(text);     //此处在控制台输出.py文件print的结果

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}