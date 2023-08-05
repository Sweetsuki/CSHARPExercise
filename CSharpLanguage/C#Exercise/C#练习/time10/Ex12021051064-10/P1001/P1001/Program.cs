using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1001
{
    class Student
    {
        protected int sNo;
        protected string sName;
        protected string tName;
        public void Setdata(int sNo, string sName, string tName)
        {
            this.sNo = sNo;
            this.sName = sName;
            this.tName = tName;
        }
        public virtual void Display()
        {
            Console.WriteLine("本科生  学号：{0}，姓名：{1}，班主任：{2}", sNo, sName, tName);
        }
    }
    class Graduate : Student
    {
        public override void Display()
        {
            Console.WriteLine("研究生  学号：{0}，姓名：{1}，导师：{2}", sNo, sName, tName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student();
            Student S2 = new Graduate();
            S1.Setdata(064, "华心童", "张三");
            S1.Display();
            S2.Setdata(064, "华心童", "李四");
            S2.Display();
            Console.ReadKey();
        }
    }
}