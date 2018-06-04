using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase.REPL
{
    /// <summary>
    /// This enumeration is used to indicate whether the statement creation happened successfully or not.
    /// </summary>
    public enum PrepareResult
    {
        Success,
        UnrecognizedStatement
    }
}
