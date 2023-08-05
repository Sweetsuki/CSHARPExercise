using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输入：");
            int time=int.Parse(Console.ReadLine());
            int hour = time / 3600;
            int minute = (time - hour * 3600)/60;
            int second = time - hour * 3600 - minute * 60;
            Console.Write("输出：");
            Console.Write("{0}小时", hour);
            if (minute > 0)
            {
                Console.Write("{0}分", minute);
            }
            if (second > 0)
            {
                Console.WriteLine("{0}秒", second);
            }
        }
    }
}
