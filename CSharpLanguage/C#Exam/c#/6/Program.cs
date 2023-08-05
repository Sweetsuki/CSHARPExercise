using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输入：");
            string str = Console.ReadLine();
            try 
            {
                string[] a = str.Split(new char[4] { '+', '-', '*', '/' });
                int number1 = int.Parse(a[0]);
                int number2 = int.Parse(a[1]);
                int result;
                if (str.Contains("+"))
                {
                    result = number1 + number2;
                    Console.WriteLine("输出：{0}={1}", str, result);
                }
                else if (str.Contains("-"))
                {
                    result = number1 - number2;
                    Console.WriteLine("输出：{0}={1}", str, result);
                }
                else if (str.Contains("*"))
                {
                    result = number1 * number2;
                    Console.WriteLine("输出：{0}={1}", str, result);
                }
                else if (str.Contains("/"))
                {
                    result = number1 / number2;
                    Console.WriteLine("输出：{0}={1}", str, result);
                }
            }
            catch
            {
                Console.WriteLine("输出：Error!");
            }
           
           
        }
    }
}
