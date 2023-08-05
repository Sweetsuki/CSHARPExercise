using System;
namespace P801
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("输入：");
            String str = Console.ReadLine();
            string[] val = str.Split(new char[]{ ',',' '});
            int[] arr = new int[val.Length];
            for (int i = 0; i < val.Length; i++)
            {
                arr[i] = int.Parse(val[i]);
                sum += arr[i];
            }
            Console.WriteLine("输出："+sum);
            Console.ReadKey();
        }
    }
}
