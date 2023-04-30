using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单词默写助手
{
    class JapaneseWord : Word
    {
        private string hiragana;
        public string Hiragana
        {
            get { return hiragana; }
            set { hiragana = value; }
        }
        public JapaneseWord(string foreign, string hiragana,string chinese) : base(foreign, chinese)
        {
            this.hiragana = hiragana;
        }
    }
}
