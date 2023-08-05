using System;
namespace Exercise12
{
    class Prrogram
    {
        static void Main(string[] args)
        {
            Console.Write("输入任意100以内的正整数：");
            int number = int.Parse(Console.ReadLine());
            if (number <= 0 || number > 100)
            {
                Console.Write("输入任意100以内的正整数：");
                number = int.Parse(Console.ReadLine());
            }
            //string date = DateTime.Now.ToString("yyyyMMddssHHmmss");
            DateTime date= DateTime.Now;    
            Console.WriteLine("当前时间为：" + date.ToString("yyyy年MM月dd日HH时mm分ss秒"));
            Console.WriteLine("淘宝订单编号为：" + string.Format("{0:yyyyMMddHHmmss}{1:D3}", date, number));
            //Console.WriteLine("淘宝订单编号为：" + string.Format("{0:D2}",number));
        }
    }
}