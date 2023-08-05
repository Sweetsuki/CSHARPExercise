using System;
namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入：");
            Console.Write("    ");
            string str = Console.ReadLine();
            Console.WriteLine("输出：");
            Console.Write("    ");
            Console.WriteLine(str.Substring(0,4));
            Console.WriteLine("    预定入住时间：{0}离店时间：{1}", str.Substring(5,10),str.Substring(15, 9));
            //DateTime dt1 =DateTime.Parse(str.Substring(5, 9));
            //DateTime dt2 = DateTime.Parse(str.Substring(15, 9));
            DateTime dt1 = new DateTime(2022,11,1);
            DateTime dt2 = new DateTime(2022,11,4);
            TimeSpan t=dt2.Subtract(dt1);
            Console.WriteLine("    预定天数：{0}天，费用：{1:F2}", t.Days, t.Days * 398.0);
            //int day;
            //if(dt1.Year!=dt2.Year)
            //{
            //    Console.WriteLine("这个住的不是宾馆，而是殡仪馆！");
            //}
            //else
            //{
            //    if(dt1.Month!=dt2.Month)
            //    {
            //        day=(dt2.Month-dt1.Month)*30;
            //    }else
            //    {
            //        day = dt2.Day - dt1.Day;
            //        Console.WriteLine("    预定天数：{0}天   ", day);
            //        Console.WriteLine("    总费用：{0:F2}元", day * 398);
            //    }     
            //}

        }
    }
}