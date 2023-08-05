//using System;
//namespace P805
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int count = 0;
//            Console.Write("请输入电子邮箱：");
//            string email = Console.ReadLine();
//            string[] val = email.Split('@');
//            int x = email.IndexOf('@', 0);
//            while (x != -1)
//            {
//                Console.Write("这不是邮箱，请重新输入电子邮箱：");
//                email = Console.ReadLine();
//                val = email.Split('@');
//                x++;
//                x = email.IndexOf('@')+1;
//            }
//            Console.WriteLine("用户名是" + val[0]);
//            Console.WriteLine("主机名是" + val[1]);
//            Console.ReadKey();
//        }
//    }
//}
//using System;
//namespace P805
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int count = 0;
//            Console.Write("请输入电子邮箱：");
//            string email = Console.ReadLine();
//            string[] val = email.Split(new char[] { '@' });
//            int x = email.IndexOf('@', 0);
//            //for (int i = 0; i < val.Length; i++)
//            //{ if (email.IndexOf('@',i)=='@') count++; }
//            while (x != -1)
//            {

//                Console.Write("输入的不是电子邮箱，请重新输入电子邮箱：");
//                email = Console.ReadLine();
//                val = email.Split(new char[] { '@' });
//                x++;
//                x = email.IndexOf('@', x + 1);
//            }
//            Console.WriteLine("用户名是" + val[0]);
//            Console.WriteLine("主机名是" + val[1]);
//            Console.ReadKey();
//        }
//    }
//}
string s1 = Console.ReadLine();
string s2 = s1.Substring(s1.IndexOf("@") + 1);
if (s1.LastIndexOf("@") != s1.Length-1&& s1.IndexOf("@") != 0 && s2.IndexOf("@") == -1)
{
    Console.WriteLine("用户名是:{0}", s1.Substring(0, s1.IndexOf("@")));
    Console.WriteLine("主机名是:{0}", s2.Substring(0));
}
else
    Console.WriteLine("这不是电子邮箱！");
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSHARP_TEST
//{
//    class Program
//    {
//        //判断邮箱是否合法
//        static public bool judgeEmailAddress(string emailAddress)
//        {
//            //有“@”
//            if (emailAddress.IndexOf("@") == -1)
//            {
//                Console.WriteLine("输入的字符串中 没有@ ！");
//                return false;
//            }

//            //只有一个“@”
//            if (emailAddress.IndexOf("@") != emailAddress.LastIndexOf("@"))
//            {
//                Console.WriteLine("输入的字符串中 有多个@ ！");
//                return false;
//            }

//            //有“.”
//            if (emailAddress.IndexOf(".") == -1)
//            {
//                Console.WriteLine("输入的字符串中 没有.  ！");
//                return false;
//            }

//            //“@”出现在第一个“.”之前
//            if (emailAddress.IndexOf("@") > emailAddress.IndexOf("."))
//            {
//                Console.WriteLine("输入的字符串中 @没有出现在.之前！");
//                return false;
//            }

//            //“@”不可以是第一个元素
//            if (emailAddress.StartsWith("@"))
//            {
//                Console.WriteLine("输入的字符串中 @是第一个元素！");
//                return false;
//            }

//            //“.”不可以是最后一位
//            if (emailAddress.EndsWith("."))
//            {
//                Console.WriteLine("输入的字符串中 .是最后一位！");
//                return false;
//            }

//            //不能出现“@.”
//            if (emailAddress.IndexOf("@.") != -1)
//            {
//                Console.WriteLine("输入的字符串中 出现了@. !");
//                return false;
//            }

//            //不能出现“..”
//            if (emailAddress.IndexOf("..") != -1)
//            {
//                Console.WriteLine("输入的字符串中 出现了.. !");
//                return false;
//            }

//            return true;
//        }
//        static void Main(string[] args)
//        {
//            string email_address;
//            Console.WriteLine("请输入邮箱地址：");
//            email_address = Console.ReadLine();

//            //判断邮箱地址是否合法
//            if (judgeEmailAddress(email_address) == false)
//            {
//                Console.WriteLine("E-mail address is illegal !");
//            }
//            else
//            {
//                Console.WriteLine("输入格式正确！");
//            }
//        }
//    }
//}
