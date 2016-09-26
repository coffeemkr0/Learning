using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermOfferingConsole
{
    /// <summary>
    /// Supports checking a term offering to see if it is valid.
    /// </summary>
    public interface ITermOfferingChecker
    {
        /// <summary>
        /// Checks to see if a term offering is valid and logs any conflicts.
        /// </summary>
        /// <param name="termOffering">The term offering to check.</param>
        /// <param name="logger">A logger that can log conflicts.</param>
        /// <returns>true if the term offering has no conflicts, otherwise false.</returns>
        bool Check(TermOffering termOffering, PrintLogger logger);
    }
}
