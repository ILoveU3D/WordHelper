using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单词默写助手
{
    abstract class Word
    {
        protected string foreign;
        protected string chinese;
        public Word(string foreign,string chinese)
        {
            this.foreign = foreign;
            this.chinese = chinese;
        }
        public string Foreign
        {
            get { return foreign; }
            set { foreign = value; }
        }
        public string Chinese
        {
            get { return chinese; }
            set { chinese = value; }
        }
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            if (!(obj is Word word))
            {
                return false;
            }
            if (word.foreign.Equals(foreign) && word.chinese.Equals(chinese))
            {
                return true;
            }
            else return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
