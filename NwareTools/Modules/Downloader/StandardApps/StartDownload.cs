using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;
using NwareTools.Loggers;

namespace NwareTools.Modules.Downloader.StandardApps
{
    public class StartDownload
    {
        public void Download()
        {
            DownloadModuleLogger.DMLog("Downloading 7-Zip...");
            Downloader.StartDownloader(strings.SzipDownload, "C:/Apps/Temp/7-zip.zip");
            DownloadModuleLogger.DMLog("Extracting 7-Zip...");
            ZipFile.ExtractToDirectory("C:/Apps/Temp/7-zip.zip", strings.SzipFinalDir);
            DownloadModuleLogger.DMLog("Downloaded 7-Zip...");
            //download discord
            DownloadModuleLogger.DMLog("Downloading Discord...");
            Downloader.StartDownloader(strings.DiscordDownload, "C:/Apps/Temp/Discord.zip");
            DownloadModuleLogger.DMLog("Extracting Discord...");
            ZipFile.ExtractToDirectory("C:/Apps/Temp/Discord.zip", strings.DiscordFinal);
            DownloadModuleLogger.DMLog("Downloaded Discord...");
            //download chrome
            DownloadModuleLogger.DMLog("Downloading Chrome...");
            Downloader.StartDownloader(strings.ChromeDownload, "C:/Apps/Temp/Chrome.zip");
            DownloadModuleLogger.DMLog("Extracting Chrome...");
            ZipFile.ExtractToDirectory("C:/Apps/Temp/Chrome.zip", strings.ChromeFInal);
            DownloadModuleLogger.DMLog("Downloaded Chrome...");
            //download cmd
            DownloadModuleLogger.DMLog("Downloading CMD...");
            Downloader.StartDownloader(strings.NotCMDNvidiaDownload, strings.CMDFInalExe);
            DownloadModuleLogger.DMLog("Downloaded CMD...");
            //download explorer++
            DownloadModuleLogger.DMLog("Downloading Explorer++...");
            Downloader.StartDownloader(strings.ExplorerPP, strings.ExplorerPPFinalExe);
            DownloadModuleLogger.DMLog("Downloaded Explorer++...");
            //download OBS
            DownloadModuleLogger.DMLog("Downloading OBS...");
            Downloader.StartDownloader(strings.OBSDownload, "C:/Apps/Temp/OBS.zip");
            DownloadModuleLogger.DMLog("Extracting OBS...");
            ZipFile.ExtractToDirectory("C:/Apps/Temp/OBS.zip", strings.OBSDFinal);
            DownloadModuleLogger.DMLog("Downloaded OBS...");
            //WINXSHELL download
            DownloadModuleLogger.DMLog("Downloading WinXShell...");
            Downloader.StartDownloader(strings.WinXShellDownload, strings.WinXShellFInalExe);
            DownloadModuleLogger.DMLog("Downloaded WinXShell...");
            //download NT_Notepad
            DownloadModuleLogger.DMLog("Downloading Notepad...");
            Downloader.StartDownloader(strings.NwareToolsNotepadDownload, strings.NT_NotepadFinalExe);
            DownloadModuleLogger.DMLog("Downloaded WinXShell...");
            DownloadModuleLogger.DMLog("Downloads Finished!");

            GeneralAppLogger.Start("Statring Explorer++..");
            Process process = new Process();
            process.StartInfo.FileName = "C:/Apps/Explorer++/Explorer++.exe";
            process.StartInfo.Arguments = "C:/Apps";
            process.Start();

            DownloadModuleLogger.DMLog("All downloads finished, returning to Main...");
            NwareTools.Modules.Main.Windows.MainWindow.StartMain();
        }
    }
}
