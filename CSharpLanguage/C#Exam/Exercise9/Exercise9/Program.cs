using System;
namespace Exercise9
{
    class Program
    {
        public static double Array(double[] a, out int index)
        {
            index = 0;
            double max = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (max < a[i]) max = a[i];
                index = i;
            }
            return max;
        }
        static void Main(string[] args)
        {
            double[] a = { 77, 90, 89, 101, 50 };
            int index = 0;
            Console.WriteLine("最大值为：" + Array(a, out index));
            Console.WriteLine("最大值的索引为：" + index);
        }
        //public static int GetMax(out int index,params int[] b)
        //{
        //    int temp, max = b[0];
        //    index= 0;
        //    for (int i = 1; i <= b.Length - 1; i++)
        //    {
        //        if (b[i] > max)
        //        {
        //            max = b[i];
        //            index = i;
        //        }
        //    }
        //    return max;
        //}

        //public static void Main()
        //{
        //    int[] a = new int[8] { 3, 2, 1, 4, 6, 5, 7, 9 };
        //    //MyClass mc = new MyClass();
        //    int index = 0;
        //    int max = GetMax(out index,a);
        //    Console.WriteLine(index);
        //    Console.WriteLine(max);
        //}
    }
}
