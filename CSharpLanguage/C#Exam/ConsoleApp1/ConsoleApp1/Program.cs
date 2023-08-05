using System;
namespace p302
{
    class progarm
    {
        static void Main(string[] args)
        {
            //Console.Write("请输入三角形的三边（用空格分开）：");
            //string value = Console.ReadLine();
            //string[] vals = value.Split(" ");
            //while (!(int.Parse(vals[0]) + int.Parse(vals[1]) > int.Parse(vals[2]) && int.Parse(vals[1]) + int.Parse(vals[2]) > int.Parse(vals[0])
            //    && int.Parse(vals[0]) + int.Parse(vals[2]) > int.Parse(vals[1])))
            //{

            //    Console.Write("输入的不是三角形，请重新输入三边（用空格分开）:");
            //    value = Console.ReadLine();
            //    vals = value.Split(" ");

            //}
            //double s = 0;
            //double p = 0.5 * (int.Parse(vals[0]) + int.Parse(vals[1]) + int.Parse(vals[2]));
            //s = Math.Sqrt(p * (p - int.Parse(vals[0])) * (p - int.Parse(vals[1])) * (p - int.Parse(vals[2])));
            //Console.WriteLine("三角形的面积是：{0:f2}", s);
            Console.Write("输入：");
            int stopTime = 0,upTime = 0, downTime = 0, sum = 0;
            //int min = 1;
            string value = Console.ReadLine();
            string[] vals = value.Split(' ');
            int[] num = new int[vals.Length];
            stopTime = vals.Length*5;
            for(int i = 0; (i + 1) < vals.Length; i++)
            {
                num[i] = int.Parse(vals[i]);
                if(num[i] < num[i+1])
                upTime  += (num[i+1] - num[i])*6;
                else downTime += (num[i] - num[i+1])*4;
                
            }
            //if (num[0] == 1) stopTime += 5;
             if (num[0]>1) upTime +=(num[0]-1)*6; 
            sum = upTime + downTime + stopTime;
            Console.Write("输出：{0}",sum);
        }
    }
}