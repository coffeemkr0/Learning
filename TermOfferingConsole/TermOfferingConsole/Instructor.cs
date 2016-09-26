using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermOfferingConsole
{
    /// <summary>
    /// Represents a teacher at a college
    /// </summary>
    public class Instructor
    {
        #region Properties
        public string Name { get; set; }

        public string BlazerId { get; set; }

        public string Office { get; set; }

        public InstructorLevel Level { get; set; }

        public string EmailAddress { get; set; }
        #endregion

        #region Constructors
        public Instructor(string name, string blazerId, string office)
        {
            this.Name = name;
            this.BlazerId = blazerId;
            this.Office = office;
        }
        #endregion
    }
}
