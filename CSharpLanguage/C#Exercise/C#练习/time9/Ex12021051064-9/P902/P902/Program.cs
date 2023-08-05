using System;
namespace P902
{
    class Person
    {
        private int no;
        public int No
        {
            get { return no; }
            set { no = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void Input()
        {
            Console.Write("  编号：");
            No = int.Parse(Console.ReadLine());
            Console.Write("  姓名：");
            Name = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("  编号：" + No);
            Console.WriteLine("  姓名：" + Name);
        }
    }
    class Student : Person
    {
        private string sclass;
        public string Sclass
        {
            get { return sclass; }
            set { sclass = value; }
        }
        private int degree;
        public int Degree
        {
            get { return degree; }
            set { degree = value; }
        }
        public  new void Input()
        {   
            
            base.Input();
            Console.Write("  班号：");
            Sclass = Console.ReadLine();
            Console.Write("  成绩：");
            Degree = int.Parse(Console.ReadLine());
        }
        public new void Display()
        { 
            base.Display();
            Console.WriteLine("  班号："+Sclass);
            Console.WriteLine("  成绩："+Degree);
        }

    }
    class Teacher :Person
    {
        private string prof;
        public string Prof
        {
            get { return prof; }
            set { prof = value; }
        }
        private string depart;
        public string Depart
        {
            get { return depart; }
            set { depart = value; }
        }
        public new void Input()
        {
            base.Input();
            Console.Write("  职称：");
            Prof = Console.ReadLine();
            Console.Write("  部门：");
            Depart = Console.ReadLine();
        }
        public new void Display()
        {
            base.Display();
            Console.WriteLine("  职称：" + Prof);
            Console.WriteLine("  部门：" + Depart);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Teacher T1 = new Teacher();
            Console.WriteLine("输入一个学生的数据：");
            s1.Input();
            Console.WriteLine("输入一个教师的数据：");
            T1.Input();
            Console.WriteLine("显示一个学生的数据：");
            s1.Display();
            Console.WriteLine("显示一个教师的数据：");
            T1.Display();
            Console.ReadKey();
        }
    }
}