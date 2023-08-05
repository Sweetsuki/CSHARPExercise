using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输入：");
            int grade=int.Parse(Console.ReadLine());
            if (grade >= 90 && grade <= 100)
                Console.WriteLine("90-100分优秀");
            else if(grade >= 80 && grade <= 89)
                Console.WriteLine("80-89分良好");
            else if (grade >= 70 && grade <= 79)
                Console.WriteLine("70-79分中等");
            else if (grade >= 60 && grade <= 69)
                Console.WriteLine("60-69分合格");
            else if (grade >= 0 && grade <= 59)
                Console.WriteLine("0-59分不及格");
            else
                Console.WriteLine("输出：您输入的数字不符合要求");
        }
    }
}
