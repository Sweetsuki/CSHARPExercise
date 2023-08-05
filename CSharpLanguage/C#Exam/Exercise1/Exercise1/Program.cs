using System;
namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一题
            //Console.Write("输入：");
            //string hobby = Console.ReadLine();
            //Console.WriteLine("输出：哇塞，太巧了，我也喜欢{0}。", hobby);
            //第二题
            Console.Write("输入：");
            int age = int.Parse(Console.ReadLine());
            if (age < 18)
                Console.WriteLine("你太小了，禁止饮酒！");
            else
                Console.WriteLine("你可以适量饮酒，但注意酒后不要开车！");
        }
    }
}