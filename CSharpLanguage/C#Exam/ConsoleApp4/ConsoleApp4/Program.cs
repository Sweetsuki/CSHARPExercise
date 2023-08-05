using System;
namespace p902
{
    public class Person
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
            Console.WriteLine("编号：");
            No = int.Parse(Console.ReadLine());
            Console.WriteLine("姓名：");
            Name = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("编号：{0}", No);
            Console.WriteLine("姓名：{0}", Name);
        }
    }
    public class Student : Person
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
        public new void Iuput()
        {
            base.Input();
            Console.WriteLine("班号：");
            Sclass = Console.ReadLine();
            Console.WriteLine("成绩：");
            Degree = int.Parse(Console.ReadLine());
        }
        public new void Display()
        {
            base.Display();
            Console.WriteLine("班号：{0}", Sclass);
            Console.WriteLine("成绩：{0}", Degree);
        }
    }
    public class Teacher : Person
    {
        private string prof;
        public string Prof
        {
            get { return prof; }
            set { prof = value; }
        }
        private int depart;
        public int Depart
        {
            get { return depart; }
            set { depart = value; }
        }
        public new void Iuput()
        {
            base.Input();
            Console.WriteLine("职称：");
            Prof = Console.ReadLine();
            Console.WriteLine("部门：");
            Depart = int.Parse(Console.ReadLine());
        }
        public new void Display()
        {
            base.Display();
            Console.WriteLine("职称：{0}", Prof);
            Console.WriteLine("部门：{0}", Depart);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Teacher teacher = new Teacher();
            Console.WriteLine("输入一个学生数据：");
            student.Input();
            Console.WriteLine("输入一个教师数据：");
            teacher.Input();
            Console.WriteLine("显示一个学生数据：");
            student.Display();
            Console.WriteLine("显示一个教师数据：");
            teacher.Display();
            Console.ReadKey();
        }

    }
}