namespace 单词默写助手
{
    partial class WriteBand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriteBand));
            this.wordLabel = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Animator = new CCWin.SkinControl.SkinAnimator(this.components);
            this.wordItems = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Label();
            this.button1 = new CCWin.SkinControl.SkinButton();
            this.start = new CCWin.SkinControl.SkinButton();
            this.exit = new CCWin.SkinControl.SkinButton();
            this.practice = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // wordLabel
            // 
            this.wordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wordLabel.AutoSize = true;
            this.Animator.SetDecoration(this.wordLabel, CCWin.SkinControl.DecorationType.None);
            this.wordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wordLabel.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.wordLabel.ForeColor = System.Drawing.Color.White;
            this.wordLabel.Location = new System.Drawing.Point(24, 168);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(137, 40);
            this.wordLabel.TabIndex = 6;
            this.wordLabel.Text = "label1";
            this.wordLabel.Visible = false;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.Animator.SetDecoration(this.time, CCWin.SkinControl.DecorationType.None);
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(150, 9);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(52, 15);
            this.time.TabIndex = 7;
            this.time.Text = "用时：";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Animator
            // 
            this.Animator.AnimationType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.Animator.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.Animator.DefaultAnimation = animation3;
            this.Animator.TimeStep = 0.01F;
            // 
            // wordItems
            // 
            this.wordItems.AutoSize = true;
            this.Animator.SetDecoration(this.wordItems, CCWin.SkinControl.DecorationType.None);
            this.wordItems.ForeColor = System.Drawing.Color.White;
            this.wordItems.Location = new System.Drawing.Point(328, 9);
            this.wordItems.Name = "wordItems";
            this.wordItems.Size = new System.Drawing.Size(0, 15);
            this.wordItems.TabIndex = 9;
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.Animator.SetDecoration(this.answer, CCWin.SkinControl.DecorationType.None);
            this.answer.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.answer.ForeColor = System.Drawing.Color.White;
            this.answer.Location = new System.Drawing.Point(27, 353);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(82, 24);
            this.answer.TabIndex = 10;
            this.answer.Text = "answer";
            this.answer.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BaseColor = System.Drawing.Color.SeaGreen;
            this.button1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Animator.SetDecoration(this.button1, CCWin.SkinControl.DecorationType.None);
            this.button1.DownBack = null;
            this.button1.DownBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.FadeGlow = false;
            this.button1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.GlowColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.IsDrawBorder = false;
            this.button1.IsDrawGlass = false;
            this.button1.Location = new System.Drawing.Point(7, 401);
            this.button1.MouseBack = null;
            this.button1.MouseBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.button1.Name = "button1";
            this.button1.NormlBack = null;
            this.button1.Size = new System.Drawing.Size(130, 58);
            this.button1.TabIndex = 11;
            this.button1.Text = "会";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // start
            // 
            this.start.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.BaseColor = System.Drawing.Color.SeaGreen;
            this.start.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Animator.SetDecoration(this.start, CCWin.SkinControl.DecorationType.None);
            this.start.DownBack = null;
            this.start.DownBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.start.FadeGlow = false;
            this.start.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.GlowColor = System.Drawing.Color.DarkSeaGreen;
            this.start.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.start.IsDrawBorder = false;
            this.start.IsDrawGlass = false;
            this.start.Location = new System.Drawing.Point(143, 401);
            this.start.MouseBack = null;
            this.start.MouseBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.start.Name = "start";
            this.start.NormlBack = null;
            this.start.Size = new System.Drawing.Size(130, 58);
            this.start.TabIndex = 12;
            this.start.Text = "不会";
            this.start.UseVisualStyleBackColor = false;
            this.start.Visible = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // exit
            // 
            this.exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BaseColor = System.Drawing.Color.SeaGreen;
            this.exit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Animator.SetDecoration(this.exit, CCWin.SkinControl.DecorationType.None);
            this.exit.DownBack = null;
            this.exit.DownBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.exit.FadeGlow = false;
            this.exit.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.GlowColor = System.Drawing.Color.DarkSeaGreen;
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exit.IsDrawBorder = false;
            this.exit.IsDrawGlass = false;
            this.exit.Location = new System.Drawing.Point(277, 401);
            this.exit.MouseBack = null;
            this.exit.MouseBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.exit.Name = "exit";
            this.exit.NormlBack = null;
            this.exit.Size = new System.Drawing.Size(130, 58);
            this.exit.TabIndex = 13;
            this.exit.Text = "退出";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Visible = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // practice
            // 
            this.practice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.practice.BackColor = System.Drawing.Color.Transparent;
            this.practice.BaseColor = System.Drawing.Color.SeaGreen;
            this.practice.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Animator.SetDecoration(this.practice, CCWin.SkinControl.DecorationType.None);
            this.practice.DownBack = null;
            this.practice.DownBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.practice.FadeGlow = false;
            this.practice.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.practice.ForeColor = System.Drawing.Color.White;
            this.practice.GlowColor = System.Drawing.Color.DarkSeaGreen;
            this.practice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.practice.IsDrawBorder = false;
            this.practice.IsDrawGlass = false;
            this.practice.Location = new System.Drawing.Point(7, 401);
            this.practice.MouseBack = null;
            this.practice.MouseBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.practice.Name = "practice";
            this.practice.NormlBack = null;
            this.practice.Size = new System.Drawing.Size(266, 58);
            this.practice.TabIndex = 14;
            this.practice.Text = "过";
            this.practice.UseVisualStyleBackColor = false;
            this.practice.Visible = false;
            this.practice.Click += new System.EventHandler(this.start_Click);
            // 
            // WriteBand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(414, 466);
            this.ControlBox = false;
            this.ControlBoxActive = System.Drawing.Color.SeaGreen;
            this.ControlBoxDeactive = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.practice);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.start);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.wordItems);
            this.Controls.Add(this.time);
            this.Controls.Add(this.wordLabel);
            this.Animator.SetDecoration(this, CCWin.SkinControl.DecorationType.None);
            this.EffectBack = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "WriteBand";
            this.Text = "默写中";
            this.TitleColor = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.WriteBand_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WriteBand_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer timer;
        private CCWin.SkinControl.SkinAnimator Animator;
        private System.Windows.Forms.Label wordItems;
        private System.Windows.Forms.Label answer;
        private CCWin.SkinControl.SkinButton button1;
        private CCWin.SkinControl.SkinButton start;
        private CCWin.SkinControl.SkinButton exit;
        private CCWin.SkinControl.SkinButton practice;
    }
}