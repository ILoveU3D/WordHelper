using CCWin;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using 单词默写助手.WritingController;

namespace 单词默写助手
{
    public partial class EnglishConfirm : CCSkinMain
    {
        public EnglishConfirm()
        {
            InitializeComponent();
        }

        private void Confirm_Load(object sender, EventArgs e)
        {
            initView(this.foreignList, true);
            initView(this.chineseList, false);
            Win32Anim.AnimateWindow(this.Handle, Win32Anim.defaultTime, Win32Anim.AW_CENTER | Win32Anim.AW_ACTIVATE | Win32Anim.AW_SLIDE);
            skinToolTip.SetToolTip(wordNum, Convert.ToString(WordSet.wordSet.Set.Length));
            skinAnimator1.ShowSync(this.label3);
            skinAnimator1.ShowSync(this.groupBox1);
            skinAnimator1.ShowSync(this.groupBox2);
            skinAnimator1.ShowSync(this.groupBox3);
            skinAnimator1.ShowSync(this.start);
            skinAnimator1.ShowSync(this.cancel);
        }
        private void initView(ListView listView, bool isForeign)
        {
            listView.Columns.Add("词汇", listView.Size.Width);
            foreach (EnglishWord word in WordSet.wordSet.Set)
            {
                if (listView.Items.Count >= 150)
                {
                    break;
                }
                if (isForeign)
                {
                    listView.Items.Add(word.Foreign);
                }
                else
                {
                    listView.Items.Add(word.Chinese);
                }
            }
        }
        private void skinButton1_Click(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked)
            {
                WriteManager.writeManager = new Chinese2Foreign();
            }
            else
            {
                WriteManager.writeManager = new Foreign2Chinese();
            }
            if (!WriteManager.writeManager.setNumber(this.wordNum.Text))
            {
                MessageBox.Show("请输入正确的字符", "输入错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PracticeManager.practiceManager = new PracticeManager();
                PracticeManager.practiceManager.IsPractise = checkBox1.Checked;
                this.Hide();
                new WriteBand().ShowDialog();
                this.Dispose();
            }
        }

        private void skinButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Welcome().ShowDialog();
            this.Dispose();
        }

        private void wordNum_Paint(object sender, EventArgs e)
        {
            wordNum.Text = Convert.ToString(WordSet.wordSet.Set.Length);
        }

        private void selectWord(object sender, EventArgs e)
        {
            ListView objectList = null, thisList = null;
            if(foreignList.SelectedItems.Count > 0)
            {
                objectList = chineseList;
                thisList = foreignList;
            }
            else
            {
                objectList = foreignList;
                thisList = chineseList;
            }
            foreach (ListViewItem item in objectList.Items)
            {
                item.BackColor = Color.Transparent;
            }
            foreach (ListViewItem item in thisList.SelectedItems)
            {
                objectList.Items[item.Index].BackColor = Color.Wheat;
            }
        }

        private void cancelAll(object sender, EventArgs e)
        {
            foreach (ListViewItem item in foreignList.Items)
            {
                item.BackColor = Color.Transparent;
                item.Selected = false;
            }
            foreach (ListViewItem item in chineseList.Items)
            {
                item.BackColor = Color.Transparent;
                item.Selected = false;
            }
        }
    }
}
