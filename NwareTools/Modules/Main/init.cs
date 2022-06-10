using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NwareTools.Modules.Main
{
    public static class init
    {
        public static void LoadMain()
        {
            Console.WindowHeight = 35;
            Console.WindowWidth = 55;
            NwareTools.Modules.Main.Windows.MainWindow.StartMain();
        }
    }
}
