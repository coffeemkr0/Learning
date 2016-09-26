using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermOfferingConsole
{
    /// <summary>
    /// Represents a region of time at a school that has a list of courses being offered
    /// </summary>
    public class TermOffering
    {
        #region Properties
        public List<Offering> CourseOfferings { get; set; }

        public string Season { get; set; }

        public int Year { get; set; }

        public List<IChecker> Checkers { get; set; }
        #endregion

        #region Constructors
        public TermOffering()
        {
            this.CourseOfferings = new List<Offering>();
            this.Checkers = new List<IChecker>();
        }

        public TermOffering(string season, int year) : this()
        {
            this.Season = season;
            this.Year = year;
        }

        
        #endregion

        #region Public Methods
        public bool Check(PrintLogger logger)
        {
            bool result = true;

            foreach (var checker in this.Checkers)
            {
                bool checkerResult = checker.Check(this, logger);

                if (!checkerResult) result = false;
            }

            return result;
        }
        #endregion
    }
}
