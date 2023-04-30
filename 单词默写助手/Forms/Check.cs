using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace 单词默写助手
{
    public partial class Check : CCSkinMain
    {
        public Check()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("此操作会失去当前的结果，是否继续？", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                new Welcome().ShowDialog();
                this.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("此操作会失去当前的结果，是否继续？", "重新默写", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                this.Hide();
                Factory.show();
                this.Dispose();
            }
        }

        private void Check_Load(object sender, EventArgs e)
        {
            initView(this.listView1);
            initView2(this.listView2);
            this.label1.Text = "共计用时：" + TimeManager.timeManager.showTime();
            skinAnimator1.Show(this.label1);
            skinAnimator1.Show(this.groupBox1);
            skinAnimator1.Show(this.groupBox2);
        }
        private void initView(ListView listView)
        {
            listView.Columns.Add("词汇",listView.Size.Width);
            for (int i = 0;i < WriteManager.writeManager.Times ;i++ )
            {
                listView.Items.Add(Convert.ToString(i + 1) + "." + WriteManager.writeManager.HideWord[WriteManager.writeManager.Indexs[i]]);
            }
        }
        private void initView2(ListView listView)
        {
            listView.Columns.Add("词汇", listView.Size.Width);
            foreach (Word word in WrongManager.wrongManager.WorngWords)
            {
                listView.Items.Add(word.Chinese);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.FileName = "newWord";
            DialogResult result = this.saveFileDialog1.ShowDialog();
            if(result == DialogResult.Cancel)
            {
                return;
            }
            if (WrongManager.wrongManager.saveWords(this.saveFileDialog1.FileName))
            {
                MessageBox.Show("保存成功","保存数据",MessageBoxButtons.OK,MessageBoxIcon.None);
                System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo(this.saveFileDialog1.FileName);
                psi.Arguments = this.saveFileDialog1.FileName;
                System.Diagnostics.Process.Start(psi);
            }
            else
            {
                result = MessageBox.Show("保存失败","保存数据",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                if(result == DialogResult.Retry)
                {
                    this.button3.PerformClick();
                }
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            foreach(ListViewItem item in this.listView1.SelectedItems)
            {
                int index = WriteManager.writeManager.Indexs[item.Index];
                //Word newWord = new EnglishWord(WriteManager.writeManager.HideWord[index], WriteManager.writeManager.ShowWord[index]);
                Word newWord = WriteManager.writeManager.createNewWord(index);
                if (WrongManager.wrongManager.addWords(newWord))
                {
                    this.listView2.Items.Add(newWord.Chinese);
                }
                else
                {
                    MessageBox.Show("单词已存在","提交失败",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            foreach(ListViewItem item in this.listView2.SelectedItems)
            {
                WrongManager.wrongManager.removeWord(item.Index);
                this.listView2.Items.Remove(item);
            }
        }
    }
}
