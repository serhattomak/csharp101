using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class FileLogger:ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("Writes log to the file.");
        }
    }
}
