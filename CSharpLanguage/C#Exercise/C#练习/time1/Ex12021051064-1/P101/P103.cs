using System;
namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            int  a;
            Console.Write("请输入a：");
            a = int .Parse(Console.ReadLine());
            int  b;
            Console.Write("请输入b：");
            b = int.Parse(Console.ReadLine());
            int result;
            result = a + b;
            Console.WriteLine("a+b={0}", result);
            Console.ReadKey();
        }
    }
}

