using System;
namespace Exercise15
{
    class Teacher
    {
        private string teaNo;
        public string TeaNo
        {
            get { return teaNo; }
            set { teaNo = value; }
        }
        private string teaName;
        public string TeaName
        {
            get { return teaName; }
            set { teaName = value; }
        }
        private DateTime teaBirth;
        public DateTime TeaBirth
        {
            get { return teaBirth; }
            set { teaBirth = value; }
        }
        public void InputInformation()
        {
            Console.Write("老师工号：");
            teaNo = Console.ReadLine();
            Console.Write("老师姓名：");
            teaName = Console.ReadLine();
            Console.Write("老师生日：");
            teaBirth=DateTime.Parse(Console.ReadLine());
        }
        public void ShowInformation()
        {
            Console.WriteLine("老师工号："+teaNo);
            Console.WriteLine("老师姓名："+teaName);
            Console.WriteLine("老师生日："+teaBirth);
            int old = DateTime.Now.Year-teaBirth.Year;
            if (DateTime.Now.Month < teaBirth.Month || (DateTime.Now.Month == teaBirth.Month && DateTime.Now.Day < teaBirth.Day))
                old--;
            Console.WriteLine("年龄："+old);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t1=new Teacher();
            t1.InputInformation();
            t1.ShowInformation();
        }
    }
}