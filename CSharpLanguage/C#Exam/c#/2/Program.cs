using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输入:");
            int age;
            age = int.Parse(Console.ReadLine());
            if (age < 18)
                Console.WriteLine("输出：你太小了，禁止饮酒！");
            else
                Console.WriteLine("输出：你可以适量饮酒，但注意酒后不要开车！");
        }
    }
}
