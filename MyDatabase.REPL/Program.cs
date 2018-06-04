using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase.REPL
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                HelperMethods.PrintPrompt();
                var input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    if (input.First() == '.')
                    {
                        switch (HelperMethods.DoMetaCommand(input))
                        {
                            case MetaCommandResult.Success:
                                break;
                            case MetaCommandResult.UnrecognizedCommand:
                                Console.WriteLine($"Unrecognized command {input}");
                                break;
                            default:
                                throw new ArgumentOutOfRangeException();
                        }
                    }
                    else
                    {
                        switch (HelperMethods.PrepateStatement(input, out var statement))
                        {
                            case PrepareResult.Success:
                                break;
                            case PrepareResult.UnrecognizedStatement:
                                Console.WriteLine($"Unrecognized keyword at start of {input}");
                                break;
                        }

                        HelperMethods.ExecuteStatement(statement);
                        Console.WriteLine("Executed");
                    }
                }
            }
        }
    }
}
