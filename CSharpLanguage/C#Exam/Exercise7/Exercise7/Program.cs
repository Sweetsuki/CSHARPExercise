using System;
namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输入：");
            int second=int.Parse(Console.ReadLine());
            //int hour = second / 3600;
            //int minute = second % 3600 / 60;
            //second=second%3600%60;
            //Console.Write("输出：");
            //Console.Write("{0}小时", hour);
            //if (minute > 0)
            //{
            //    Console.Write("{0}分", minute);
            //}
            //if (second > 0)
            //{
            //    Console.WriteLine("{0}秒", second);
            //}
            if (second % 3600 == 0)
            {
                int hour = second / 3600;
                Console.Write("输出：" + hour + "小时");
            }
            else if (second % 3600 != 0)
            {
                int hour = second / 3600;
                int minute = second % 3600 / 60;
                second = second % 3600 % 60;
                Console.WriteLine("输出：" + hour + "小时" + minute + "分" + second + "秒");
            }

        }
    }
}