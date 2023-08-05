using System;
namespace P304
{
    class Program
    {
        static void Main()
        {
            int[] num = new int[5];
            int[] nums = new int[5];
            int[] num1 = new int[5];
            int[] result = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Random a = new Random();
                num[i] = a.Next(0,100);
                nums[i] = a.Next(0,100);
                Random b = new Random();
                if (b.Next(0, 2) == 0)
                {
                    Console.WriteLine("{0}-{1}", num[i], nums[i]);
                    result[i] = num[i] - nums[i];
                }
                else
                {
                    Console.WriteLine("{0}+{1}", num[i], nums[i]);
                    result[i] = num[i] + nums[i];
                }
            }
            Console.WriteLine("请输入结果(用空格分开)");
            string value = Console.ReadLine();
            string[] vals = value.Split(' ');
            for (int i = 0; i < vals.Length; i++)
            {
               num1[i] = int.Parse(vals[i]);
            }
            int Count = 0;
            for (int i = 0; i < 5; i++)
            {
                if (result[i]== num1[i])
                {
                    Count++;
                }
            }
            double j = 5;
            double Accuracy =(double) Count/j;
            Console.WriteLine("正确率为：{0:P2}请按任意键继续...", Accuracy);
            Console.ReadKey();
        }
    }
}