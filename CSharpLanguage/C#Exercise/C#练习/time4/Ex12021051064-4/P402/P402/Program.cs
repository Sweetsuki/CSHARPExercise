using System;
namespace Teacher
{
    class Teacher
    {
        protected string teaNo;
        public string teaName;
        protected DateTime teaBirth;
        protected string teaTitle;
        private string teaDep;
        public void InputInformation()
        {
            Console.Write("请输入工号：");
            teaNo = Console.ReadLine();
            Console.Write("请输入姓名：");
            teaName = Console.ReadLine();
            Console.Write("请输入日期：");
            teaBirth = Convert.ToDateTime(Console.ReadLine());
            Console.Write("请输入职称：");
            teaTitle = Console.ReadLine();
            Console.Write("请输入部门：");
            teaDep = Console.ReadLine();
        }
        public void ShowInformation()
        {
            Console.Write("工号--{0};", teaNo);
            Console.Write("姓名--{0};", teaName);
            Console.Write("生日--{0};", teaBirth);
            Console.Write("职称--{0};", teaTitle);
            Console.WriteLine("部门--{0};", teaDep);
            Console.Write("请按任意键继续...");
        }
        public void teacher()
        {
            teaNo = "10";
            teaName = "Jane";
            teaBirth = DateTime.Parse("2021-3-22");
            teaTitle = "教授";
            teaDep = "人文学院";
            Console.WriteLine("工号--{0};姓名--{1};生日--{2};职称--{3};部门--{4};", teaNo, teaName, teaBirth, teaTitle, teaDep);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Teacher T1 = new Teacher();
            T1.teacher();
            T1.InputInformation();
            T1.ShowInformation();
            Console.ReadKey();
        }
    }
}
