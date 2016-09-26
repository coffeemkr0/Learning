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
        public string CRN { get; set; }

        public Instructor Instructor { get; set; }

        public Course Course { get; set; }

        public TimeSlot TimeSlot { get; set; }

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
