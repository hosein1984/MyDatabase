using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase.REPL
{
    public static class HelperMethods
    {
        /// <summary>
        /// The prompt massage that will be shown in the begining of each line
        /// </summary>
        public static void PrintPrompt() => Console.Write("db> ");
    }
}
