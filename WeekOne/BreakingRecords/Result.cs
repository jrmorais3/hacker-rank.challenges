using System;
using System.Collections.Generic;
using System.Linq;
using static System.Formats.Asn1.AsnWriter;

namespace WeekOne.BreakingRecords
{
    public class Result
    {
        public static void breakingRecords(List<int> scores)
        {
            var topRecord = scores[0];
            var topResults = 0;
            var lowRecord = scores[0];
            var lowResults = 0;
            int[] result = new int[2];

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

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
