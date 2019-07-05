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
        //数据库连接对象
        public static MySqlConnection conn = null;

        public MainForm()
        {
            InitializeComponent();
            //通过database类获取数据库连接
            conn = database.dbcon.getConnection();
            loadGamePath();
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
            else
            {
                if (conn == null)
                {
                    MessageBox.Show("Connect error!");
                }
                else
                {
                    //
                    //注意：下面命令中的world.gamePath含义为：
                    //world:数据库名称           gamePath为表名
                    //
                    string mysql1 = "create table if not exists world.gamePath( gamePath varchar(50) );";  //如果不存在则创建
                    string mysql2 = "delete  from gamePath where true";                                                     //此表保存游戏路径，因此一次只允许保留一条数据
                    string mysql3 = "insert into gamePath values(@gamePath)";                                          //插入游戏路径
                    MySqlCommand mysql1Command = new MySqlCommand(mysql1, conn);                   //操作命令
                    MySqlCommand mysql2Command = new MySqlCommand(mysql2, conn);
                    MySqlCommand mysql3Command = new MySqlCommand(mysql3, conn);

                    mysql3Command.Parameters.AddWithValue("@gamePath", FileInput.Text);                  //插入命令参数

                    mysql1Command.ExecuteNonQuery();                                                                              //保存操作
                    mysql2Command.ExecuteNonQuery();
                    mysql3Command.ExecuteNonQuery();
                }
            }

            //ScriptRuntime pyRuntime = Python.CreateRuntime();
            //dynamic obj = pyRuntime.UseFile("E:\\暑期实训\\19暑期实训\\Try1\\test.py");                      //打开python文件
            //obj.test(FileInput.Text);

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


        //初始加载已保存游戏路径函数
        private void loadGamePath()
        {
            string mysql = "select * from gamePath";                                                           //查询表中是否已有数据
            MySqlCommand mysqlCommand = new MySqlCommand(mysql, conn);         //操作命令
            MySqlDataReader reader = null;                                                                         //查询结果读取器
            reader = mysqlCommand.ExecuteReader();                                                        //执行查询，将结果返回到读取器

            if (reader.Read())                                                                                                  //代表查询有数据
            {
                FileInput.Text = reader[0].ToString();                                                               //将数据库中的数据赋给路径显示框
            }
            reader.Close();
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