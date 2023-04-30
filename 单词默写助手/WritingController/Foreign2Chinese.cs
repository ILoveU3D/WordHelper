using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单词默写助手
{
    class Foreign2Chinese : WriteManager
    {
        public override void setWord()
        {
            base.setWord();
            for (int i = 0; i < showWord.Length; i++)
            {
                showWord[i] = WordSet.wordSet.Set[i].Foreign;
                hideWord[i] = WordSet.wordSet.Set[i].Chinese;
            }
        }
        public override Word createNewWord(int index)
        {
            switch (DataManager.dataManager.Language)
            {
                case "English":
                    return new EnglishWord(showWord[index],hideWord[index]);
                case "日本語":
                    return new JapaneseWord(showWord[index], "这边还没写好……", hideWord[index]);
            }
            return base.createNewWord(index);
        }
    }
}
