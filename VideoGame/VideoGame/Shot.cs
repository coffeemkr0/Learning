using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame
{
    public class Shot
    {
        #region Properties
        public DateTime TimeOfShot { get; set; }

        public int PlayerNumber { get; set; }

        public string Team { get; set; }

        public bool ShotMade { get; set; }

        public System.Drawing.Point Location { get; set; }
        #endregion
    }
}
