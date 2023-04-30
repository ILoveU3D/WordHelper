namespace 单词默写助手
{
    partial class EnglishConfirm
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
            CCWin.SkinControl.Animation animation4 = new CCWin.SkinControl.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnglishConfirm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.foreignList = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chineseList = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.target = new CCWin.SkinControl.SkinTextBox();
            this.wordNum = new CCWin.SkinControl.SkinTextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.skinAnimator1 = new CCWin.SkinControl.SkinAnimator(this.components);
            this.cancel = new CCWin.SkinControl.SkinButton();
            this.start = new CCWin.SkinControl.SkinButton();
            this.skinToolTip = new CCWin.SkinToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.foreignList);
            this.skinAnimator1.SetDecoration(this.groupBox1, CCWin.SkinControl.DecorationType.None);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(19, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 564);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "English";
            this.groupBox1.Visible = false;
            // 
            // foreignList
            // 
            this.skinAnimator1.SetDecoration(this.foreignList, CCWin.SkinControl.DecorationType.None);
            this.foreignList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foreignList.HideSelection = false;
            this.foreignList.Location = new System.Drawing.Point(3, 21);
            this.foreignList.Name = "foreignList";
            this.foreignList.Size = new System.Drawing.Size(238, 540);
            this.foreignList.TabIndex = 0;
            this.foreignList.UseCompatibleStateImageBehavior = false;
            this.foreignList.View = System.Windows.Forms.View.List;
            this.foreignList.Click += new System.EventHandler(this.selectWord);
            this.foreignList.Leave += new System.EventHandler(this.cancelAll);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.chineseList);
            this.skinAnimator1.SetDecoration(this.groupBox2, CCWin.SkinControl.DecorationType.None);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(269, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 564);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "中文";
            this.groupBox2.Visible = false;
            // 
            // chineseList
            // 
            this.skinAnimator1.SetDecoration(this.chineseList, CCWin.SkinControl.DecorationType.None);
            this.chineseList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chineseList.HideSelection = false;
            this.chineseList.Location = new System.Drawing.Point(3, 21);
            this.chineseList.Name = "chineseList";
            this.chineseList.Size = new System.Drawing.Size(238, 540);
            this.chineseList.TabIndex = 0;
            this.chineseList.UseCompatibleStateImageBehavior = false;
            this.chineseList.View = System.Windows.Forms.View.List;
            this.chineseList.Click += new System.EventHandler(this.selectWord);
            this.chineseList.Leave += new System.EventHandler(this.cancelAll);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.target);
            this.groupBox3.Controls.Add(this.wordNum);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.skinAnimator1.SetDecoration(this.groupBox3, CCWin.SkinControl.DecorationType.None);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(25, 647);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 152);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "默写设置";
            this.groupBox3.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.skinAnimator1.SetDecoration(this.checkBox1, CCWin.SkinControl.DecorationType.None);
            this.checkBox1.Location = new System.Drawing.Point(13, 108);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "练习模式";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // target
            // 
            this.target.BackColor = System.Drawing.Color.Transparent;
            this.skinAnimator1.SetDecoration(this.target, CCWin.SkinControl.DecorationType.None);
            this.target.DownBack = null;
            this.target.Icon = global::单词默写助手.Properties.Resources.bgimg_07;
            this.target.IconIsButton = false;
            this.target.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.target.IsPasswordChat = '\0';
            this.target.IsSystemPasswordChar = false;
            this.target.Lines = new string[0];
            this.target.Location = new System.Drawing.Point(148, 22);
            this.target.Margin = new System.Windows.Forms.Padding(0);
            this.target.MaxLength = 32767;
            this.target.MinimumSize = new System.Drawing.Size(28, 28);
            this.target.MouseBack = null;
            this.target.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.target.Multiline = false;
            this.target.Name = "target";
            this.target.NormlBack = null;
            this.target.Padding = new System.Windows.Forms.Padding(5, 5, 51, 5);
            this.target.ReadOnly = false;
            this.target.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.target.Size = new System.Drawing.Size(129, 28);
            // 
            // 
            // 
            this.target.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.target.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.target.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.target.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.target.SkinTxt.Name = "BaseText";
            this.target.SkinTxt.Size = new System.Drawing.Size(73, 22);
            this.target.SkinTxt.TabIndex = 0;
            this.target.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.target.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.target.SkinTxt.WaterText = "目标";
            this.target.TabIndex = 6;
            this.target.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.target.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.target.WaterText = "目标";
            this.target.WordWrap = true;
            // 
            // wordNum
            // 
            this.wordNum.BackColor = System.Drawing.Color.Transparent;
            this.skinAnimator1.SetDecoration(this.wordNum, CCWin.SkinControl.DecorationType.None);
            this.wordNum.DownBack = null;
            this.wordNum.Icon = global::单词默写助手.Properties.Resources.bgimg_03;
            this.wordNum.IconIsButton = false;
            this.wordNum.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.wordNum.IsPasswordChat = '\0';
            this.wordNum.IsSystemPasswordChar = false;
            this.wordNum.Lines = new string[0];
            this.wordNum.Location = new System.Drawing.Point(13, 22);
            this.wordNum.Margin = new System.Windows.Forms.Padding(0);
            this.wordNum.MaxLength = 32767;
            this.wordNum.MinimumSize = new System.Drawing.Size(28, 28);
            this.wordNum.MouseBack = null;
            this.wordNum.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.wordNum.Multiline = false;
            this.wordNum.Name = "wordNum";
            this.wordNum.NormlBack = null;
            this.wordNum.Padding = new System.Windows.Forms.Padding(5, 5, 51, 5);
            this.wordNum.ReadOnly = false;
            this.wordNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.wordNum.Size = new System.Drawing.Size(129, 28);
            // 
            // 
            // 
            this.wordNum.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wordNum.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wordNum.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.wordNum.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.wordNum.SkinTxt.Name = "BaseText";
            this.wordNum.SkinTxt.Size = new System.Drawing.Size(73, 22);
            this.wordNum.SkinTxt.TabIndex = 0;
            this.wordNum.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wordNum.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.wordNum.SkinTxt.WaterText = "默写词数";
            this.wordNum.TabIndex = 5;
            this.wordNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wordNum.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.wordNum.WaterText = "默写词数";
            this.wordNum.WordWrap = true;
            this.wordNum.Click += new System.EventHandler(this.wordNum_Paint);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.skinAnimator1.SetDecoration(this.radioButton2, CCWin.SkinControl.DecorationType.None);
            this.radioButton2.ForeColor = System.Drawing.Color.Black;
            this.radioButton2.Location = new System.Drawing.Point(148, 68);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(129, 19);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "English→中文";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.skinAnimator1.SetDecoration(this.radioButton1, CCWin.SkinControl.DecorationType.None);
            this.radioButton1.ForeColor = System.Drawing.Color.Black;
            this.radioButton1.Location = new System.Drawing.Point(13, 68);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(129, 19);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "中文→English";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.skinAnimator1.SetDecoration(this.label3, CCWin.SkinControl.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 48);
            this.label3.TabIndex = 10;
            this.label3.Text = "English";
            this.label3.Visible = false;
            // 
            // skinAnimator1
            // 
            this.skinAnimator1.AnimationType = CCWin.SkinControl.AnimationType.Leaf;
            this.skinAnimator1.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 1F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.skinAnimator1.DefaultAnimation = animation4;
            this.skinAnimator1.MaxAnimationTime = 500;
            // 
            // cancel
            // 
            this.cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancel.BackColor = System.Drawing.Color.Transparent;
            this.cancel.BaseColor = System.Drawing.Color.SeaGreen;
            this.cancel.BorderColor = System.Drawing.Color.Transparent;
            this.cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinAnimator1.SetDecoration(this.cancel, CCWin.SkinControl.DecorationType.None);
            this.cancel.DownBack = null;
            this.cancel.DownBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.cancel.FadeGlow = false;
            this.cancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cancel.GlowColor = System.Drawing.Color.DarkSeaGreen;
            this.cancel.InnerBorderColor = System.Drawing.Color.Transparent;
            this.cancel.IsDrawBorder = false;
            this.cancel.IsDrawGlass = false;
            this.cancel.Location = new System.Drawing.Point(321, 703);
            this.cancel.MouseBack = null;
            this.cancel.MouseBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.cancel.Name = "cancel";
            this.cancel.NormlBack = null;
            this.cancel.Size = new System.Drawing.Size(192, 41);
            this.cancel.TabIndex = 12;
            this.cancel.Text = "返回";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Visible = false;
            this.cancel.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // start
            // 
            this.start.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.BaseColor = System.Drawing.Color.SeaGreen;
            this.start.BorderColor = System.Drawing.Color.Transparent;
            this.start.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinAnimator1.SetDecoration(this.start, CCWin.SkinControl.DecorationType.None);
            this.start.DownBack = null;
            this.start.DownBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.start.FadeGlow = false;
            this.start.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.start.GlowColor = System.Drawing.Color.DarkSeaGreen;
            this.start.InnerBorderColor = System.Drawing.Color.Transparent;
            this.start.IsDrawBorder = false;
            this.start.IsDrawGlass = false;
            this.start.Location = new System.Drawing.Point(321, 656);
            this.start.MouseBack = null;
            this.start.MouseBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.start.Name = "start";
            this.start.NormlBack = null;
            this.start.Size = new System.Drawing.Size(192, 41);
            this.start.TabIndex = 11;
            this.start.Text = "开始";
            this.start.UseVisualStyleBackColor = false;
            this.start.Visible = false;
            this.start.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinToolTip
            // 
            this.skinToolTip.AutoPopDelay = 5000;
            this.skinToolTip.InitialDelay = 0;
            this.skinToolTip.IsBalloon = true;
            this.skinToolTip.OwnerDraw = true;
            this.skinToolTip.ReshowDelay = 0;
            this.skinToolTip.ShowAlways = true;
            this.skinToolTip.ToolTipTitle = "总词数";
            // 
            // EnglishConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(535, 808);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.start);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.skinAnimator1.SetDecoration(this, CCWin.SkinControl.DecorationType.None);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MdiBackColor = System.Drawing.Color.Transparent;
            this.Name = "EnglishConfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "准备开始";
            this.Load += new System.EventHandler(this.Confirm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private CCWin.SkinControl.SkinButton start;
        private CCWin.SkinControl.SkinButton cancel;
        private System.Windows.Forms.ListView foreignList;
        private System.Windows.Forms.ListView chineseList;
        private CCWin.SkinControl.SkinAnimator skinAnimator1;
        private CCWin.SkinControl.SkinTextBox wordNum;
        private CCWin.SkinControl.SkinTextBox target;
        private CCWin.SkinToolTip skinToolTip;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}