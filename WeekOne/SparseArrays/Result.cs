using System.Collections.Generic;
using System.Linq;

namespace WeekOne.SparseArrays
{
    public class Result
    {

        /*
         * Complete the 'matchingStrings' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. STRING_ARRAY strings
         *  2. STRING_ARRAY queries
         */

        public static List<int> MatchingStrings(List<string> strings, List<string> queries)
        {
            int[] result = new int[queries.Count];

            for (int i = 0; i < queries.Count; i++)
            {
                for (int j = 0; j < strings.Count; j++)
                {
                    if (strings[j].ToString().Equals(queries[i]))
                    {
                        result[i] += 1; 
                    }
                }
            }

            return result.ToList();

        }
    }
}
