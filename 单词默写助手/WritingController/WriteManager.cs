using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单词默写助手
{
    class WriteManager
    {
        protected string[] hideWord;
        protected string[] showWord;
        protected int[] indexs;
        private bool[] isWrite;
        private int numbers;
        Random random = new Random();
        private int times = 0;
        public virtual void setWord()
        {
            this.showWord = new string[WordSet.wordSet.Set.Length];
            this.hideWord = new string[WordSet.wordSet.Set.Length];
            this.isWrite = new bool[this.showWord.Length];
            Array.Clear(this.isWrite, 0, this.isWrite.Length);
            this.indexs = new int[this.showWord.Length];
        }
        public virtual Word createNewWord(int index) { return null; }
        public bool setNumber(string number)
        {
            try
            {
                numbers = Convert.ToInt32(number);
                return true;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
        public int getWriting()
        {
            if(times >= numbers)
            {
                return int.MaxValue;
            }
            int index = int.MaxValue;
            int rm = random.Next(0, isWrite.Length - 1);
            for (int i = 0;i < isWrite.Length;i++ )
            {
                if (isWrite[i])
                {
                    continue;
                }
                if(Math.Abs(rm - index) > Math.Abs(rm - i))
                {
                    index = i;
                }
            }
            isWrite[index] = true;
            indexs[times] = index;
            times++;
            WrongManager.wrongManager.PresentWord = WordSet.wordSet.Set[index];
            return index;
        }
        public bool saveWord(string path)
        {
            List<Word> arr = new List<Word>();
            foreach (int i in indexs)
            {
                arr.Add(WordSet.wordSet.Set[i]);
            }
            return DataManager.dataManager.exportData(path,arr.ToArray());
        }
        public string[] HideWord
        {
            get { return hideWord; }
            set { hideWord = value; }
        }
        public string[] ShowWord
        {
            get { return showWord; }
            set { showWord = value;}
        }
        public int[] Indexs
        {
            get { return indexs; }
            set { indexs = value; }
        }
        public int Times
        {
            get { return times; }
            set { times = value; }
        }
        public int Numbers
        {
            get { return numbers; }
            set { numbers = value; }
        }
        public static WriteManager writeManager = null;
    }
}
