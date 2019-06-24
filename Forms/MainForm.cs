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
namespace AlphaBeatsUI
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            
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

        private void StartButton_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SlideForm slide = new SlideForm();
            slide.ShowDialog();
        }
    }
}
