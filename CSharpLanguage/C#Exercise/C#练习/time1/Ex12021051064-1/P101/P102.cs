using System;
namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("请输入你的姓名：");
            name = Console.ReadLine();
            int year;
            Console.WriteLine("请输入出生年份：");
            year = int.Parse(Console.ReadLine());
            int old;
            old = 2022 - year + 1;
            Console.WriteLine("{0}出生于{1}年，今年{2}岁了：", name, year, old);
            Console.ReadKey();
        }
    }
}
