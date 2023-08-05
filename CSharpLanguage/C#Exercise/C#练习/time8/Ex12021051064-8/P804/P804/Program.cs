using System;
namespace P804
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输入任意100以内的正整数：");
            int count = int.Parse(Console.ReadLine());
            if (count <= 0 || count > 100)
            {
                Console.Write("输入任意100以内的正整数：");
                count = int.Parse(Console.ReadLine());
            }
            DateTime d = DateTime.Now;
            Console.WriteLine("当前时间为："+d.ToString("yyyy年MM月dd日HH时mm分ss秒"));
            Console.WriteLine("淘宝订单编号为："+ string.Format("{0:yyyyMMddHHmmss}{1:D3}",d,count));
            Console.ReadKey();
        }
    }
}