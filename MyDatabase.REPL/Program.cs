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

                if (input == ".exit")
                {
                    return;
                }

                Console.WriteLine($"Unrecognized command {input}");
            }
        }
    }
}
