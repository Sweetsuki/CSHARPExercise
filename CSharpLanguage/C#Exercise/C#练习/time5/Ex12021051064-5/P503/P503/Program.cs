using System;
namespace P503
{
    class Money
    {
        public decimal Gain(decimal x, decimal lilv, int n, out decimal money)
        {
            int i = 0;
            do
            {
                money = x * ( lilv / 100);
                x += money;
                i++;

            } while (i < n);
            return x;
        }
    }
    class Program
    { 
        
        static void Main(string[] args)
        {
            do
            {
                Console.Write("请输入本金金额：");
                decimal x = Convert.ToDecimal(Console.ReadLine()); 
                Console.Write("请输入年利率：");
                decimal lilv = Convert.ToDecimal(Console.ReadLine());
                Console.Write("请输入存入年份:");
                int year = int.Parse(Console.ReadLine());
                decimal y;
                Money M1 = new Money();
                decimal sum = M1.Gain(x, lilv, year, out y);
                Console.WriteLine("最后一年的年息为：{0}，本息合计:{1:F2}元(回车继续，Q键退出)",y,sum);
            } while (Console.ReadKey().KeyChar != 'Q');
            Console.WriteLine("请按任意键继续...");
        }
    }
}