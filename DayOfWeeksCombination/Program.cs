using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeekCombination
{
    class Program
    { 
        int Fact(int n)
        {
            int p = 1;
            for(int i = 0; i <= n; i++)
            {
                p *= i;
            }
            return p;
        }
        string[] Combinate(string s, int k)
        {
            int n = Fact(s.Length) / (Fact(k) * Fact(s.Length - k));
            string[] str = new string[n];

            int i = 0;


            return str;
        }
        static void Main(string[] args)
        {
            string s = "";
            for (int i = 1; i <= 7; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    for (int k = j; k <= j; k++)
                    {
                        Console.Write(k);
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
