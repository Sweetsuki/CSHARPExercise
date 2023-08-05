using System;
namespace P204
{
    class Program
    {
        static void Main()
        {
            do
            {
                decimal lilv;
                int i = 0;
                Console.Write("请输入本金金额：");
                decimal money = Convert.ToDecimal(Console.ReadLine());
                Console.Write("请输入年利率：");
                lilv = Convert.ToDecimal(Console.ReadLine());
                Console.Write("请输入存入年份:");
                int year = int.Parse(Console.ReadLine());
                while (i < year)
                {
                    money = money * (1 + lilv /100);
                    i++;
                }
                Console.WriteLine("本息合计:{0:F2}元(回车继续，Q键退出)", money);
            } while (Console.ReadKey().KeyChar != 'Q');
            Console.WriteLine("请按任意键继续...");
        }
    }
}
