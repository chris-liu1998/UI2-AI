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
            string mysql = "select * from gamePath";                                                                     //查询表中是否已有数据
            MySqlCommand mysqlCommand = new MySqlCommand(mysql, conn);                   //操作命令
            MySqlDataReader reader = null;                                                                                   //查询结果读取器
            reader = mysqlCommand.ExecuteReader();                                                                  //执行查询，将结果返回到读取器

            if (reader.Read())                                                                                                            //代表查询有数据
            {
                FileInput.Text = reader[0].ToString();                                                                        //将数据库中的数据赋给路径显示框
            }
        }
    }
}
