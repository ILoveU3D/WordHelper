namespace 单词默写助手
{
    partial class Check
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            CCWin.SkinControl.Animation animation3 = new CCWin.SkinControl.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.skinAnimator1 = new CCWin.SkinControl.SkinAnimator(this.components);
            this.button2 = new CCWin.SkinControl.SkinButton();
            this.button3 = new CCWin.SkinControl.SkinButton();
            this.button4 = new CCWin.SkinControl.SkinButton();
            this.button1 = new CCWin.SkinControl.SkinButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.skinAnimator1.SetDecoration(this.groupBox1, CCWin.SkinControl.DecorationType.None);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 565);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "答案校对";
            this.groupBox1.Visible = false;
            // 
            // listView1
            // 
            this.skinAnimator1.SetDecoration(this.listView1, CCWin.SkinControl.DecorationType.None);
            this.listView1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(258, 535);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.skinAnimator1.SetDecoration(this.label1, CCWin.SkinControl.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "共计用时：";
            this.label1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView2);
            this.skinAnimator1.SetDecoration(this.groupBox2, CCWin.SkinControl.DecorationType.None);
            this.groupBox2.Location = new System.Drawing.Point(288, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 565);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "不会的单词";
            this.groupBox2.Visible = false;
            // 
            // listView2
            // 
            this.skinAnimator1.SetDecoration(this.listView2, CCWin.SkinControl.DecorationType.None);
            this.listView2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(6, 24);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(279, 535);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            this.listView2.DoubleClick += new System.EventHandler(this.listView2_DoubleClick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "newWord";
            this.saveFileDialog1.Filter = "Excel 文件(*.xlsx)|*.xlsx";
            // 
            // skinAnimator1
            // 
            this.skinAnimator1.AnimationType = CCWin.SkinControl.AnimationType.Leaf;
            this.skinAnimator1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 1F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.skinAnimator1.DefaultAnimation = animation3;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BaseColor = System.Drawing.Color.SeaGreen;
            this.button2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinAnimator1.SetDecoration(this.button2, CCWin.SkinControl.DecorationType.None);
            this.button2.DownBack = null;
            this.button2.DownBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.FadeGlow = false;
            this.button2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.GlowColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.IsDrawBorder = false;
            this.button2.IsDrawGlass = false;
            this.button2.Location = new System.Drawing.Point(18, 625);
            this.button2.MouseBack = null;
            this.button2.MouseBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.Name = "button2";
            this.button2.NormlBack = null;
            this.button2.Size = new System.Drawing.Size(130, 58);
            this.button2.TabIndex = 14;
            this.button2.Text = "重新开始";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BaseColor = System.Drawing.Color.SeaGreen;
            this.button3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinAnimator1.SetDecoration(this.button3, CCWin.SkinControl.DecorationType.None);
            this.button3.DownBack = null;
            this.button3.DownBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.button3.FadeGlow = false;
            this.button3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.GlowColor = System.Drawing.Color.DarkSeaGreen;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.IsDrawBorder = false;
            this.button3.IsDrawGlass = false;
            this.button3.Location = new System.Drawing.Point(158, 625);
            this.button3.MouseBack = null;
            this.button3.MouseBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.button3.Name = "button3";
            this.button3.NormlBack = null;
            this.button3.Size = new System.Drawing.Size(130, 58);
            this.button3.TabIndex = 15;
            this.button3.Text = "记录";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BaseColor = System.Drawing.Color.SeaGreen;
            this.button4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinAnimator1.SetDecoration(this.button4, CCWin.SkinControl.DecorationType.None);
            this.button4.DownBack = null;
            this.button4.DownBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.button4.FadeGlow = false;
            this.button4.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.GlowColor = System.Drawing.Color.DarkSeaGreen;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.IsDrawBorder = false;
            this.button4.IsDrawGlass = false;
            this.button4.Location = new System.Drawing.Point(301, 625);
            this.button4.MouseBack = null;
            this.button4.MouseBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.button4.Name = "button4";
            this.button4.NormlBack = null;
            this.button4.Size = new System.Drawing.Size(130, 58);
            this.button4.TabIndex = 16;
            this.button4.Text = "导出";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BaseColor = System.Drawing.Color.SeaGreen;
            this.button1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinAnimator1.SetDecoration(this.button1, CCWin.SkinControl.DecorationType.None);
            this.button1.DownBack = null;
            this.button1.DownBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.FadeGlow = false;
            this.button1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.GlowColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.IsDrawBorder = false;
            this.button1.IsDrawGlass = false;
            this.button1.Location = new System.Drawing.Point(443, 625);
            this.button1.MouseBack = null;
            this.button1.MouseBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Name = "button1";
            this.button1.NormlBack = null;
            this.button1.Size = new System.Drawing.Size(130, 58);
            this.button1.TabIndex = 17;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(591, 700);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.skinAnimator1.SetDecoration(this, CCWin.SkinControl.DecorationType.None);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Check";
            this.Text = "默写结束";
            this.Load += new System.EventHandler(this.Check_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private CCWin.SkinControl.SkinAnimator skinAnimator1;
        private CCWin.SkinControl.SkinButton button2;
        private CCWin.SkinControl.SkinButton button3;
        private CCWin.SkinControl.SkinButton button4;
        private CCWin.SkinControl.SkinButton button1;
    }
}