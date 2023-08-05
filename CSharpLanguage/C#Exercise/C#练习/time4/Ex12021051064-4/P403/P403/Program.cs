using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P403
{
    class Program
    {
        class Customer
        {
            public string cNo;
            public string cno
            {
                get { return cNo; }
            }
            public string cName;
            public string cname
            {
                get { return cName; }
            }
            public string points;
            public string Points
            {
                get { return points; }
                set { points = value; }
            }
            public string telephone;
            public string Telephone
            {
                get { return telephone; }
                set { telephone = value; }
            }
            public int flag = 0;
            public void Input()
            {
                Console.Write("请输入客户编号：");
                cNo = Console.ReadLine();
                Console.Write("请输入客户姓名：");
                cName = Console.ReadLine();
                Console.Write("请输入客户电话：");
                telephone = Console.ReadLine();
                //if (flag == 0)
                //{
                //    Console.Write("请输入要增加的积分：");
                //    points = Console.ReadLine();
                //    flag = 1;
                //}
                //else
                //{
                //    Console.Write("请输入要扣除的积分：");
                //    points = Console.ReadLine();
                //}
            }
            public void Buy(int x)
            {
                x = Convert.ToInt32(points);
                Console.Write("请输入增加的积分：");
                points = Convert.ToString(Console.ReadLine());
            }
            public void Exchange(int c)
            {
                c = Convert.ToInt32(points);
                Console.Write("请输入要扣除的积分：");
                points= Convert.ToString(Console.ReadLine());
            }
            public void Show()
            {
                if (flag==0)
                {
                    Console.WriteLine("已经存入{0}积分",points);
                    Console.WriteLine("客户编号：{0}，客户姓名：{1}，客户联系电话：{2}，客户积分：{3}。", cNo, cName, telephone, points);
                    flag = 1;
                }
                else { Console.WriteLine("本次兑换{0}积分",points);
                    Console.WriteLine("客户编号：{0}，客户姓名：{1}，客户联系电话：{2}，客户积分：-{3}。", cNo, cName, telephone, points);
                }
                
            }
        }
        static void Main()
        {
            int x = 2000;
            int c = 5000;
            Customer customer1 = new Customer();
            customer1.Input();
            customer1.Buy(x);
            customer1.Show();
            Customer customer2 = customer1;
            customer2.Input();
            customer1.Exchange(c);
            customer2.Show();
            Console.ReadKey();
        }
    }
}
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//namespace ConsoleApplication2
//{
//    class Program
//    {

//        class Member
//        {
//            public string cNo;
//            public string cName;
//            public string points;
//            public string telephone;
//            public string CNo
//            {
//                get { return cNo; }
//            }
//            public string CName
//            {
//                get { return cName; }
//            }
//            public void Input()
//            {
//                Console.Write("请输入客户编号:");
//                cNo = Console.ReadLine();
//                Console.Write("请输入客户姓名:");
//                cName = Console.ReadLine();
//                Console.Write("请输入客户电话:");
//                telephone = Console.ReadLine();
//            }
//            int Flag = 0;
//            public void Buy()
//            {

//                if (Flag == 0)
//                {
//                    Console.Write("请输入要增加的积分:");
//                    points = Console.ReadLine();
//                    Console.WriteLine("已存入{0}积分", points);

//                }
//                else
//                {
//                    Console.Write("请输入要扣除的积分:");
//                    points = Console.ReadLine();
//                    Console.WriteLine("本次兑换{0}积分", points);
//                }
//            }
//            public void Show()
//            {
//                if (Flag == 0)
//                {
//                    Console.WriteLine("客户编号{0},客户姓名{1},客户联系电话:{2},客户积分{3}。", cNo, cName, telephone, points);
//                    Flag = 1;
//                }
//                else
//                    Console.WriteLine("客户编号{0},客户姓名{1},客户联系电话:{2},客户积分-{3}。", cNo, cName, telephone, points);
//            }

//        }
//        static void Main(string[] args)
//        {
//            Member s1 = new Member();
//            int i = 0;
//            for (i = 0; i < 2; i++)
//            {
//                s1.Input();
//                s1.Buy();
//                s1.Show();
//            }
//            Console.ReadKey();
//        }
//    }
//}