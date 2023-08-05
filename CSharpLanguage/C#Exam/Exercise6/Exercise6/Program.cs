using System;
namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输入：");
            string str=Console.ReadLine();
            if (str.IndexOf("+") > 0)
            {
                int num1 = int.Parse(str.Substring(0, str.IndexOf('+')));
                int num2 = int.Parse(str.Substring(str.IndexOf('+') + 1));
                int sum = num1 + num2;
                Console.WriteLine("输出：{0}={1}", str, sum);
            }
            else if (str.IndexOf("-") > 0)
            {
                int num1 = int.Parse(str.Substring(0, str.IndexOf('-')));
                int num2 = int.Parse(str.Substring(str.IndexOf('-') + 1));
                int sum = num1 - num2;
                Console.WriteLine("输出：{0}={1}", str, sum);
            }
            else if (str.IndexOf("*") > 0)
            {
                int num1 = int.Parse(str.Substring(0, str.IndexOf('*')));
                int num2 = int.Parse(str.Substring(str.IndexOf('*') + 1));
                int sum = num1 * num2;
                Console.WriteLine("输出：{0}={1}", str, sum);
            }
            else if (str.IndexOf("/") > 0)
            {
                int num1 = int.Parse(str.Substring(0, str.IndexOf('/')));
                int num2 = int.Parse(str.Substring(str.IndexOf('/') + 1));
                int sum = num1 / num2;
                Console.WriteLine("输出：{0}={1}", str, sum);
            }
            else
            {
                Console.WriteLine("输出：Error！");
            }

        }
    }
}