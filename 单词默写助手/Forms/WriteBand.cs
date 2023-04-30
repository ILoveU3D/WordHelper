using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using CCWin;
using 单词默写助手.WritingController;

namespace 单词默写助手
{
    public partial class WriteBand : CCSkinMain
    {
        public WriteBand()
        {
            InitializeComponent();
        }

        private void WriteBand_Load(object sender, EventArgs e)
        {
            if (!PracticeManager.practiceManager.IsPractise)
            {
                Animator.Show(this.button1);
                Animator.Show(this.start);
            }
            else
                Animator.Show(this.practice);
            Animator.Show(this.exit);
            WrongManager.wrongManager = new WrongManager();
            WriteManager.writeManager.setWord();
            int index = WriteManager.writeManager.getWriting();
            this.wordLabel.Text = WriteManager.writeManager.ShowWord[index];
            this.answer.Text = WriteManager.writeManager.HideWord[index];
            Animator.Show(this.wordLabel);
            TimeManager.timeManager = new TimeManager();
            this.time.Text = TimeManager.timeManager.showTime();
            this.timer.Start();
        }

        private void WriteBand_KeyDown(object sender,KeyEventArgs e)
        {
            if (!PracticeManager.practiceManager.IsPractise)
            {
                if (e.KeyCode == Keys.A)
                {
                    this.button1.PerformClick();
                }
                else if (e.KeyCode == Keys.N)
                {
                    this.start.PerformClick();
                }
                else if (e.KeyCode == Keys.E)
                {
                    this.exit.PerformClick();
                }
            }else
                this.practice.PerformClick();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            exit2check();
        }

        private void start_Click(object sender, EventArgs e)
        {
            WrongManager.wrongManager.addWords();
            SoundManager.faultPlay();
            Animator.ShowSync(this.answer);
            System.Threading.Thread.Sleep(1000);
            Animator.HideSync(this.answer);
            int index = WriteManager.writeManager.getWriting();
            checking(index);
            Animator.ShowSync(this.wordLabel);
        }
        private void checking(int index)
        {
            if(index == int.MaxValue)
            {
                exit2check();
            }
            else
            {
                Animator.HideSync(this.wordLabel);
                this.wordLabel.Text = WriteManager.writeManager.ShowWord[index];
                this.answer.Text = WriteManager.writeManager.HideWord[index];
                this.wordItems.Text = "第" + WriteManager.writeManager.Times + "/" + WriteManager.writeManager.Numbers + "个";
            }
        }
        private void exit2check()
        {
            if (!PracticeManager.practiceManager.IsPractise)
            {
                this.Hide();
                this.timer.Stop();
                new Check().ShowDialog();
                this.Dispose();
            }
            else
            {
                this.Hide();
                this.timer.Stop();
                Factory.show();
                this.Dispose();
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            TimeManager.timeManager.Time++;
            this.time.Text = "用时：" + TimeManager.timeManager.showTime();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = WriteManager.writeManager.getWriting();
            SoundManager.rightPlay();
            checking(index);
            Animator.ShowSync(this.wordLabel);
        }
    }
}
