using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermOfferingConsole
{
    /// <summary>
    /// Represents a course that can be offered at a school
    /// </summary>
    public class Course
    {
        #region Properties
        /// <summary>
        /// Gets or sets the descriptive name of the course.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the course code that is less descriptive
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Gets or sets the amount of credits that the course is worth
        /// </summary>
        public float Credits { get; set; }
        #endregion

        #region Constructors
        public Course(string name, string code, float credits)
        {
            this.Name = name;
            this.Code = code;
            this.Credits = credits;
        }
        #endregion
    }
}
