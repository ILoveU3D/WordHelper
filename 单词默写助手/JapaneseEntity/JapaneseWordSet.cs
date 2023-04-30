using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace 单词默写助手
{
    class JapaneseWordSet : WordSet
    {
        public JapaneseWordSet(DataTable table) : base(table)
        {
            for (int i = 0; i < set.Length; i++)
            {
                set[i] = new JapaneseWord(table.Rows[i][0].ToString(), table.Rows[i][1].ToString(), table.Rows[i][2].ToString());
            }
        }
    }
}
