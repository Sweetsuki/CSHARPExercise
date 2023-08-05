using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static double GetMaxMin(out int max,out int min,params int[] s)
        {
            max =min= s[0];
            double sum = 0;
            for(int i=0;i<s.Length;i++)
            {
                sum += s[i];
                if (s[i] > max)
                    max = s[i];
                else if (s[i] < min)
                    min = s[i];
            }
            return sum / s.Length;
        }
        static void Main(string[] args)
        {
            int[] s = new int[10] { 98, 78, 58, 74, 85, 64, 59, 77, 78, 80 };
            int max;
            int min;
            double avg;
            avg=GetMaxMin(out max, out min, s);
            Console.WriteLine("最大值：{0}，最小值：{1}，平均值：{2:F2}", max, min, avg);
            avg=GetMaxMin(out max,out min,65, 34, 54, 44);
            Console.WriteLine("最大值：{0}，最小值：{1}，平均值：{2}", max, min,avg);
        }
    }
}
