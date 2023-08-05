using System;
using System.Collections;
namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> a1 = new List<string>();
            a1.Add("apple");
            a1.Add("orange");
            a1.Insert(0, "cherry");
            a1.Add("watermelon");
            a1.Add("pear");
            a1.Insert(2, "banana");
            a1.AddRange(new List<string>() { "pineapple", "grape" });
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