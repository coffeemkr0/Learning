using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermOfferingConsole
{
    public class InstructorChecker : IChecker
    {
        public bool Check(TermOffering termOffering, PrintLogger logger)
        {
            bool result = true;

            foreach (var offering in termOffering.CourseOfferings)
            {
                if(!IsOk(offering, termOffering, logger))
                {
                    result = false;
                }
            }

            return result;
        }

        private bool IsOk(Offering offering, TermOffering termOffering, PrintLogger logger)
        {
            bool result = true;

            foreach (var otherOffering in termOffering.CourseOfferings)
            {
                if(offering.CRN != otherOffering.CRN)
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
    }
}
