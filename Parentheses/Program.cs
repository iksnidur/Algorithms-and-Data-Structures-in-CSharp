using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp = "(()1()";
            int res = Parentheses(temp);
            Console.WriteLine(res);
            Console.ReadLine();
        }
        public static int Parentheses(string s)
        {
            int maxLPar = 0;
            int maxRPar = 0;
            int tempLPar = 0;
            int tempRPar = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    tempLPar += 1;

                }
                else if(s[i] == ')')
                {
                    tempRPar += 1;
                }
                else
                {
                    if (tempLPar >maxLPar)
                    {
                        maxLPar = tempLPar;
                    }
                    if (tempRPar > maxRPar)
                    {
                        maxRPar = tempRPar;
                    }
                    tempLPar = 0;
                    tempRPar = 0;
                }
            }
            if (maxLPar != maxRPar)
            {
                maxLPar = 0;
            }
            return maxLPar;
        }
    }
}
