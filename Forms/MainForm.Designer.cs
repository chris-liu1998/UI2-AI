namespace AlphaBeatsUI
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FileInput = new LollipopFileInput();
            this.Label = new LollipopLabel();
            this.StartButton = new LollipopFlatButton();
            this.panel = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ellipseControlMain = new AlphaBeatsUI.EllipseControl();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FileInput
            // 
            this.FileInput.BackColor = System.Drawing.Color.White;
            this.FileInput.Filter = "All Files (*.*)|*.*";
            this.FileInput.FocusedColor = "#508ef5";
            this.FileInput.FontColor = "#999999";
            this.FileInput.IsEnabled = true;
            this.FileInput.Location = new System.Drawing.Point(57, 159);
            this.FileInput.Margin = new System.Windows.Forms.Padding(4);
            this.FileInput.MaxLength = 32767;
            this.FileInput.Name = "FileInput";
            this.FileInput.ReadOnly = false;
            this.FileInput.Size = new System.Drawing.Size(400, 24);
            this.FileInput.TabIndex = 0;
            this.FileInput.Text = "选择游戏";
            this.FileInput.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.FileInput.UseSystemPasswordChar = false;
            this.FileInput.Click += new System.EventHandler(this.FileInput_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.BackColor = System.Drawing.Color.Transparent;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Label.Location = new System.Drawing.Point(53, 120);
            this.Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(162, 20);
            this.Label.TabIndex = 1;
            this.Label.Text = "选择要进行的游戏：";
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartButton.FontColor = "#508ef5";
            this.StartButton.Location = new System.Drawing.Point(0, 0);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(191, 51);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "开始游戏";
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.StartButton);
            this.panel.Location = new System.Drawing.Point(155, 525);
            this.panel.Margin = new System.Windows.Forms.Padding(4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(190, 51);
            this.panel.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // ellipseControlMain
            // 
            this.ellipseControlMain.CornerRadius = 10;
            this.ellipseControlMain.TargetControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 641);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.FileInput);
            this.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Opacity = 0.95D;
            this.Padding = new System.Windows.Forms.Padding(27, 75, 27, 25);
            this.Text = "AlphaAI";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LollipopFileInput FileInput;
        private LollipopLabel Label;
        private EllipseControl ellipseControlMain;
        private LollipopFlatButton StartButton;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

