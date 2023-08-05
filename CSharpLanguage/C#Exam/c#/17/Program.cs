using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    internal class Program
    {
        class Customer
        {
            private string cNo;
            private string cName;
            private int cPoints;
            private string cTelephone;
            public string CNo
            {
                get { return cNo; }
            }
            public string CName
            {
                get { return cName; }
            }
            public int CPoints
            {
                get { return cPoints; }
                set { cPoints = value ; }
            }
            public string CTelephone
            {
                get { return cTelephone; }
                set { cTelephone = value; }
            }
            public Customer() { }
            public Customer(string cNo, string cName,int cPoints)
            {
                this.cNo = cNo;
                this.cName = cName;
                this.cPoints = cPoints;
            }
            public void Show()
            {
                Console.WriteLine("顾客编号{0}，姓名：{1}，消费积分：{2},电话：{3}", cNo, cName, cPoints,cTelephone);
            }
            public void Buy(int x)
            {
                cPoints = 2 * x;
            }
            public void Exchange(int c)
            {
                cPoints = c;
                Console.Write("本次兑换{0}积分\n", cPoints);
                cPoints = -cPoints;
            }
        }
        static void Main(string[] args)
        {
            Customer c = new Customer("001","袁思怡",086);
            c.CTelephone = "12346789";
            c.Buy(86);
            c.Show();
            

        }
    }
}
