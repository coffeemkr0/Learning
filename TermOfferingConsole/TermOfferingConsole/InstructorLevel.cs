using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermOfferingConsole
{
    /// <summary>
    /// Holds the possible levels that an instructor can attain at a school
    /// </summary>
    public enum InstructorLevel
    {
        /// <summary>
        /// An assistant to an instructor
        /// </summary>
        Assistant,
        /// <summary>
        /// A graduate student that assists an instructor
        /// </summary>
        GraduateAssistant,
        /// <summary>
        /// A fully qualified professor
        /// </summary>
        Professor,
        /// <summary>
        /// We aren't sure what this is but it sounded good
        /// </summary>
        Adjunct
    }
}
