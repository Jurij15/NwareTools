﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NwareTools.Loggers
{
    public static class DownloadModuleLogger
    {
        public static void DMLog(string text)
        {
            Console.WriteLine("[DLModule]" + text);
        }
    }
}
