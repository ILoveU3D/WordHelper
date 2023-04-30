using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单词默写助手
{
    class TimeManager
    {
        private int time = 0;
        public int Time
        {
            get { return time; }
            set { time = value; }
        }
        public string showTime()
        {
            return Convert.ToString(time / 60) + "分" + Convert.ToString(time % 60) + "秒";
        }
        public static TimeManager timeManager;
    }
}
