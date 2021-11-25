using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            EventLog myLog = new EventLog();
            myLog.Log = "Security";

            var lastLog = myLog.Entries[myLog.Entries.Count - 1];
            Console.WriteLine("\tReading Security Logs");
            Console.WriteLine("\tTotal Logs: " + myLog.Entries.Count);
            Console.WriteLine("\tLast Entry: " + lastLog.Message);


            myLog = new EventLog();
            myLog.Log = "Application";

            lastLog = myLog.Entries[myLog.Entries.Count - 1];
            Console.WriteLine("\tReading Application Logs");
            Console.WriteLine("\tTotal Logs: " + myLog.Entries.Count);
            Console.WriteLine("\tLast Entry: " + lastLog.Message);

            //Log all
            //foreach (EventLogEntry entry in myLog.Entries)
            //{
            //    Console.WriteLine("\tEntry: " + entry.Message);
            //}

            Console.ReadKey();
        }
    }
}
