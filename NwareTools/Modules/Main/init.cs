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
            Console.WindowHeight = 40;
            NwareTools.Modules.Main.Windows.MainWindow.StartMain();
        }
    }
}
