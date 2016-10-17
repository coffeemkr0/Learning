using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGame
{
    public class ShotCollection
    {
        #region Properties
        public List<Shot> Shots { get; set; }
        #endregion

        #region Public Methods
        public void SaveToFile(string filename)
        {
            System.Xml.Serialization.XmlSerializer xs = 
                new System.Xml.Serialization.XmlSerializer(typeof(ShotCollection));

            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(filename))
            {
                xs.Serialize(sw, this);
            }
        }

        public static ShotCollection LoadFromFile(string filename)
        {
            System.Xml.Serialization.XmlSerializer xs =
                new System.Xml.Serialization.XmlSerializer(typeof(ShotCollection));

            using (System.IO.StreamReader sr = new System.IO.StreamReader(filename))
            {
                ShotCollection shotCollection = (ShotCollection)xs.Deserialize(sr);
                return shotCollection;
            }
        }
        #endregion
    }
}
