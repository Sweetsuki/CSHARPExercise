using System;
namespace Exercise25
{
    abstract class People
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void work()
        {
            Console.WriteLine("每个人都必须工作！");
        }
        public virtual void Show()
        {
            Console.WriteLine("姓名："+name+",年龄"+age);
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
        public Student(string sname,int sage,string sschool)
        {
            School= sschool;
            Name = sname;
            Age = sage;
            Console.WriteLine("我是学生！我的姓名是：{0}",Name);
            Console.WriteLine("我的年龄是：{0}",Age);
            Console.WriteLine("在{0}学习",School);
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
        public Employer(string sname,int sage,string sschool)
        {
            Company = sschool;
            Name = sname;
            Age = sage;
            Console.WriteLine("我是程序员！我的姓名是：{0}", Name);
            Console.WriteLine("我的年龄是：{0}", Age);
            Console.WriteLine("在{0}学习", Company);
            base.work();
            this.work();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student aStudent = new Student("张三", 21, "信息学院");
            Console.WriteLine();
            Employer aworker = new Employer("李四", 28, "阳光科技");
        }
    }
}