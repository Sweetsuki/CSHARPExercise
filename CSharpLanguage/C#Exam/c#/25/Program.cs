 using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _25
{
    internal class Program
    {
        abstract class People
        {
            private string name;
            private int age;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int Age
            {
                get { return age; }
                set { age = value; }
            }
            public void work()
            {
                Console.WriteLine("每个人都必须工作! ");
            }
            public virtual void show()
            {
                Console.WriteLine("姓名：{0}，年龄：{1} ", name, age);
            }
        }
        class Student : People
        {
            private string school;
            public string School
            {
                get { return school; }
                set { school = value; }
            }
            public new void work()
            {
                Console.WriteLine("学生的主要任务是学习知识。");
            }
            public Student(string sname, int sage, string sschool)
            {
                Name = sname;
                Age = sage;
                School = sschool;
                Console.WriteLine("我是学生！我的姓名是：{0}",Name);
                Console.WriteLine("我的年龄是：{0}", Age);
                Console.WriteLine("在{0}学习", School);
                base.work();
                this.work();
            }
        }
        class Employer : People
        {
            private string company;
            public string Company
            {
                get { return company; }
                set { company = value; }
            }
            public new void work()
            {
                Console.WriteLine("职工的主要任务是运用知识去工作");
            }
            public Employer(string ename, int eage, string ecompany)
            {
                Name = ename;
                Age = eage;
                Company = ecompany;
                Console.WriteLine("我是程序员！我的姓名是：{0}", Name);
                Console.WriteLine("我的年龄是：{0}", Age);
                Console.WriteLine("在{0}工作", Company);
                base.work();
                this.work();
            }
        }
        static void Main(string[] args)
        {
            Student aStudent = new Student("张三",21,"信息学院");
            Console.WriteLine();
            Employer aworker = new Employer("李四",28,"阳光科技");
        }
    }
}
