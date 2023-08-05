using System;
namespace P903
{
    class Student
    {
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string sex;
        public Student() 
        {
            Console.WriteLine("调用Stduent的构造函数");
            Console.Write("  学号：");
            Id = Console.ReadLine();
            Console.Write("  姓名：" );
            Name = Console.ReadLine();
            Console.Write("  性别：");
            sex = Console.ReadLine();
        }
        ~Student()
        {
            Console.WriteLine("调用Stduent的析构函数");
        }
        public void print()
        {
            Console.WriteLine("——此处是Student类——");
            Console.WriteLine("  学号：" + Id);
            Console.WriteLine("  姓名：" + Name);
            Console.WriteLine("  性别：" + sex);
        }
    }
    class Graduate:Student
    {
        private int pScore;
        public int PScore
        {
            get { return pScore; }
            set { pScore = value; }
        }
        private int eScore;
        public int EScore
        {
            get { return eScore; }
            set { eScore = value; }
        }
        public Graduate()
        {
            Console.WriteLine("调用Graduate的构造函数");
            Console.Write("  专业成绩：");
            PScore=int.Parse(Console.ReadLine());
            Console.Write("  高考成绩：");
            EScore=int.Parse(Console.ReadLine());

        }
        ~Graduate()
        {
            Console.WriteLine("调用Graduate的析构函数");
        }
        public new void print()
        {
            base.print();
            Console.WriteLine("——此处是Graduate类——");
            Console.WriteLine("  专业成绩：" + PScore);
            Console.WriteLine("  高考成绩：" + EScore);
        }
    }
    class Postgraduate : Graduate
    {
        private string research;
        public string Research
        {
            get { return research; }
            set { research = value;}
        }
        private string instructorname;
        public string Instructorname
        {
            get { return instructorname; }
            set { instructorname = value; }
        }
        public Postgraduate()
        {
            Console.WriteLine("调用Postgraduate的构造函数");
            Console.Write("  研究方向：");
            Research = Console.ReadLine();
            Console.Write("  导师姓名：");
            Instructorname = Console.ReadLine();
        }
        ~Postgraduate()
        {
            Console.WriteLine("调用Postgraduate的析构函数");
        }
        public new void print()
        {
            base.print();
            Console.WriteLine("——此处是 Postgraduate类——");
            Console.WriteLine("  研究方向：" + research);
            Console.WriteLine("  导师姓名：" + instructorname);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Postgraduate P1=new Postgraduate();
            //P1.Id = "12021051001";
            //P1.Name = "华心童";
            //P1.sex = "男";
            //P1.PScore = 90;
            //P1.EScore = 99;
            //P1.Research = "Computer";
            //P1.Instructorname = "张三";
            P1.print();
            Console.ReadKey();
        }
    }
}