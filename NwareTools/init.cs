using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NwareTools.Modules;

namespace NwareTools
{
    public static class init
    {
        public static void Init()
        { 
            Console.WriteLine("Starting app...");
            Thread.Sleep(100);
            Console.WriteLine("Initializing Main module...");
            Thread.Sleep(100);
            Console.WriteLine("Initializing UI...");
            NwareTools.Modules.Main.init.LoadMain();
            Thread.Sleep(100);
        }
    }
}
