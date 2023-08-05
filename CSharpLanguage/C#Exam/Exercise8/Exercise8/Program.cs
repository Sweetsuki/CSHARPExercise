using System;
using System.Diagnostics.Contracts;

namespace Exercise8
{
    class Program
    {
        public static double Score(double[] array,out int fail)
        {
            double s = 0;
            double avg;
            fail = 0;
            for (int i = 0; i < array.Length; i++)
            {
                s += array[i];
                if (array[i] < 60) fail++;
            }
            avg = s / array.Length;
            return avg;
        }
        static void Main(string[] args)
        {
            double[] s = { 77, 90, 45.5, 56.6, 80.4, 75.5};
            int fail;
            Console.WriteLine("平均分数："+Score(s,out fail));
            Console.WriteLine("不及格人数："+fail);
        }
    }
}
