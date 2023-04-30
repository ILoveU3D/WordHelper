using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单词默写助手
{
    class WrongManager
    {
        private List<Word> wrongWords = new List<Word>();
        private Word presentWord;
        public List<Word> WorngWords
        {
            get { return wrongWords; }
            set { wrongWords = value; }
        }
        public Word PresentWord
        {
            get { return presentWord; }
            set { presentWord = value; }
        }
        public void addWords()
        {
            wrongWords.Add(presentWord);
        }
        public bool addWords(Word word)
        {
            if (wrongWords.Contains(word))
            {
                return false;
            }
            wrongWords.Add(word);
            return true;
        }
        public void removeWord(int index)
        {
            wrongWords.RemoveAt(index);
        }
        public bool saveWords(string path)
        {
            return DataManager.dataManager.exportData(path, wrongWords.ToArray());
        }
        public static WrongManager wrongManager;
    }
}
