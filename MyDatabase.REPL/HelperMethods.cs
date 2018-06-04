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

        /// <summary>
        /// This method parses the input string and returns an appropriate <see cref="MetaCommandResult"/> enumeration
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static MetaCommandResult DoMetaCommand(string input)
        {
            if (input == ".exit")
            {
                return MetaCommandResult.Success;
            }

            return MetaCommandResult.UnrecognizedCommand;
        }


        /// <summary>
        /// This method create a statement out of the user input. This is basically our simple SQL parser.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="statement"></param>
        /// <returns></returns>
        public static PrepareResult PrepateStatement(string input, out Statement statement)
        {
            statement = new Statement();

            // insert input will be followed by data so we need to compare only the first 6 characters 
            if (input.Substring(0,6) == "insert")
            {
                statement.Type = StatementType.Insert;
                return PrepareResult.Success;
            }
            if (input == "select")
            {
                statement.Type = StatementType.Select;
                return PrepareResult.Success;
            }

            return PrepareResult.UnrecognizedStatement;
        }

        /// <summary>
        /// This method executes the constructed statement. This is basically our simple VM.
        /// </summary>
        /// <param name="statement"></param>
        public static void ExecuteStatement(Statement statement)
        {
            switch (statement.Type)
            {
                case StatementType.Insert:
                    Console.WriteLine("This is where we would do an insert.");
                    break;
                case StatementType.Select:
                    Console.WriteLine("This is where we would do an select.");
                    break;
                case StatementType.None:
                    break;
            }
        }
    }
}
