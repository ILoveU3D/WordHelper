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
    public partial class JapaneseConfirm : CCSkinMain
    {
        public JapaneseConfirm()
        {
            InitializeComponent();
        }

        private void JapaneseConfirm_Load(object sender, EventArgs e)
        {
            initView(this.listView1, "nihongo");
            initView(this.listView2, "hiragana");
            initView(this.listView3, "chinese");
            this.wordNum.Text = Convert.ToString(WordSet.wordSet.Set.Length);
        }
        private void initView(ListView listView, string foreign)
        {
            listView.Columns.Add("词汇", listView.Size.Width);
            foreach (JapaneseWord word in WordSet.wordSet.Set)
            {
                switch (foreign)
                {
                    case "nihongo":
                        listView.Items.Add(word.Foreign);
                        break;
                    case "hiragana":
                        listView.Items.Add(word.Hiragana);
                        break;
                    case "chinese":
                        listView.Items.Add(word.Chinese);
                        break;
                }
            }
        }

        private void start_Click(object sender, EventArgs e)
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
                this.Hide();
                new WriteBand().ShowDialog();
                this.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Welcome().ShowDialog();
            this.Dispose();
        }
    }
}
