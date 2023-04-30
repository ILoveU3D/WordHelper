using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CCWin;

namespace 单词默写助手
{
    public partial class Welcome : CCSkinMain
    {
        string tableName = "";
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            //new LoadingScene().ShowDialog();
            Win32Anim.AnimateWindow(this.Handle, Win32Anim.defaultTime, Win32Anim.AW_CENTER | Win32Anim.AW_ACTIVATE | Win32Anim.AW_SLIDE);
            setSoundImg();
            Animator.Show(skinButton3);
            Animator.Show(skinButton4);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            tableName = Interaction.InputBox("请输入表名：","表名","sheet1");
            string message;
            if (!DataManager.dataManager.readData(this.openFileDialog.FileName, tableName,out message))
            {
                skinButton1.Text = "非法数据";
                skinButton1.ForeColor = Color.Red;
                this.skinToolTip.SetToolTip(skinButton1, message);
            }
            else
            {
                skinButton1.Text = "合法数据";
                skinButton1.ForeColor = Color.White;
                this.skinToolTip.SetToolTip(skinButton1, this.openFileDialog.FileName);
                Animator.Show(this.skinButton2);
            }
        }

        private void onFormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Win32Anim.AnimateWindow(this.Handle, Win32Anim.defaultTime, Win32Anim.AW_CENTER | Win32Anim.AW_HIDE | Win32Anim.AW_SLIDE);
            }
            catch (Exception)
            {

            }
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (this.skinButton3.Text == "语言")
            {
                MessageBox.Show("请选择语言", "语言未选择", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            DialogResult result = this.openFileDialog.ShowDialog();
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            SoundManager.startPlay();
            Win32Anim.AnimateWindow(this.Handle, Win32Anim.defaultTime, Win32Anim.AW_CENTER | Win32Anim.AW_HIDE | Win32Anim.AW_SLIDE);
            this.Hide();
            Factory.show();
            this.Dispose();
        }

        private void skinButton3_Click(object sender, EventArgs e)
        {
            if (this.skinFlowLayoutPanel1.Visible)
            {
                Animator.Hide(this.skinFlowLayoutPanel1);
            }
            else
            {
                Animator.Show(this.skinFlowLayoutPanel1);
            }
        }

        private void skinButton4_Click(object sender, EventArgs e)
        {
            SoundManager.changeMute();
            setSoundImg();
        }

        private void setSoundImg()
        {
            if (!SoundManager.IsMute)
                skinButton4.BackgroundImage = Properties.Resources.声音开;
            else
                skinButton4.BackgroundImage = Properties.Resources.声音关;
        }

        private void English_Click(object sender, EventArgs e)
        {
            string language = "English";
            DataManager.dataManager.Language = language;
            this.skinButton3.Text = language;
            Animator.Hide(this.skinFlowLayoutPanel1);
            Animator.Show(this.skinButton1);
        }

        private void Japanese_Click(object sender, EventArgs e)
        {
            string language = "日本語";
            DataManager.dataManager.Language = language;
            this.skinButton3.Text = language;
            Animator.Hide(this.skinFlowLayoutPanel1);
            Animator.Show(this.skinButton1);
        }  
    }
}
