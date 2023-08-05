using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输入：");
            string length=Console.ReadLine();
            string[] arr = length.Split(' ');
            int a = int.Parse(arr[0]);
            int b = int.Parse(arr[1]);
            int c = int.Parse(arr[2]);
            if (a+b>c&&a+c>b&&b+c>a)
            { 
                double p = (a + b + c) / 2.0;
                double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("输出:{0:f2}",s);
            }
            else
            {
                Console.WriteLine("输出：Error!");
            }
        }
    }
}
