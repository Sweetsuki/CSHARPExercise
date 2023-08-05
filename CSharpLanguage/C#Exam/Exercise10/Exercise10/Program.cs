using System;
namespace Exercise10
{
    class Program
    {
        //功能：返回数组 s 的平均值，输出参数 max 和 min 分别为 s 数组的最大值和最小值
        static double GetMaxMin(out int max, out int min, params int[] s)
        {
            //补充代码实现功能
            int sum = 0;
            max = s[0];min = s[0];
            for(int i=0;i<s.Length;i++)
            {
                sum += s[i];
                if (max < s[i]) max= s[i];
                if (min > s[i]) min= s[i];
            }
            int avg = sum / s.Length;
            return avg;
        }
        //int GetAvg(ref int count)
        //{
        //    if(s==null) return 0;
        //}
        static void Main(string[] args)
        {
            int[] s = new int[10] { 98, 78, 58, 74, 85, 64, 59, 77, 87, 80 };
            int max, min, avg;
            //调用 GetMaxMin 求 s 数组的最值和平均分数，分别放入 max,min,avg，并输出
            Console.WriteLine("平均值：" + GetMaxMin(out max, out min, s));
            Console.WriteLine("最大值：" + max + ",最小值：" + min);
            //利用可变长数组，调用 GetMaxMin 求 65，34，54，44 的平均值和最值
            //int[] s1={ 65,34,54,44 };
            //分别放入 max,min,avg，并输出
            Console.WriteLine("平均值：" + GetMaxMin(out max, out min, 65, 34, 54, 44));
            Console.WriteLine("最大值：" + max + ",最小值：" + min);
        }
    }
}