using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartRecorder
{
    class MultiStreamExample
    {
        public void Test()
        {
            FileStream fs1 = new FileStream("C:\\Test1.csv", FileMode.Open, FileAccess.Read, FileShare.Read);
            StreamReader sr1 = new StreamReader(fs1);

            FileStream fs2 = new FileStream("C:\\Test1.csv", FileMode.Open, FileAccess.Read, FileShare.Read);
            StreamReader sr2 = new StreamReader(fs2);

            FileStream fs3 = new FileStream("C:\\Test1.csv", FileMode.Open, FileAccess.Read, FileShare.Read);
            StreamReader sr3 = new StreamReader(fs3);

            List<string> firstColumn = new List<string>();
            firstColumn.Add(sr1.ReadLine().Split(',')[0]);





            List<string> secondColumn = new List<string>();
            secondColumn.Add(sr2.ReadLine().Split(',')[1]);



        }
    }
}
