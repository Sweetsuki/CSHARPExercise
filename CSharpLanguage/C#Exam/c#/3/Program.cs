using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入：");
            string imformation;
            imformation =Console.ReadLine();
            string[] arr = imformation.Split(',');
            int time;
            string data1 = arr[2];
            string data2 = arr[3];
            string[] first = data1.Split('-');
            string[] last = data2.Split('-');
            time = int.Parse(last[2])-int.Parse(first[2]);
            double money = time * 398;
            Console.WriteLine("输入：");
            Console.WriteLine("{0},{1}", arr[0], arr[1]);
            Console.WriteLine("预定入住时间：{0},离店时间：{1}", arr[2], arr[3]);
            Console.WriteLine("预定天数：{0}天",time);
            Console.WriteLine("总费用：{0:f2}元",money);
        }
    }
}
