using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TermOfferingConsole
{
    /// <summary>
    /// Represents a region of time at a school that has a list of courses being offered
    /// </summary>
    public class TermOffering
    {
        #region Properties
        /// <summary>
        /// Gets or sets the collection of Course Offerings that are scheduled for this term.
        /// </summary>
        public List<Offering> CourseOfferings { get; set; }

        /// <summary>
        /// Gets or sets the name of the season for this term.
        /// </summary>
        public string Season { get; set; }

        /// <summary>
        /// Gets or sets the year for this term.
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets a list of term offering checkers that can be used to validate the term offering.
        /// </summary>
        public List<ITermOfferingChecker> Checkers { get; set; }
        #endregion

        #region Constructors
        public TermOffering()
        {
            this.CourseOfferings = new List<Offering>();
            this.Checkers = new List<ITermOfferingChecker>();
        }

        public TermOffering(string season, int year) : this()
        {
            this.Season = season;
            this.Year = year;
        }

        
        #endregion

        #region Public Methods
        /// <summary>
        /// Checks for conflicts and validates the term offering.
        /// </summary>
        /// <param name="logger">A logger that can be used to log any conflicts found.</param>
        /// <returns>true if no conflicts are found and the term offering is valid, otherwise false.</returns>
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

        public static TermOffering LoadFromFile(string file, string season, int year)
        {
            TermOffering termOffering = new TermOffering()
            {
                Season = season,
                Year = year
            };
            
            using (var reader = new StreamReader(file))
            {
                //Skip the first line
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var readLine = reader.ReadLine();

                    //Code,Sec,Credit,Name,Instructor,BlazerID,Office,Location
                    //EE011,0,0,Coop / Internship in EE,David G Green,Dgreen,BEC 256A,TBA
                    string[] lineParts = readLine.Split(',');

                    float credits = 0;
                    if(!float.TryParse(lineParts[2], out credits))
                    {
                        throw new Exception("Credits is not a valid number.");
                    }

                    Course course = new Course(lineParts[3], lineParts[0], credits);
                    Instructor instructor = new Instructor(lineParts[4], lineParts[5], lineParts[6]);
                    Room room = new Room()
                    {
                        RoomNumber = lineParts[7]
                    };

                    termOffering.CourseOfferings.Add(new Offering(course, instructor,
                        room, TimeSlot.FromString(lineParts[1])));
                    
                }
            }

            return termOffering;
        }
        #endregion
    }
}
