using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartRecorder
{
    public class AddFilter
    {
        #region Constructors

        #endregion

        public static DataStream Filter(DataStream input1, DataStream input2)
        {
            DataStream output = new DataStream();

            DataStream stream1;
            DataStream stream2;

            if(input1.Data.Count >= input2.Data.Count)
            {
                stream1 = input1;
                stream2 = input2;
            }
            else
            {
                stream1 = input2;
                stream2 = input1;
            }

            for (int i = 0; i < stream1.Data.Count; i++)
            {
                int x = stream1.Data[i];
                int y = 0;
                if(stream2.Data.Count > i)
                {
                    y = stream2.Data[i];
                }

                output.Data.Add(AddFilter.FilterData(x, y));
            }

            return output;
        }

        public static int FilterData(int? x, int? y)
        {
            int output = x.HasValue ? x.Value : 0;

            output += y.HasValue ? y.Value : 0;

            return output;
        }
    }
}
