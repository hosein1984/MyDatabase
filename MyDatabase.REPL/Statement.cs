using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase.REPL
{
    /// <summary>
    /// This structure would hold the constructed statement from the user input
    /// </summary>
    public struct Statement
    {
        public StatementType Type { get; set; }
    }
}
