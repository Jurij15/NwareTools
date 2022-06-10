using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NwareTools.Loggers;
using System.Threading;
using NwareTools.Modules.Downloader.StandardApps;

namespace NwareTools.Modules.Downloader
{
    public class init
    {
        public void Init()
        {
            Console.Clear();
            GeneralAppLogger.Start("Starting Download Module...");
            Thread.Sleep(350);
            DownloadModuleLogger.DMLog("Creating Directories...");
            Thread.Sleep(100);
            CreateDir.CreateAllDirs();
            DownloadModuleLogger.DMLog("Starting downloads...");
            Thread.Sleep(50);
            StartDownload startDownload = new StartDownload();
            startDownload.Download();
        }
    }
}
