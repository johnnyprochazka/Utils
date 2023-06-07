/**********************************************************************************
 * Filename: Program.cs
 * Author: Jan Procházka
 * Created: 07-June-2023
 * Description: Sample logging practice.
 *
 * Revision History:
 *     [1.00.00] [07-June-2023] [Jan Procházka] [Initial]
 **********************************************************************************/


using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Configure the logger
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug() // Set the minimum log level to Debug
                .WriteTo.Console() // Send logs to the console
                .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day) // Send logs to a file
                .CreateLogger();


            var myClass = new MyClass();
            myClass.DoSomething();

            // Close and flush the logger
            Log.CloseAndFlush();
        }
    }
}
