using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NwareTools.Loggers
{
    public static class GeneralAppLogger
    {
        public static void Start(string text)
        {
            Console.WriteLine("[AppGeneral]" + text);
        }
    }
}
