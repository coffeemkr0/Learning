using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermOfferingConsole
{
    /// <summary>
    /// Represents a room that a course can be taught in
    /// </summary>
    public class Room
    {
        #region Properties
        /// <summary>
        /// Gets or sets the room number for the room.
        /// </summary>
        public string RoomNumber { get; set; }

        /// <summary>
        /// Gets or sets the building that the room is in.
        /// </summary>
        public string Building { get; set; }
        #endregion
    }
}
