using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[4] { 1, 1, 1, 1 };
            int res = Difference(arr);
            Console.WriteLine(res.ToString());
            Console.ReadLine();
        }
        public static int Difference(int[] a)
        {
            int min = a[0];
            int max = a[0];
            for(int i = 1; i<a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
                if(a[i]< min)
                {
                    min = a[i];
                }
            }
            return max - min;
        }
    }
}
