using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d = DateTime.Now;
            string date = d.ToString("yyyyMMddHHmmss");
            string str = Console.ReadLine();
            Console.WriteLine(string.Concat(date, str.PadLeft(3, '0')));
        }
    }
}
