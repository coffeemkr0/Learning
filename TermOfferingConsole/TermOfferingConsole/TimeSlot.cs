using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermOfferingConsole
{
    /// <summary>
    /// Represents a time slot at a college in which courses can be offered.
    /// </summary>
    public class TimeSlot
    {
        #region Properties
        /// <summary>
        /// Gets or sets the name of the time slot
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the start time for the time slot (date part is not used).
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time for the time slot (date part is not used).
        /// </summary>
        public DateTime EndTime { get; set; }

        public static TimeSlot TimeSlot_2A
        {
            get
            {
                return new TimeSlot()
                {
                    Name = "2A",
                    StartTime = new DateTime(2000, 1, 1, 8, 0, 0),
                    EndTime = new DateTime(2000, 1, 1, 9, 15, 0)
                };
            }
        }

        public static TimeSlot TimeSlot_2B
        {
            get
            {
                return new TimeSlot()
                {
                    Name = "2B",
                    StartTime = new DateTime(2000, 1, 1, 9, 30, 0),
                    EndTime = new DateTime(2000, 1, 1, 10, 45, 0)
                };
            }
        }

        public static TimeSlot TimeSlot_2C
        {
            get
            {
                return new TimeSlot()
                {
                    Name = "2C",
                    StartTime = new DateTime(2000, 1, 1, 11, 0, 0),
                    EndTime = new DateTime(2000, 1, 1, 12, 15, 0)
                };
            }
        }

        public static TimeSlot TimeSlot_2D
        {
            get
            {
                return new TimeSlot()
                {
                    Name = "2D",
                    StartTime = new DateTime(2000, 1, 1, 12, 30, 0),
                    EndTime = new DateTime(2000, 1, 1, 13, 45, 0)
                };
            }
        }
        #endregion

        #region Constructors

        #endregion

        #region Public Methods
        public static List<TimeSlot> GetTimeSlots()
        {
            List<TimeSlot> timeSlots = new List<TimeSlot>();

            Type timeSlotType = typeof(TimeSlot);
            var properties = timeSlotType.GetProperties(System.Reflection.BindingFlags.Public |
                System.Reflection.BindingFlags.Static);

            foreach(var property in properties)
            {
                timeSlots.Add((TimeSlot)property.GetValue(null));
            }
                       
            return timeSlots;
        }

        /// <summary>
        /// Checks to see if two time slots overlap each other.
        /// </summary>
        /// <param name="x">The first time slot to check</param>
        /// <param name="y">The second time slot to check</param>
        /// <returns>true of the time slots overlap, otherwise false</returns>
        public static bool DoTimeSlotsOverlap(TimeSlot x, TimeSlot y)
        {
            if (x.StartTime == y.StartTime) return true;

            if((x.StartTime > y.StartTime && x.EndTime < y.EndTime) ||
                (x.EndTime > y.StartTime && x.EndTime < y.EndTime))
            {
                return true;
            }

            return false;
        }
        #endregion
    }
}
