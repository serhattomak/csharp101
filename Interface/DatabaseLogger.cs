using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace Interface
{
    internal class DatabaseLogger:ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Writes to the database.");
        }
    }
}
