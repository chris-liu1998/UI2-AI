namespace AlphaBeatsUI
{
    partial class Slide
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Slide));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.timerSlide = new System.Windows.Forms.Timer(this.components);
            this.label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 253);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(640, 253);
            this.panel2.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(207, 15);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(222, 222);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // timerSlide
            // 
            this.timerSlide.Enabled = true;
            this.timerSlide.Interval = 10;
            this.timerSlide.Tick += new System.EventHandler(this.TimerSlide_Tick);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Pump Demi Bold LET", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(26, 84);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(595, 111);
            this.label.TabIndex = 0;
            this.label.Text = "Alpha  Beasts";
            // 
            // Slide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Slide";
            this.Size = new System.Drawing.Size(640, 506);
            this.Load += new System.EventHandler(this.Slide_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timerSlide;
        private System.Windows.Forms.Label label;
    }
}
