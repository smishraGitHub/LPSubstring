using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPSubstring
{
    class Program
    {
        static void Main(string[] args)
        {

            //string s = "aaaabbaa";
            string s = "babad";

            int n = s.Length;

            int start = 0;
            int end = 0;
            bool[,] dp = new bool[n, n];

            for(int i=n-1;i>=0;i--)
            {
                for(int j=i;j<n;j++)
                {
                    dp[i, j] = (s[i] == s[j] && (j - i < 2 || dp[i + 1, j - 1]));

                    if (dp[i,j] == true && j - i > end - start)
                    {
                        start = i;
                        end = j;
                    }
                }
            }

            string Result= n == 0 ? "":(n -1 == end ? s.Substring(start, end - 1) : s.Substring(start, end));

            Console.WriteLine(Result);

            //int[,] temp = new int[s.Length, s.Length];

            ////initialize angular position with 1

            //int i = 0;
            //int j = 0;

            //while (i<s.Length)
            //{
            //    temp[i, j] = 1;
            //    i++;
            //    j++;
            //}

            //i = 0;
            //j = 1;

            //int k = j - i;

            //while((k) <=(s.Length-1))
            //{
            //    if (s[i] == s[j] && temp[i+1,j-1] ==1)
            //    {
            //        temp[i, j] = 1;
            //    }
            //    else
            //    {
            //        temp[i, j] = 0;
            //    }
            //    i++;
            //    j++;

            //    if(j ==s.Length-1)
            //    {
            //        i = 0;
            //        k++;
            //        j = k;
            //    }
            //    else if (j>s.Length-1)
            //    {
            //        k++;
            //    }
            //}


            ////print temp table

            //for(i=0;i<s.Length;i++)
            //{
            //    for(j=0;j<s.Length;j++)
            //    {
            //        Console.Write(temp[i, j] + " ");
            //    }
            //    Console.WriteLine("");
            //}

            Console.ReadLine();

        }
    }
}
