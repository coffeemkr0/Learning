using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermOfferingConsole
{
    /// <summary>
    /// A logger that can log to the console window
    /// </summary>
    public class PrintLogger
    {
        #region Public Methods
        /// <summary>
        /// Logs a message to the console window
        /// </summary>
        /// <param name="message">The message to log</param>
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
        #endregion
    }
}
