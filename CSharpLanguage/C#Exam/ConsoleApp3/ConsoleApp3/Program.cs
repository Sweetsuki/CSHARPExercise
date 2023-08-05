//刘然一
//using System;
//class Program
//{
//    static void Main(string[] args)
//    {
//        string str = Console.ReadLine();
//        string[] val = str.Split(',', ' ');
//        int[] arr = new int[str.Length];
//        int sum = 0;
//        for (int i = 0; i < val.Length; i++)
//        {
//            arr[i] = int.Parse(val[i]);
//            Console.WriteLine(arr[i]);
//            sum += arr[i];
//        }
//        Console.WriteLine("总和为：{0}", sum);
//    }
//}
//刘然二
//using System;
//class program
//{
//    static void Main(string[] args)
//    {
//        string str = "张三 李四 王五 赵二 赵二麻子";
//        string Name = Console.ReadLine();
//        string[] name = str.Split(' ');
//        str = str.Replace('张', '章');
//        Console.WriteLine("字符串为：{0}", str);
//        int sum = 0;
//        int i;
//        for (i = 0; i < name.Length; i++)
//        {
//            if (name[i].Substring(0, 1) == Name)
//            {
//                sum += 1;
//            }
//        }
//        Console.WriteLine("{0}姓氏共有{1}人", Name, sum);
//        Console.Write("输入想要删除的姓名:");
//        string rm = Console.ReadLine();
//        int s = str.IndexOf(rm);
//        string str1;
//        str1 = str.Remove(s, rm.Length);
//        Console.WriteLine("新的姓名串为：{0}", str1);
//        Console.Write("输入想要删除的姓名:");
//        string rm1 = Console.ReadLine();
//        int q = str.IndexOf(rm);
//        string str2;
//        str2 = str.Remove(q, rm1.Length);
//        Console.WriteLine("新的姓名串为：{0}", str2);
//    }
//}
//🐟1
//using System;

//namespace P801
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string str;
//            int sum = 0;
//            str = Console.ReadLine();
//            string[] nums = str.Split(new char[] { ',', ' ' });
//            for (int i = 0; i < nums.Length; i++)
//            {
//                sum += int.Parse(nums[i]);
//            }
//            Console.WriteLine(sum);
//        }
//    }
//}
//🐟二
using System;
namespace P802
{
    class Program
    {
        static void CountSurname(string s, string str)
        {
            int sum = 0;
            int index = str.IndexOf(s);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == str[index])
                    sum++;
            }
            Console.WriteLine("姓氏为{0}的人数：{1}", s, sum);
        }
        static void DeleteName(string s, string str)
        {
            int index = str.IndexOf(s);
            while (index < str.Length && str[index] != ' ')
            {
                str = str.Remove(index, 1);
            }
            Console.WriteLine(str);
        }

        static void Main(string[] args)
        {
            string str;
            str = Console.ReadLine();
            str = str.Replace("张", "章");
            Console.WriteLine("替换后的字符串：" + str);

            Console.Write("请输入要统计的姓氏：");
            string surname1 = Console.ReadLine();
            CountSurname(surname1, str);

            Console.Write("请输入要删除的姓名：");
            string surname2 = Console.ReadLine();
            DeleteName(surname2, str);
        }
    }
}
//🐟三
//using System;
//namespace P803
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("请输入身份证号：");
//            string str = Console.ReadLine();
//            string birth = str.Substring(6, 8);
//            string sex = str.Substring(16, 1);

//            IFormatProvider format = new System.Globalization.CultureInfo("zh-CN");
//            string TarStr = "yyyyMMdd";
//            DateTime birthday = DateTime.ParseExact(birth, TarStr, format);

//            Console.Write("该客户出生日期：");
//            Console.Write(string.Format("{0:yyyy年MM月dd日}", birthday));
//            if (int.Parse(sex) % 2 == 0)
//                Console.WriteLine("，性别是：女");
//            else
//                Console.WriteLine("，性别是：男");
//        }
//    }
//}
//🐟四
//using System;

//namespace P803
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("请输入订单编号：");
//            int no = int.Parse(Console.ReadLine());
//            DateTime date = DateTime.Now;
//            Console.WriteLine(string.Format("{0:yyyyMMddHHmmss}{1:d3}", date, no));
//        }
//    }
//}
//🐟五
//using System;
//namespace P805
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.Write("输入电子邮件：");
//            string mailstr = Console.ReadLine();

//            int index = mailstr.IndexOf('@');
//            int lastindex = mailstr.LastIndexOf('@');

//            if (index == -1 || index == 0 || index == mailstr.Length - 1 || lastindex != index)
//            {
//                Console.WriteLine("不是标准的电子邮件");
//                return;
//            }

//            string[] data = mailstr.Split("@");
//            Console.WriteLine("用户名是：" + data[0]);
//            Console.WriteLine("主机名是：" + data[1]);
//        }
//    }
//}