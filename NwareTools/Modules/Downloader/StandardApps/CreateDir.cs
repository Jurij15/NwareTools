using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NwareTools.Modules.Downloader.StandardApps
{
    public static class CreateDir
    {
        public static void CreateAllDirs()
        {
            if (!Directory.Exists(@"C:/Apps"))
            {
                Directory.CreateDirectory("C:/Apps");
            }
            CreateDir.CreateTempDir();
            CreateDir.CreateAPPDirs();
        }

        public static void CreateTempDir()
        {
            if (!Directory.Exists(@"C:/Apps/Temp"))
            {
                Directory.CreateDirectory("C:/Apps/Temp");
            }
        }

        public static void CreateAPPDirs()
        {
            if (!Directory.Exists(strings.WinXShellFinal))
            {
                Directory.CreateDirectory(strings.WinXShellFinal);
            }
            if (!Directory.Exists(strings.ExplorerPPFinal))
            {
                Directory.CreateDirectory(strings.ExplorerPPFinal);
            }
            if (!Directory.Exists(strings.OBSDFinal))
            {
                Directory.CreateDirectory(strings.OBSDFinal);
            }
            if (!Directory.Exists(strings.ChromeFInal))
            {
                Directory.CreateDirectory(strings.ChromeFInal);
            }
            if (!Directory.Exists(strings.DiscordFinal))
            {
                Directory.CreateDirectory(strings.DiscordFinal);
            }
            if (!Directory.Exists(strings.SzipFinalDir))
            {
                Directory.CreateDirectory(strings.SzipFinalDir);
            }
            if (!Directory.Exists(strings.NotCMDNvidiaFInal))
            {
                Directory.CreateDirectory(strings.NotCMDNvidiaFInal);
            }
            if (!Directory.Exists(strings.NT_NotepadFinal))
            {
                Directory.CreateDirectory(strings.NT_NotepadFinal);
            }
        }
    }
}
