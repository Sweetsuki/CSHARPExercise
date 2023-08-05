using System;
using System.Collections;
namespace P1202
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            a1.Add("华心童");
            //a1.Add("李宽");
            //a1.Add("王嘉俊");
            a1.Insert(0, "Messi");
            //a1.Add("焦心印");
            a1.Add("马磊");
            a1.Add("孙钰程");
            a1.Insert(4, "Jason");
            a1.AddRange(new ArrayList() { "李四", "张三" });
            Console.Write("排序前：");
            foreach (object obj in a1)
            {
                Console.WriteLine(obj);
            }
            a1.Sort();
            Console.Write("排序后：");
            foreach (object obj in a1)
            {
                Console.WriteLine(obj);
            }

            Console.ReadKey();
        }
    }
}