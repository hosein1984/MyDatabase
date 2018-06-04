using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase.REPL
{
    /// <summary>
    /// This type is used to indicate the type of the input statement
    /// </summary>
    public enum StatementType
    {
        None,
        Insert,
        Select
    }
}
