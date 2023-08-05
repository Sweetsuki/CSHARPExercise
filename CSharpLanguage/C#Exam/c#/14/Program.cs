using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string id=Console.ReadLine();
            int year =int.Parse(id.Substring(6,4));
            int month = int.Parse(id.Substring(10, 2));
            int day = int.Parse(id.Substring(12, 2));
            DateTime now = DateTime.Now;
            int age = now.Year - year;
            if (now.Month < month || (now.Month == month && now.Day < day))
                age--;
            Console.WriteLine("{0}年{1}月{2}日，今年{3}岁", year, month, day, age);
        }
    }
}
