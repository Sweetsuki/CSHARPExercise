using System;
namespace P802
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string str = "张三 李四 孙五 马六 华八 程二 赵二麻子";
            Console.Write("请输入姓氏：");
            string first=Console.ReadLine();
            string[] name = str.Split(' ');
            for(int i = 0; i < name.Length; i++)
            {
                if (name[i].Substring(0,first.Length)==first)
                {
                    count++;
                }
            }
            Console.WriteLine("{0}姓共有{1}人",first,count);
            string s = str.Replace("张","章");
            Console.WriteLine("替换后的姓名串："+s);
            Console.Write("输入要删除的姓名：");
            string delname = Console.ReadLine();
            if (s.Contains(delname))
            {
                //Console.WriteLine("新的姓名串为：" + str.Replace(delname, ""));
                Console.WriteLine("新的姓名串为：" + s.Remove(s.IndexOf(delname), delname.Length));
            }
            else
            { 
                Console.WriteLine(s); 
            }
            Console.ReadKey();
        }
    }
}
 