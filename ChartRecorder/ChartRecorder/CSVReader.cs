using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartRecorder
{
    public class CSVReader : IDisposable
    {
        private FileStream _fileStream;
        private StreamReader _streamReader;

        #region Properties
        public char Delimiter { get; set; }

        public int ColumnNumber { get; set; }
        #endregion
        #region Constructors
        /// <summary>
        /// Creates an instance of the CSVReader class
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="delimiter"></param>
        /// <param name="columnNumber">0 based column number that will be read from</param>
        public CSVReader(string fileName, char delimiter, int columnNumber)
        {
            _fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            _streamReader = new StreamReader(_fileStream);

            this.Delimiter = delimiter;
            this.ColumnNumber = columnNumber;
        }

        public string Next()
        {
            return _streamReader.ReadLine().Split(this.Delimiter)[this.ColumnNumber];
        }

        public void Dispose()
        {
            _streamReader.Dispose();
            _fileStream.Dispose();
        }
        #endregion
    }
}
