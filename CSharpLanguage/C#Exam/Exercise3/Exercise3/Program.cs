using System;
namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输入：");
            string str1=Console.ReadLine();
            string[] vals = str1.Split(' ');
            int[] num = new int[3];
            int p;
            for(int i = 0; i < vals.Length; i++)
            {
                num[i]= int.Parse(vals[i]);
            }
            //num[0] = int.Parse(vals[0]);
            //num[1] = int.Parse(vals[1]);
            //num[2] = int.Parse(vals[2]);
            if(num[0] + num[1] <= num[2] || num[0] + num[2] <= num[1] || num[2] + num[1] <= num[0])
            {
                Console.WriteLine("输出：Error!");
            }
            else
            {
                p = (num[0] + num[1] + num[2]) / 2;
                double S = Math.Sqrt(p * (p - num[0]) * (p - num[1]) * (p - num[2]));
                string e = Math.Round(S,2).ToString("0.000");
                Console.WriteLine("输出：{0:F2}",S);
                Console.WriteLine("输出：{0:F4}", e);
            }
           
        }
    }
}