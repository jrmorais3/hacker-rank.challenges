using System;
using System.Collections.Generic;

namespace WeekOne.BreakingTheRecords
{
    public class BreakingRecords
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
        
        /*
        static void Main(string[] args)
        {
            List<int> scores = new List<int> { 10, 5, 20, 20, 4, 5, 2, 25, 1};
            int[] result = breakingRecords(scores);
            Console.WriteLine(String.Join(" ", result));
            Console.ReadKey();
        }
        */
        
    }
}
