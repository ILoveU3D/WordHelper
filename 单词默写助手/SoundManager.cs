using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Media;

namespace 单词默写助手
{
    class SoundManager
    {
        private static bool isMute = true;
        private static SoundPlayer right = new SoundPlayer(Properties.Resources.正确);
        private static SoundPlayer fault = new SoundPlayer(Properties.Resources.错误);
        private static SoundPlayer start = new SoundPlayer(Properties.Resources.启动);

        public static bool IsMute { get => isMute; set => isMute = value; }

        public static void rightPlay()
        {
            if(!IsMute)
                right.Play();
        }
        public static void faultPlay()
        {
            if(!IsMute)
                fault.Play();
        }
        public static void startPlay()
        {
            if(!IsMute)
                start.Play();
        }
        public static bool changeMute()
        {
            IsMute = !IsMute;
            return IsMute;
        }
    }
}
