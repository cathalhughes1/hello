using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello
{
    public class Arith
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sums(int c)
        {
            string s = c.ToString();
            int sums = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sums += s[i] - '0';
            }
            return sums;
        }

        //public int FindTwoSum(List<int> theList)
        //{
          //  Console.WriteLine("I just got executed!");
        //}

        public int nthPrime(int n)
        {
            List<int> numberList = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61 };
            return numberList[n-1];
        }

    }
}
