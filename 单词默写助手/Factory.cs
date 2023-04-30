using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace 单词默写助手
{
    class Factory
    {
        public static void createWordSet(DataTable table, string Language)
        {
            switch (Language)
            {
                case "English":
                    WordSet.wordSet = new EnglishWordSet(table);
                    break;
                case "日本語":
                    WordSet.wordSet = new JapaneseWordSet(table);
                    break;
            }
        }
        public static void show()
        {
            switch (DataManager.dataManager.Language)
            {
                case "English":
                    new EnglishConfirm().ShowDialog();
                    break;
                case "日本語":
                    new JapaneseConfirm().ShowDialog();
                    break;
            }
        }
    }
}
