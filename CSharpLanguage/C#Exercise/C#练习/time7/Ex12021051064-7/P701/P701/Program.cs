using System;
namespace P701
{
    class Program
    { 
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static string Sum(string x, string y)
        {
            return x + y;
        }
        public static int Sum(int a, int b, int c)
        {
            int sum = 0;
            for(int i = a; i <= b; i+=c)
            {
                sum += i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("两个整数3+5的和为："+Sum(3,5));
            Console.WriteLine("两个小数3.2+5.6的和为："+Sum(3.2,5.6));
            Console.WriteLine("连个字符串的连接结果为："+Sum("C#","方法的重载"));
            Console.WriteLine("1到100，间隔为8的和为："+Sum(1,100,2));
            Console.ReadKey();
        }
    }
}