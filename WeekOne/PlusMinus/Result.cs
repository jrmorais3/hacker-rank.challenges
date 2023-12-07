using System;
using System.Collections.Generic;
using System.Linq;

namespace WeekOne.PlusMinus
{
    public class Result
    {
        static double positiveNumbers;
        static double negativeNumbers;
        static double zeroNumbers;
        static double arraySize;

        public static void plusMinus(List<int> arr)
        {
            foreach (int i in arr)
            {
                if (i > 0)
                {
                    positiveNumbers++;
                }
                else if (i < 0)
                {
                    negativeNumbers++;
                }
                else
                {
                    zeroNumbers++;
                }
            }

            arraySize = arr.Count();

            double positiveDecimal = (positiveNumbers / arraySize);
            double negativeDecimal = negativeNumbers / arraySize;
            double zeroDecimal = zeroNumbers / arraySize;

            Console.WriteLine(positiveDecimal.ToString("N6"));
            Console.WriteLine(negativeDecimal.ToString("N6"));
            Console.WriteLine(zeroDecimal.ToString("N6"));

        }
    }
}
