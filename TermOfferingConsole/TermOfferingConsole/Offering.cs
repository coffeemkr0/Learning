using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermOfferingConsole
{
    /// <summary>
    /// Represents a course that is being offered at a school
    /// </summary>
    public class Offering
    {
        #region Properties
        /// <summary>
        /// Gets or sets a unique Id for the offering.
        /// </summary>
        public string CRN { get; set; }

        /// <summary>
        /// Gets or sets the Instructor that is offering the course.
        /// </summary>
        public Instructor Instructor { get; set; }

        /// <summary>
        /// Gets or sets the Course that is being offered.
        /// </summary>
        public Course Course { get; set; }

        /// <summary>
        /// Gets or sets the time slot that the Course is being offered.
        /// </summary>
        public TimeSlot TimeSlot { get; set; }

        /// <summary>
        /// Gets or sets the Room in which the course is being offered.
        /// </summary>
        public Room Room { get; set; }
        #endregion

        #region Constructors
        public Offering(Course course, Instructor instructor, Room room, TimeSlot time)
        {
            this.CRN = Guid.NewGuid().ToString();

            this.Course = course;
            this.Instructor = instructor;
            this.Room = room;
            this.TimeSlot = time;
        }
        #endregion
    }
}
