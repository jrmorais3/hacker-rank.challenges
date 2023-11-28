using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOne.BreakingTheRecords
{
    public class Result
    {
        public static int[] breakingRecords(List<int> scores)
        {
            var topRecord = scores[0];
            var topResults = 0;
            var lowRecord = scores[0];
            var lowResults = 0;
            int[] result = new int [2];

            for (int i = 0; i < scores.Count; i++)
            {
                if (scores[i] > topRecord)
                {
                    topRecord = scores[i];
                    topResults++;
                }
                else if (scores[i] < lowRecord)
                {
                    lowRecord = scores[i];
                    lowResults++; 
                }
            }

            result[0] = topResults;
            result[1] = lowResults;
            
            return result;

        }
    }
}
