/**********************************************************************************
 * Filename: MyClass.cs
 * Author: Jan Procházka
 * Created: 07-June-2023
 * Description: Sample class used for logging practice.
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
    public class MyClass
    {
        private static readonly ILogger _logger = Log.ForContext<MyClass>();

        public void DoSomething()
        {
            // Log an informational message
            _logger.Information("Doing something...");

            try
            {
                // Perform some operation
            }
            catch (Exception ex)
            {
                // Log an error message with the exception
                _logger.Error(ex, "An error occurred while doing something");
            }
        }
    }
}
