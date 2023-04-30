using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单词默写助手.WritingController
{
    class PracticeManager
    {
        private bool isPractise;

        public static PracticeManager practiceManager = null;

        public bool IsPractise { get => isPractise; set => isPractise = value; }
    }
}
