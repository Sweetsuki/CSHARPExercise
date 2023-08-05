using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    internal class Program
    {
        static double GetMax(out int number,params int[] s)
        {
            number = 0;
            int max = s[0];
            for(int i=1;i<s.Length;i++)
            {
                if (max < s[i])
                {
                    max = s[i];
                    number = i;
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] s = new int[6] { 60, 160, 150, 105, 100, 180 };
            int number;
            GetMax(out number, s);
            Console.WriteLine("该数组最大值为：{0},索引值为:{1}",GetMax(out number,s),number);
        }
    }
}
