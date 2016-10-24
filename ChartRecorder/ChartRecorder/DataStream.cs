using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartRecorder
{
    public class DataStream
    {
        #region Properties
        public List<int> Data { get; set; }
        #endregion

        #region Public Method
        public static DataStream LoadFromFile(string filename, int columnNumber)
        {
            return new DataStream();
        }
        #endregion
    }
}
