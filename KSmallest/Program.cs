using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KSmallest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 7, 2, 1, 6, 1 };
            int k = 3;
            int res = Ksmallest(arr, k);
            Console.WriteLine(res.ToString());
            Console.ReadLine();
        }
        public static int Ksmallest(int[] a, int k)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        int temp = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = temp;
                        swapped = true;
                    }
                }
            } while (swapped == true);
            //var b = a.Distinct().ToArray();
            //int result = b[k - 1];

            //int round = 0;
            //int tempValue = a[0];
            //for (int i = 1; i < a.Length - 1; i++)
            //{
            //    while (round< k)
            //    {
            //        if(a[i] > tempValue)
            //        {
            //            tempValue = a[i];
            //            round++;
            //        }
            //        break;
            //    }
            //}
            List<int> result = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                // Check for duplicates in all following elements.
                bool isDuplicate = false;
                for (int y = i + 1; y < a.Length; y++)
                {
                    if (a[i] == a[y])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    result.Add(a[i]);
                }
            }
            return result[k-1];
        }

    }
}
