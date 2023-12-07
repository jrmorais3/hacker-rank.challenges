using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOne.DivisibleSumPairs
{
    public class Result
    {
        /*
         * Complete the 'divisibleSumPairs' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. INTEGER k
         *  3. INTEGER_ARRAY ar
         *  int n: the length of array 
         *  int ar[n]: an array of integers
         *  int k: the integer diviso
         */

        public static int divisibleSumPairs(int n, int k, List<int> arr)
        {
            arr.Sort();
            int resultado = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    var sumTest = arr[i] + arr[j];
                    var result = sumTest % k;

                    if (result == 0)
                    {
                        resultado++;
                    }
                }
            }

            return resultado;
        }
    }
}
