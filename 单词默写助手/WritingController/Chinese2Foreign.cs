using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单词默写助手
{
    class Chinese2Foreign : WriteManager
    {
        public override void setWord()
        {
            base.setWord();
            for (int i = 0; i < showWord.Length; i++)
            {
                showWord[i] = WordSet.wordSet.Set[i].Chinese;
                hideWord[i] = WordSet.wordSet.Set[i].Foreign;
            }
        }
        public override Word createNewWord(int index)
        {
            switch (DataManager.dataManager.Language)
            {
                case "English":
                    return new EnglishWord(hideWord[index],showWord[index]);
                case "日本語":
                    return new JapaneseWord(hideWord[index],"这边还没写好……", showWord[index]);
            }
            return base.createNewWord(index);
        }
    }
}
