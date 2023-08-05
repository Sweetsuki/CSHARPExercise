using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "张三 李四 王五 赵二 赵二麻子";
            string firstName=Console.ReadLine();
            string[] name = str.Split(' ');
            int count=0;
            for(int i=0;i<name.Length;i++)
            {
                if (name[i].Contains(firstName))
                    count++;
            }
            Console.WriteLine("{0}人",count);
            string char1 = Console.ReadLine();
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i].Contains(firstName))
                    Console.WriteLine(name[i]);
            }
        }
    }
}
