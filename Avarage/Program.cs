using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = new int[2];

            numbers[0] = -3;
            numbers[1] = 2;
            //numbers[2] = 1;
            //numbers[3] = 1;

            int a = Average(numbers);
            
            Console.Write("Input: [");
            for (int i = 0; i < numbers.Length; i++)
            {
                if(i == numbers.Length-1)
                {
                    Console.Write(numbers[i]);
                }
                else
                {
                    Console.Write(numbers[i] + ",");
                }
            }
            Console.Write("]");
            Console.WriteLine();
            Console.WriteLine($"Output: {0}", a);
            Console.ReadLine();
        }
        public static int Average(int[] a)
        {
            int sum =0;
            int result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
            }
            double average = (double)sum / a.Length;
            int truncAverage = (int)Math.Truncate(average);
            //int truncAverage = (int)average;
            double fraction = average - truncAverage;
            if (fraction < 0.5)
            {
                result = truncAverage;
            }
            else if (fraction > 0.5)
            {
                result = truncAverage + 1;
            }
            else
            {
                if(truncAverage % 2 == 0)
                {
                    result = truncAverage;
                }
                else
                {
                    result = truncAverage + 1;
                }
            }
            return result;
        }
    }
}
