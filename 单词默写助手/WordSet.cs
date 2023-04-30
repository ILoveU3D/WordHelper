using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace 单词默写助手
{
    abstract class WordSet
    {
        protected Word[] set;
        public WordSet(DataTable table)
        {
            set = new Word[table.Rows.Count];
        }
        public Word[] Set
        {
            get { return set; }
            set { set = value; }
        }
        public static WordSet wordSet;
    }
}
