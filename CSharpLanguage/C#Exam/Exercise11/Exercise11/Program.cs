using System;
namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("输入：");
            string str=Console.ReadLine();
            string[] s1 = str.Split('@');
            int index = str.IndexOf('@');
            int lastindex = str.LastIndexOf('@');
            int dotindex=str.IndexOf(".");
            string domain=str.Substring(index+1,dotindex-index-1);
            while (index == 0 || index == str.Length-1 || index != lastindex||index==-1)
            {
                Console.Write("输入：");
                str = Console.ReadLine();
                s1 = str.Split('@');
            }
            Console.Write("输出：用户名为" + s1[0]+"，邮箱域名为" + s1[1]+"二级域名为"+domain);
        }
    }
}