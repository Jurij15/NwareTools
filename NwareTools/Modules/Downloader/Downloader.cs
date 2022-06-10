﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace NwareTools.Modules.Downloader
{
    public static class Downloader
    {
        public static void StartDownloader(string adress, string wheretodownload)
        {
            try
            {
                WebClient wc = new WebClient();
                wc.DownloadFile(adress, wheretodownload);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
