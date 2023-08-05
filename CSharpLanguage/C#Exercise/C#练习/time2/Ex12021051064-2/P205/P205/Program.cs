using System;
namespace P205
{
    class Program
    {
        static void Main()
        {
            double d = 8123.4567;
            Console.WriteLine("变量的初始值是：{0}", d);
            Console.WriteLine("转换成5位的货币型：{0,5:C}",d);
            Console.WriteLine("转换成科学计数，5位小数：{0:E5}",d);
            Console.WriteLine("转换成固定精度，5位小数：{0:F5}",d);
            Console.WriteLine("转换成千位分隔：{0,3:n}",d);
            Console.WriteLine("请按任意键继续...");
            Console.ReadKey();
        }
    }
}