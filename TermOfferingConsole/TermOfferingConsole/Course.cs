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
        public string Name { get; set; }

        public string Code { get; set; }

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
