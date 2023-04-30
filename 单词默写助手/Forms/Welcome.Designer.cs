namespace 单词默写助手
{
    partial class Welcome
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
            this.components = new System.ComponentModel.Container();
            CCWin.SkinControl.Animation animation1 = new CCWin.SkinControl.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.Animator = new CCWin.SkinControl.SkinAnimator(this.components);
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            this.skinFlowLayoutPanel1 = new CCWin.SkinControl.SkinFlowLayoutPanel();
            this.English = new CCWin.SkinControl.SkinButton();
            this.Japanese = new CCWin.SkinControl.SkinButton();
            this.skinButton4 = new CCWin.SkinControl.SkinButton();
            this.skinToolTip = new CCWin.SkinToolTip(this.components);
            this.skinFlowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Microsoft Excel 工作表(*.xlsx,*.xls)|*.xlsx;*.xls";
            this.openFileDialog.InitialDirectory = "./";
            this.openFileDialog.Title = "数据源";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // skinButton1
            // 
            this.skinButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.Color.SeaGreen;
            this.skinButton1.BorderColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Animator.SetDecoration(this.skinButton1, CCWin.SkinControl.DecorationType.None);
            this.skinButton1.DownBack = ((System.Drawing.Image)(resources.GetObject("skinButton1.DownBack")));
            this.skinButton1.DownBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.skinButton1.FadeGlow = false;
            this.skinButton1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton1.ForeColor = System.Drawing.Color.White;
            this.skinButton1.GlowColor = System.Drawing.Color.DarkSeaGreen;
            this.skinButton1.IsDrawBorder = false;
            this.skinButton1.IsDrawGlass = false;
            this.skinButton1.Location = new System.Drawing.Point(253, 381);
            this.skinButton1.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton1.MouseBack")));
            this.skinButton1.MouseBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton1.NormlBack")));
            this.skinButton1.Size = new System.Drawing.Size(203, 41);
            this.skinButton1.TabIndex = 4;
            this.skinButton1.Text = "选择数据源";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Visible = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinButton2
            // 
            this.skinButton2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.BaseColor = System.Drawing.Color.SeaGreen;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Animator.SetDecoration(this.skinButton2, CCWin.SkinControl.DecorationType.None);
            this.skinButton2.DownBack = ((System.Drawing.Image)(resources.GetObject("skinButton2.DownBack")));
            this.skinButton2.DownBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.skinButton2.FadeGlow = false;
            this.skinButton2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton2.ForeColor = System.Drawing.Color.Transparent;
            this.skinButton2.GlowColor = System.Drawing.Color.DarkSeaGreen;
            this.skinButton2.IsDrawBorder = false;
            this.skinButton2.IsDrawGlass = false;
            this.skinButton2.Location = new System.Drawing.Point(495, 381);
            this.skinButton2.MouseBack = ((System.Drawing.Image)(resources.GetObject("skinButton2.MouseBack")));
            this.skinButton2.MouseBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = ((System.Drawing.Image)(resources.GetObject("skinButton2.NormlBack")));
            this.skinButton2.Size = new System.Drawing.Size(203, 41);
            this.skinButton2.TabIndex = 5;
            this.skinButton2.Text = "开始默写";
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Visible = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // Animator
            // 
            this.Animator.AnimationType = CCWin.SkinControl.AnimationType.Transparent;
            this.Animator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.Animator.DefaultAnimation = animation1;
            this.Animator.MaxAnimationTime = 2500;
            // 
            // skinButton3
            // 
            this.skinButton3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.skinButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinButton3.BaseColor = System.Drawing.Color.SeaGreen;
            this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Animator.SetDecoration(this.skinButton3, CCWin.SkinControl.DecorationType.None);
            this.skinButton3.DownBack = null;
            this.skinButton3.DownBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.skinButton3.FadeGlow = false;
            this.skinButton3.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinButton3.ForeColor = System.Drawing.Color.White;
            this.skinButton3.GlowColor = System.Drawing.Color.DarkSeaGreen;
            this.skinButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.skinButton3.IsDrawBorder = false;
            this.skinButton3.IsDrawGlass = false;
            this.skinButton3.Location = new System.Drawing.Point(10, 381);
            this.skinButton3.MouseBack = null;
            this.skinButton3.MouseBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.NormlBack = null;
            this.skinButton3.Size = new System.Drawing.Size(203, 41);
            this.skinButton3.TabIndex = 8;
            this.skinButton3.Text = "语言";
            this.skinButton3.UseVisualStyleBackColor = false;
            this.skinButton3.Visible = false;
            this.skinButton3.Click += new System.EventHandler(this.skinButton3_Click);
            // 
            // skinFlowLayoutPanel1
            // 
            this.skinFlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinFlowLayoutPanel1.Controls.Add(this.English);
            this.skinFlowLayoutPanel1.Controls.Add(this.Japanese);
            this.skinFlowLayoutPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Animator.SetDecoration(this.skinFlowLayoutPanel1, CCWin.SkinControl.DecorationType.None);
            this.skinFlowLayoutPanel1.DownBack = null;
            this.skinFlowLayoutPanel1.Location = new System.Drawing.Point(7, 333);
            this.skinFlowLayoutPanel1.MouseBack = null;
            this.skinFlowLayoutPanel1.Name = "skinFlowLayoutPanel1";
            this.skinFlowLayoutPanel1.NormlBack = null;
            this.skinFlowLayoutPanel1.Size = new System.Drawing.Size(210, 51);
            this.skinFlowLayoutPanel1.TabIndex = 9;
            this.skinFlowLayoutPanel1.Visible = false;
            // 
            // English
            // 
            this.English.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.English.BackColor = System.Drawing.Color.Transparent;
            this.English.BaseColor = System.Drawing.Color.SeaGreen;
            this.English.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Animator.SetDecoration(this.English, CCWin.SkinControl.DecorationType.None);
            this.English.DownBack = null;
            this.English.DownBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.English.FadeGlow = false;
            this.English.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.English.ForeColor = System.Drawing.Color.White;
            this.English.GlowColor = System.Drawing.Color.DarkSeaGreen;
            this.English.IsDrawBorder = false;
            this.English.IsDrawGlass = false;
            this.English.Location = new System.Drawing.Point(3, 3);
            this.English.MouseBack = null;
            this.English.MouseBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.English.Name = "English";
            this.English.NormlBack = null;
            this.English.Size = new System.Drawing.Size(97, 41);
            this.English.TabIndex = 10;
            this.English.Text = "English";
            this.English.UseVisualStyleBackColor = false;
            this.English.Click += new System.EventHandler(this.English_Click);
            // 
            // Japanese
            // 
            this.Japanese.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Japanese.BackColor = System.Drawing.Color.Transparent;
            this.Japanese.BaseColor = System.Drawing.Color.SeaGreen;
            this.Japanese.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Animator.SetDecoration(this.Japanese, CCWin.SkinControl.DecorationType.None);
            this.Japanese.DownBack = null;
            this.Japanese.DownBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.Japanese.FadeGlow = false;
            this.Japanese.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Japanese.ForeColor = System.Drawing.Color.White;
            this.Japanese.GlowColor = System.Drawing.Color.DarkSeaGreen;
            this.Japanese.IsDrawBorder = false;
            this.Japanese.IsDrawGlass = false;
            this.Japanese.Location = new System.Drawing.Point(106, 3);
            this.Japanese.MouseBack = null;
            this.Japanese.MouseBaseColor = System.Drawing.Color.DarkSeaGreen;
            this.Japanese.Name = "Japanese";
            this.Japanese.NormlBack = null;
            this.Japanese.Size = new System.Drawing.Size(98, 41);
            this.Japanese.TabIndex = 9;
            this.Japanese.Text = "日本語";
            this.Japanese.UseVisualStyleBackColor = false;
            this.Japanese.Click += new System.EventHandler(this.Japanese_Click);
            // 
            // skinButton4
            // 
            this.skinButton4.BackColor = System.Drawing.Color.Transparent;
            this.skinButton4.BackgroundImage = global::单词默写助手.Properties.Resources.声音开;
            this.skinButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skinButton4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Animator.SetDecoration(this.skinButton4, CCWin.SkinControl.DecorationType.None);
            this.skinButton4.DownBack = null;
            this.skinButton4.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.skinButton4.Location = new System.Drawing.Point(704, 381);
            this.skinButton4.MouseBack = null;
            this.skinButton4.Name = "skinButton4";
            this.skinButton4.NormlBack = null;
            this.skinButton4.Size = new System.Drawing.Size(45, 41);
            this.skinButton4.TabIndex = 10;
            this.skinButton4.UseVisualStyleBackColor = false;
            this.skinButton4.Visible = false;
            this.skinButton4.Click += new System.EventHandler(this.skinButton4_Click);
            // 
            // skinToolTip
            // 
            this.skinToolTip.AutoPopDelay = 5000;
            this.skinToolTip.InitialDelay = 500;
            this.skinToolTip.IsBalloon = true;
            this.skinToolTip.OwnerDraw = true;
            this.skinToolTip.ReshowDelay = 800;
            this.skinToolTip.ShowAlways = true;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(756, 427);
            this.Controls.Add(this.skinButton4);
            this.Controls.Add(this.skinButton3);
            this.Controls.Add(this.skinButton2);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.skinFlowLayoutPanel1);
            this.Animator.SetDecoration(this, CCWin.SkinControl.DecorationType.None);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎使用";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.onFormClosing);
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.skinFlowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinAnimator Animator;
        private CCWin.SkinControl.SkinButton skinButton3;
        private CCWin.SkinControl.SkinFlowLayoutPanel skinFlowLayoutPanel1;
        private CCWin.SkinControl.SkinButton English;
        private CCWin.SkinControl.SkinButton Japanese;
        private CCWin.SkinToolTip skinToolTip;
        private CCWin.SkinControl.SkinButton skinButton4;
    }
}

