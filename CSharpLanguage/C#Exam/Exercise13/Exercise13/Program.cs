using System;
namespace Exercise13
{
    //方法一
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            //string str = "张三 李三 王五 赵二 赵二麻子";
            Console.Write("输入一系列名字：");
            string str = Console.ReadLine();
            string[] val = str.Split(' ');
            Console.Write("输入：");
            string surname = Console.ReadLine();
            str.StartsWith(surname);
            for (int i = 0; i < val.Length; i++)
            {
                if (str.StartsWith(surname)) count++;
                //if (val[i].Substring(0, surname.Length) == surname) count++;
            }
            Console.WriteLine("输出：{0}人", count);
            Console.Write("输入：");
            string character = Console.ReadLine();//输入某个字  
            Console.Write("输出：");
            for (int i = 0; i < val.Length; i++)
            {
                if (val[i].Contains(character))
                {
                    Console.Write(val[i] + ' ');
                }
            }
        }
    }
    //方法二
    //class Program
    //{
    //    static void CountSurname(string str, string surname)
    //    {
    //        int sum = 0;
    //        int index = str.IndexOf(surname);
    //        for (int i = 0; i < str.Length; i++)
    //        {
    //            if (str[i] == str[index]) sum++;
    //        }
    //        Console.WriteLine("输出：" + sum + "人");
    //    }
    //    static void OwnName(string str, string name)
    //    {
    //        string[] s1 = str.Split(' ');
    //        for (int i = 0; i < s1.Length; i++)
    //        {
    //            if (s1[i].Contains(name))
    //                Console.WriteLine("输出：" + s1[i]);
    //        }
    //    }
    //    static void Main(string[] args)
    //    {
    //        Console.Write("请输入一系列名字：");
    //        string str = Console.ReadLine();
    //        //姓氏
    //        Console.Write("输入：");
    //        string surname = Console.ReadLine();
    //        CountSurname(str, surname);
    //        //名字
    //        Console.Write("输入：");
    //        string name = Console.ReadLine();
    //        OwnName(str, name);
    //    }
    //   }
}
