using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase.REPL
{
    /// <summary>
    /// This enumeration is used to indicated whether the command parsing happened successfylly or not
    /// </summary>
    public enum MetaCommandResult
    {
        Success,
        UnrecognizedCommand
    }
}
