using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NwareTools.Modules.Main.Windows
{
    public static class MainWindow
    {
        public static void StartMain()
        {
            Console.Clear();
            Console.ForegroundColor
            = ConsoleColor.White;
            Console.WriteLine("NwareTools, Made by Jurij15, version TBD");
            Console.WriteLine("");
            Console.ForegroundColor
= ConsoleColor.Cyan;
            Console.WriteLine("Welcome, what would  you like to do?");
            Console.WriteLine("");
            Console.ForegroundColor
= ConsoleColor.Yellow;
            Console.WriteLine("1. Install Standard apps");
            Console.WriteLine("");
            Console.WriteLine("2.See Nware Methods");
            Console.WriteLine("");
            Console.WriteLine("3.Exit");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write(">");
            var info = Console.ReadKey();
            Console.WriteLine();
            switch (info.KeyChar)
            {
                case '1':
                    Console.WriteLine(">");
                    break;
                case '2':
                    Console.WriteLine("<");
                    break;
                case '3':
                    Console.WriteLine("=");
                    break;
                case '4':
                    Console.WriteLine(">");
                    break;
            }
        }
    }
}
