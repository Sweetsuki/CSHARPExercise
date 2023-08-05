using System;
using System.Reflection.Metadata;

namespace Exercise29
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true; ;
            while (flag)
            {
                try
                {
                    Console.Write("除数：");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("被除数：");
                    int y = int.Parse(Console.ReadLine());
                    int result = y / x;
                    Console.WriteLine("结果："+result);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message+".输入格式不正确！");
                    flag = false;
                }
                catch(DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message+"除数不为0");
                    flag = false;
                }
            }
        }
    }
}