using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermOfferingConsole
{
    /// <summary>
    /// A class that can be used to check to see if a term offering is valid.
    /// </summary>
    public class InstructorChecker : ITermOfferingChecker
    {
        #region Private Methods
        private bool IsOk(Offering offering, TermOffering termOffering, PrintLogger logger)
        {
            bool result = true;

            foreach (var otherOffering in termOffering.CourseOfferings)
            {
                if (offering.CRN != otherOffering.CRN)
                {
                    if (offering.Instructor.BlazerId == otherOffering.Instructor.BlazerId)
                    {
                        if (TimeSlot.DoTimeSlotsOverlap(offering.TimeSlot, otherOffering.TimeSlot))
                        {
                            logger.Log(string.Format("Conflict found - " +
                                "Instructor {0} is scheduled for two offerings at the same time - {1} and {2}", offering.Instructor.Name,
                                offering.Course.Code, otherOffering.Course.Code));

                            result = false;
                        }
                    }
                }
            }

            return result;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Checks to see if the term offering has any scheduling conflicts for instructors.
        /// </summary>
        /// <param name="termOffering">The term offering to check.</param>
        /// <param name="logger">A logger that can log any conflicts.</param>
        /// <returns>true if the term offering has no conflicts, otherwise false.</returns>
        public bool Check(TermOffering termOffering, PrintLogger logger)
        {
            bool result = true;

            List<string> conflicts = new List<string>();

            foreach (var offering in termOffering.CourseOfferings)
            {
                if(!conflicts.Contains(offering.CRN) && !IsOk(offering, termOffering, logger))
                {
                    result = false;
                    conflicts.Add(offering.CRN);
                }
            }

            return result;
        }
        #endregion
    }
}
