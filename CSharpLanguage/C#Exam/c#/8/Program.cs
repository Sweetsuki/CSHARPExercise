using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        static double GetAvg(out int count,params int[] score)
        {
            count = 0;
            double sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];
                if (score[i] < 60)
                {
                    count++;
                }
            }
            return sum / score.Length;

        }
        static void Main(string[] args)
        {
            
            int[] score = new int[6] { 100, 98, 96, 95, 70, 99 };
            int count;
            //GetAvg(out count, score);
            Console.WriteLine("平均分为：{0}，不及格人数{1}", GetAvg(out count,score),count);
        }
    }
}
