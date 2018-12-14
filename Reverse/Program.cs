using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp = "IGLOVE";
            string res = Reversal(temp);
            Console.WriteLine(res);
            Console.ReadLine();
        }
        public static string Reversal(string s)
        {
            char[] result = new char[s.Length];
            for(int i =0; i<s.Length; i++)
            {
                if (i == 0 || i == s.Length-1)
                {
                    result[i] = s[i];
                }
                else
                {
                    result[i] = s[s.Length - 1 - i];
                }
                
            }
            return new string(result);
        }
    }
}
