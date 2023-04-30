using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace 单词默写助手
{
    class Win32Anim
    {
        [DllImport("user32.dll")]
        public static extern bool AnimateWindow(IntPtr whnd, int dwtime, int dwflag);
        public const Int32 AW_HIDE = 0x00010000;
        public const Int32 AW_ACTIVATE = 0x00020000;
        public const Int32 AW_CENTER = 0x00000010;
        public const Int32 AW_SLIDE = 0x00040000;
        public const Int32 AW_VER_NEGTIVE = 0x00000008;
        public const Int32 AW_BLEND = 0x00080000;
        public const int defaultTime = 300;
    }
}
